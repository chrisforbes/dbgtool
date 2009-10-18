using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Ijw.Cricket.NativeDebugApi
{
    [StructLayout(LayoutKind.Explicit)]
    public struct DebugEvent
    {
        [FieldOffset(0)]
        public DebugEventCode EventCode;
        [FieldOffset(4)]
        public uint ProcessId;
        [FieldOffset(8)]
        public uint ThreadId;

        [FieldOffset(12)]
        public EXCEPTION_DEBUG_INFO Exception;
        [FieldOffset(12)]
        public CREATE_THREAD_DEBUG_INFO CreateThread;
        [FieldOffset(12)]
        public CREATE_PROCESS_DEBUG_INFO CreateProcess;
        [FieldOffset(12)]
        public EXIT_THREAD_DEBUG_INFO ExitThread;
        [FieldOffset(12)]
        public EXIT_PROCESS_DEBUG_INFO ExitProcess;
        [FieldOffset(12)]
        public LOAD_DLL_DEBUG_INFO LoadDll;
        [FieldOffset(12)]
        public UNLOAD_DLL_DEBUG_INFO UnloadDll;
        [FieldOffset(12)]
        public OUTPUT_DEBUG_STRING_INFO OutputDebugString;
    }

    public enum DebugEventCode : uint
    {
        None = 0,
        Exception = 1,
        CreateThread = 2,
        CreateProcess = 3,
        ExitThread = 4,
        ExitProcess = 5,
        LoadDll = 6,
        UnloadDll = 7,
        OutputDebugString = 8,
        RipEvent = 9,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EXCEPTION_DEBUG_INFO
    {
        public EXCEPTION_RECORD ExceptionRecord;
        public uint dwFirstChance;
    }

    public enum ExceptionCode : uint       /* note: bit 28 is reserved and the OS does tricky things with it. */
    {
        None = 0,
        STATUS_BREAKPOINT = 0x80000003,
        STATUS_SINGLESTEP = 0x80000004,

        EXCEPTION_INT_DIVIDE_BY_ZERO = 0xc0000094,
        EXCEPTION_STACK_OVERFLOW = 0xc0000025,
        EXCEPTION_ACCESS_VIOLATION = 0xc0000005,
    }

    [Flags]
    public enum ExceptionFlags : uint
    {
        None = 0,
        EXCEPTION_NONCONTINUABLE = 0x1,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EXCEPTION_RECORD
    {
        public ExceptionCode ExceptionCode;
        public ExceptionFlags ExceptionFlags;
        public IntPtr ExceptionRecord;
        public IntPtr ExceptionAddress;
        public IntPtr NumberParameters;

        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxParameters)]  /* i wish */
        public unsafe fixed uint ExceptionInformation[MaxParameters];

        public const int MaxParameters = 15;

        public bool IsNotContinuable
        {
            get { return (ExceptionFlags & ExceptionFlags.EXCEPTION_NONCONTINUABLE) != 0; }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CREATE_PROCESS_DEBUG_INFO
    {
        public IntPtr hFile;
        public IntPtr hProcess;
        public IntPtr hThread;
        public IntPtr lpBaseOfImage;
        public uint dwDebugInfoFileOffset;
        public uint nDebugInfoSize;
        public IntPtr lpThreadLocalBase;
        public IntPtr lpStartAddress;
        public IntPtr lpImageName;
        public ushort fUnicode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CREATE_THREAD_DEBUG_INFO
    {
        public IntPtr hThread;
        public IntPtr lpThreadLocalBase;
        public IntPtr lpStartAddress;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EXIT_THREAD_DEBUG_INFO
    {
        public uint dwExitCode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EXIT_PROCESS_DEBUG_INFO
    {
        public uint dwExitCode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LOAD_DLL_DEBUG_INFO
    {
        public IntPtr hFile;
        public IntPtr lpBaseOfDll;
        public uint dwDebugInfoFileOffset;
        public uint nDebugInfoSize;
        public IntPtr lpImageName;
        public ushort fUnicode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UNLOAD_DLL_DEBUG_INFO
    {
        public IntPtr lpBaseOfDll;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OUTPUT_DEBUG_STRING_INFO
    {
        public IntPtr lpDebugStringData;
        public ushort fUnicode;
        public ushort nDebugStringLength;
    }
}
