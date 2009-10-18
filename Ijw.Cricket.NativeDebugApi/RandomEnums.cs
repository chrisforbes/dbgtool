using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ijw.Cricket.NativeDebugApi
{
    public enum ThreadAccess : uint
    {
        None = 0,
        THREAD_ALL_ACCESS = 0x1f03ff,
        THREAD_DIRECT_IMPERSONATION = 0x0200,
        THREAD_GET_CONTEXT = 0x0008,
        THREAD_IMPERSONATE = 0x0100,
        THREAD_QUERY_INFORMATION = 0x0040,
        THREAD_QUERY_LIMITED_INFORMATION = 0x0800,
        THREAD_SET_CONTEXT = 0x0010,
        THREAD_SET_INFORMATION = 0x0020,
        THREAD_SET_LIMITED_INFORMATION = 0x0400,
        THREAD_SET_THREAD_TOKEN = 0x0080,
        THREAD_SUSPEND_RESUME = 0x0002,
        THREAD_TERMINATE = 0x0001,
    }

    public enum ContinueStatus : uint
    {
        None = 0,                               // not set [we detect this!]
        Continue = 0x10002,                     // eat the exception / normal continue
        ExceptionNotHandled = 0x80010001,       // pass exception to the debuggee
    }

    public enum MemoryProtection : uint
    {
        None = 0,
        Execute = 0x10,
        ExecuteRead = 0x20,
        ExecuteReadWrite = 0x40,
        ExecuteWriteCopy = 0x80,
        NoAccess = 0x01,
        ReadOnly = 0x02,
        ReadWrite = 0x04,
        WriteCopy = 0x08,

        Guard = 0x100,
        NoCache = 0x200,
        WriteCombine = 0x400,
    }

    [Flags]
    public enum CreateProcessFlags : uint
    {
        CreateNewConsole = 0x00000010,
        DebugProcessTree = 1,   // This will include child processes.
        DebugOnlyThisProcess = 2,   // This will be just the target process.
    }
}
