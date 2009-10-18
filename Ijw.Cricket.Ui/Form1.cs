using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Ijw.Cricket.NativeDebugApi;

namespace Ijw.Cricket.Ui
{
    public partial class Form1 : Form
    {
        Target target;

        public Form1()
        {
            InitializeComponent();
        }

        void OnNewTargetClicked(object sender, EventArgs e)
        {
            using (var ntb = new NewTargetForm())
                if (DialogResult.OK == ntb.ShowDialog())
                    NewTarget(ntb.CommandLine, ntb.Arguments, ntb.WorkingDirectory);
        }

        void NewTarget(string commandLine, string arguments, string workingDirectory)
        {
            target = new Target(commandLine, arguments, workingDirectory);
            collectDebugEventsTimer.Enabled = true;
        }

        public void OutputMessage(string text)
        {
            richTextBox1.AppendText(text);
        }

        void OnCollectTick(object sender, EventArgs e)
        {
            SyncUiToTarget();

            if (target == null) return;
            if (target.State == TargetState.Running)
                target.CollectEvents();
        }

        void SyncUiToTarget()
        {
            collectDebugEventsTimer.Enabled = target != null && target.State == TargetState.Running;
            newTargetButton.Enabled = target == null;
            continueButton.Enabled = target != null && target.State == TargetState.Paused;
            detachButton.Enabled = target != null && target.State == TargetState.Paused;
            stopButton.Enabled = target != null && target.State == TargetState.Paused;
        }

        void OnContinueClicked(object sender, EventArgs e)
        {
            target.Continue( target.GetDefaultContinue() );
            SyncUiToTarget();
        }

        void OnDetachClicked(object sender, EventArgs e)
        {
            target.Detach();
            target.Dispose();
            target = null;
            SyncUiToTarget();
        }

        void OnStopDebuggingClicked(object sender, EventArgs e)
        {
            target.Dispose();
            target = null;
            SyncUiToTarget();
        }
    }
}
