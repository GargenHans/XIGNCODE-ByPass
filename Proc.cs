using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.InteropServices;

    namespace XIGNCODE_ByPasser_By_DEMONKINGLBH
    {
        public class ProcessSuspender
        {
            /// <summary>
            /// Suspend or resume a process with ease.
            /// </summary>
            /// <param name="ProcessName">The name of the process.</param>
            /// <param name="SuspendOrResume">An option to suspend or resume.</param>
            public static void FuckUpThePROTECTION(string ProcessName, SUSPEND_RESUME SuspendOrResume)
            {
                foreach (System.Diagnostics.Process Proc in System.Diagnostics.Process.GetProcessesByName(ProcessName))
                {
                    foreach (System.Diagnostics.ProcessThread ProcThrd in Proc.Threads)
                    {
                        if (SuspendOrResume == SUSPEND_RESUME.Suspend)
                        {
                            SuspendThread(OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)ProcThrd.Id));
                        }
                        else
                        {
                            ResumeThread(OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)ProcThrd.Id));
                        }
                    }
                }
            }

            public enum SUSPEND_RESUME { Suspend, Resume }

            #region "Imports and stuff"
            [DllImport("kernel32.dll")]
            static extern uint SuspendThread(IntPtr hThread);
            [DllImport("kernel32.dll")]
            static extern int ResumeThread(IntPtr hThread);
            [DllImport("kernel32.dll")]
            static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

            private enum ThreadAccess : int
            {
                TERMINATE = (0x0001),
                SUSPEND_RESUME = (0x0002),
                GET_CONTEXT = (0x0008),
                SET_CONTEXT = (0x0010),
                SET_INFORMATION = (0x0020),
                QUERY_INFORMATION = (0x0040),
                SET_THREAD_TOKEN = (0x0080),
                IMPERSONATE = (0x0100),
                DIRECT_IMPERSONATION = (0x0200)
            }
            #endregion
        }
    }
