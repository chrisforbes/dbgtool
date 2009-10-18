using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Ijw.Cricket.NativeDebugApi
{
    [StructLayout(LayoutKind.Sequential)]
    public class STARTUPINFO
    {
        public STARTUPINFO()
        {
            this.cb = Marshal.SizeOf(this);
            this.hStdInput = new SafeFileHandle(new IntPtr(0), false);
            this.hStdOutput = new SafeFileHandle(new IntPtr(0), false);
            this.hStdError = new SafeFileHandle(new IntPtr(0), false);
        }

        public Int32 cb;
        public string lpReserved;
        public string lpDesktop;
        public string lpTitle;
        public Int32 dwX;
        public Int32 dwY;
        public Int32 dwXSize;
        public Int32 dwYSize;
        public Int32 dwXCountChars;
        public Int32 dwYCountChars;
        public Int32 dwFillAttribute;
        public Int32 dwFlags;
        public Int16 wShowWindow;
        public Int16 cbReserved2;
        public IntPtr lpReserved2;
        public SafeFileHandle hStdInput;
        public SafeFileHandle hStdOutput;
        public SafeFileHandle hStdError;
    }

    [StructLayout(LayoutKind.Sequential)]
    public class PROCESS_INFORMATION
    {
        public IntPtr hProcess;
        public IntPtr hThread;
        public int dwProcessId;
        public int dwThreadId;
    }
}
