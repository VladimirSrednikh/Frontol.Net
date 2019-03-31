using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ServiceProcess;

namespace FrontolSO
{
    public struct TServiceInfo
    {
        public string ServiceName;
        public string lpServiceStartName;
        public string Password;
        public string lpBinaryPathName;
        public UInt32 StartType;
        public ServiceControllerStatus dwCurrentState;
        public string StateAsStr() {
            switch (dwCurrentState)
            {
                case ServiceControllerStatus.Stopped: return "Остановлена";
                case ServiceControllerStatus.StartPending: return "Ожидание запуска";
                case ServiceControllerStatus.StopPending: return "Ожидание остановки";
                case ServiceControllerStatus.Running: return "Запущена";
                case ServiceControllerStatus.ContinuePending: return "Ожидание продолжения";
                case ServiceControllerStatus.PausePending: return "Ожидание паузы";
                case ServiceControllerStatus.Paused: return "Пауза";
                default: return "Unknown";
            }                
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public class ServiceConfigInfo
    {
        [MarshalAs(UnmanagedType.U4)]
        public UInt32 ServiceType;
        [MarshalAs(UnmanagedType.U4)]
        public UInt32 StartType;
        [MarshalAs(UnmanagedType.U4)]
        public UInt32 ErrorControl;
        [MarshalAs(UnmanagedType.LPWStr)]
        public String BinaryPathName;
        [MarshalAs(UnmanagedType.LPWStr)]
        public String LoadOrderGroup;
        [MarshalAs(UnmanagedType.U4)]
        public UInt32 TagID;
        [MarshalAs(UnmanagedType.LPWStr)]
        public String Dependencies;
        [MarshalAs(UnmanagedType.LPWStr)]
        public String ServiceStartName;
        [MarshalAs(UnmanagedType.LPWStr)]
        public String DisplayName;
    }

    class ServiceInfo
    {
        public static readonly uint SERVICE_BOOT_START   = 0x00000000;
        public static readonly uint SERVICE_SYSTEM_START = 0x00000001;
        public static readonly uint SERVICE_AUTO_START = 0x00000002;
        public static readonly uint SERVICE_DEMAND_START = 0x00000003;
        public static readonly uint SERVICE_DISABLED = 0x00000004;
          
        internal static class NativeMethods
        {
            [Flags]
            public enum ServiceAccessRights : int
            {
                SERVICE_QUERY_CONFIG = 0x0001,          // Required to call the QueryServiceConfig and QueryServiceConfig2 functions to query the service configuration. 
                SERVICE_CHANGE_CONFIG = 0x0002,         // Required to call the ChangeServiceConfig or ChangeServiceConfig2 function to change the service configuration. Because this grants the caller the right to change the executable file that the system runs, it should be granted only to administrators. 
                SERVICE_QUERY_STATUS = 0x0004,          // Required to call the QueryServiceStatusEx function to ask the service control manager about the status of the service. 
                SERVICE_ENUMERATE_DEPENDENTS = 0x0008,  // Required to call the EnumDependentServices function to enumerate all the services dependent on the service. 
                SERVICE_START = 0x0010,                 // Required to call the StartService function to start the service. 
                SERVICE_STOP = 0x0020,                  // Required to call the ControlService function to stop the service. 
                SERVICE_PAUSE_CONTINUE = 0x0040,        // Required to call the ControlService function to pause or continue the service. 
                SERVICE_INTERROGATE = 0x0080,           // Required to call the ControlService function to ask the service to report its status immediately. 
                SERVICE_USER_DEFINED_CONTROL = 0x0100,  // Required to call the ControlService function to specify a user-defined control code.
                SERVICE_ALL_ACCESS = 0xF01FF            // Includes STANDARD_RIGHTS_REQUIRED in addition to all access rights in this table. 
            }

                [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
            public static extern IntPtr OpenSCManager(
                [MarshalAs(UnmanagedType.LPWStr)] string machineName,
                [MarshalAs(UnmanagedType.LPWStr)] string databaseName,
                int desiredAccess
            );

            [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
            public static extern IntPtr OpenService(
                IntPtr scManager,
                [MarshalAs(UnmanagedType.LPWStr)] string serviceName,
                ServiceAccessRights desiredAccess
              );

            [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
            public static extern int QueryServiceConfig(
                IntPtr service,
                IntPtr queryServiceConfig,
                int bufferSize,
                ref int bytesNeeded
              );

            [DllImport("advapi32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool CloseServiceHandle(IntPtr hSCObject);
        }

        private enum SCManagerAccess : int
        {
            GENERIC_ALL = 0x10000000
        }

        static public void GetServiceInfo(string AServiceName, out TServiceInfo svi) {
            if (AServiceName.Equals(""))
                throw new ArgumentException("ServiceName must contain a valid service name.");
            IntPtr m_scmHandle = IntPtr.Zero;
            IntPtr service = IntPtr.Zero;

            m_scmHandle = NativeMethods.OpenSCManager(null, null, (int)SCManagerAccess.GENERIC_ALL);
            if (m_scmHandle == IntPtr.Zero)
                throw new Win32Exception(Marshal.GetLastWin32Error(), "Unable to open handle to Service Control Manager");
            try
            {
                service = NativeMethods.OpenService(m_scmHandle, AServiceName, NativeMethods.ServiceAccessRights.SERVICE_QUERY_CONFIG);
                if (service == IntPtr.Zero)
                    throw new Win32Exception(Marshal.GetLastWin32Error(), "Service does not exist");

                int bytesNeeded = 0;
                var sci = new ServiceConfigInfo();

                int retCode = NativeMethods.QueryServiceConfig(service, IntPtr.Zero, 0, ref bytesNeeded);
                if (retCode == 0 && bytesNeeded == 0)
                    throw new Win32Exception(Marshal.GetLastWin32Error());

                IntPtr qscPtr = Marshal.AllocCoTaskMem(bytesNeeded);
                try
                {
                    retCode = NativeMethods.QueryServiceConfig(service, qscPtr, bytesNeeded, ref bytesNeeded);
                    if (retCode == 0)
                        throw new Win32Exception();

                    sci = (ServiceConfigInfo)Marshal.PtrToStructure(qscPtr, typeof(ServiceConfigInfo));
                    svi = new TServiceInfo();
                    svi.ServiceName = AServiceName;
                    svi.lpBinaryPathName = sci.BinaryPathName;
                    svi.StartType = sci.StartType;
                    svi.lpServiceStartName = sci.ServiceStartName;
                    svi.Password = "";
                    ServiceController sc = new ServiceController(AServiceName);
                    svi.dwCurrentState = sc.Status;
                }
                finally
                {
                    Marshal.FreeCoTaskMem(qscPtr);
                }
            }
            finally
            {
                NativeMethods.CloseServiceHandle(service);
            }
        }

        static public void ChangeServiceConfig(string AServiceName, TServiceInfo svi)
        {
            if (AServiceName.Equals(""))
                throw new ArgumentException("ServiceName must contain a valid service name.");
            IntPtr m_scmHandle = IntPtr.Zero;
            IntPtr service = IntPtr.Zero;

            m_scmHandle = NativeMethods.OpenSCManager(null, null, (int)SCManagerAccess.GENERIC_ALL);
            if (m_scmHandle == IntPtr.Zero)
                throw new Win32Exception(Marshal.GetLastWin32Error(), "Unable to open handle to Service Control Manager");
            try
            {
                service = NativeMethods.OpenService(m_scmHandle, AServiceName, NativeMethods.ServiceAccessRights.SERVICE_QUERY_CONFIG);
                if (service == IntPtr.Zero)
                    throw new Win32Exception(Marshal.GetLastWin32Error(), "Service does not exist");

                int bytesNeeded = 0;
                var sci = new ServiceConfigInfo();

                int retCode = NativeMethods.QueryServiceConfig(service, IntPtr.Zero, 0, ref bytesNeeded);
                if (retCode == 0 && bytesNeeded == 0)
                    throw new Win32Exception(Marshal.GetLastWin32Error());

                IntPtr qscPtr = Marshal.AllocCoTaskMem(bytesNeeded);
                try
                {
                    retCode = NativeMethods.QueryServiceConfig(service, qscPtr, bytesNeeded, ref bytesNeeded);
                    if (retCode == 0)
                        throw new Win32Exception();

                    sci = (ServiceConfigInfo)Marshal.PtrToStructure(qscPtr, typeof(ServiceConfigInfo));
                    svi = new TServiceInfo();
                    svi.ServiceName = AServiceName;
                    svi.lpBinaryPathName = sci.BinaryPathName;
                    svi.StartType = sci.StartType;
                    svi.lpServiceStartName = sci.ServiceStartName;
                    svi.Password = "";
                    ServiceController sc = new ServiceController(AServiceName);
                    svi.dwCurrentState = sc.Status;
                }
                finally
                {
                    Marshal.FreeCoTaskMem(qscPtr);
                }
            }
            finally
            {
                NativeMethods.CloseServiceHandle(service);
            }
        }

    }

    
}
