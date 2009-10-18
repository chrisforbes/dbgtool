using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Ijw.Cricket.Ui
{
    public partial class NewTargetForm : Form
    {
        public string CommandLine { get { return commandBox.Text; } set { commandBox.Text = value; } }
        public string Arguments { get { return argsBox.Text; } set { argsBox.Text = value; } }
        public string WorkingDirectory { get { return dirBox.Text; } set { dirBox.Text = value; } }

        public NewTargetForm()
        {
            InitializeComponent();
        }

        void OnBrowseTarget(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog()
            {
                FileName = commandBox.Text,
                RestoreDirectory = true,
                Filter = "Programs (*.exe)|*.exe"
            })
            {
                if (DialogResult.OK == ofd.ShowDialog())
                    UpdateCommandLine(ofd.FileName);
            }
        }

        void UpdateCommandLine(string cmd)
        {
            CommandLine = cmd;
            if (string.IsNullOrEmpty(dirBox.Text))
                WorkingDirectory = Path.GetDirectoryName(CommandLine);
        }
    }
}
