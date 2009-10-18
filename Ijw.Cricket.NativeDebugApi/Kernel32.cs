using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Ijw.Cricket.NativeDebugApi
{
    public static class Kernel32
    {
        [DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(IntPtr handle);

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetThreadContext(IntPtr hThread, IntPtr hContext);

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetThreadContext(IntPtr hThread, IntPtr lpContext);

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess,
            [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle,
            uint dwThreadId);

        [DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress,
          byte[] lpBuffer, UIntPtr nSize, out int lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress,
          byte[] lpBuffer, UIntPtr nSize, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DebugSetProcessKillOnExit( [MarshalAs(UnmanagedType.Bool)] bool KillOnExit );

        [DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DebugBreakProcess(IntPtr hProcess);

        [DllImport("kernel32.dll",SetLastError = true, PreserveSig = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WaitForDebugEvent(out DebugEvent pDebugEvent, int dwMilliseconds);

        [DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ContinueDebugEvent(uint dwProcessId, uint dwThreadId, ContinueStatus dwContinueStatus);

        [DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DebugActiveProcess(uint dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DebugActiveProcessStop(int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TerminateProcess(IntPtr hProcess, uint uExitCode);

        [DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlushInstructionCache(IntPtr hProcess, IntPtr lpBaseAddress, int dwSize);

        [DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, 
            int dwSize, MemoryProtection prot, out MemoryProtection oldProt);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true, PreserveSig = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CreateProcess(
            string lpApplicationName,
            string lpCommandLine,
            IntPtr lpProcessAttributes,
            IntPtr lpThreadAttributes,
            [MarshalAs(UnmanagedType.Bool)]
            bool bInheritHandles,
            CreateProcessFlags dwCreationFlags,
            IntPtr lpEnvironment,
            string lpCurrentDirectory,
            STARTUPINFO lpStartupInfo,
            PROCESS_INFORMATION lpProcessInformation
        );
    }
}
