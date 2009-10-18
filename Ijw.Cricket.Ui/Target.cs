using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ijw.Cricket.NativeDebugApi;

namespace Ijw.Cricket.Ui
{
    public class Target : IDisposable
    {
        PROCESS_INFORMATION pi = new PROCESS_INFORMATION();
        DebugEvent lastEvent;

        public TargetState State { get; private set; }

        public Target(string commandLine, string arguments, string workingDirectory)
        {
            State = TargetState.Starting;
            Program.OutputMessage("Starting target...");
            
            if (!Kernel32.CreateProcess(commandLine, arguments, IntPtr.Zero, IntPtr.Zero, false,
                CreateProcessFlags.DebugOnlyThisProcess, IntPtr.Zero, workingDirectory, new STARTUPINFO(), pi))
                throw new InvalidOperationException("The target process could not be started");

            State = TargetState.Running;
            Program.OutputMessage("Successfully connected to target.");
        }

        bool disposed;

        public void Dispose()
        {
            if (disposed) return;
            disposed = true;

            if (pi != null)
            {
                Kernel32.TerminateProcess(pi.hProcess, 1);
                Program.OutputMessage("Target terminated.");
                pi = null;
            }
            GC.SuppressFinalize(this);
        }

        ~Target() { Dispose(); }

        public void Detach()
        {
            if (pi == null) 
                throw new InvalidOperationException("There is no process to detach from");

            Kernel32.DebugSetProcessKillOnExit(false);
            Kernel32.DebugActiveProcessStop(pi.dwProcessId);
            State = TargetState.Detached;

            pi = null;

            Program.OutputMessage("Detached.");
        }

        public void Continue(ContinueStatus status)
        {
            if (State != TargetState.Paused)
                throw new InvalidOperationException("Continue requires a Paused target");

            if (!Kernel32.ContinueDebugEvent(lastEvent.ProcessId, lastEvent.ThreadId, status))
                throw new InvalidOperationException("ContinueDebugEvent failed");

            State = (lastEvent.EventCode == DebugEventCode.RipEvent | lastEvent.EventCode == DebugEventCode.ExitProcess) 
                ? TargetState.Exited    /* todo: handle this properly */
                : TargetState.Running;
        }

        public void CollectEvents()
        {
            if (State != TargetState.Running)
                throw new InvalidOperationException("CollectEvents requires a Running target");

            while (Kernel32.WaitForDebugEvent(out lastEvent, 0))
                DispatchEvent(lastEvent);
        }

        void DispatchEvent(DebugEvent e)
        {
            Program.OutputMessage("DispatchEvent code={0} pid=0x{1:X8} tid=0x{2:X8}", e.EventCode, e.ProcessId, e.ThreadId);
            State = TargetState.Paused;

            /* todo: do something with some of these events! */
        }

        public ContinueStatus GetDefaultContinue()
        {
            /* gets an appropriate continuation action for the last event */
            if (lastEvent.EventCode != DebugEventCode.Exception)
                return ContinueStatus.Continue;

            if (lastEvent.Exception.dwFirstChance != 0
                && lastEvent.Exception.ExceptionRecord.ExceptionCode == ExceptionCode.STATUS_BREAKPOINT)
                return ContinueStatus.Continue;

            return ContinueStatus.ExceptionNotHandled;  /* send the exception to the usual handler! */
        }
    }

    public enum TargetState
    {
        Starting,
        Running,
        Paused,
        Exited,
        Detached,
    }
}
