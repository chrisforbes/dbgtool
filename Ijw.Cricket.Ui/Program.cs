using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ijw.Cricket.Ui
{
    static class Program
    {
        static Form1 mainForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainForm = new Form1());
        }

        public static void OutputMessage( string msg, params object[] args )
        {
            var text = string.Format(msg, args) + Environment.NewLine;
            if (mainForm.Created && mainForm.Visible)
                mainForm.Invoke( (Action) (() => mainForm.OutputMessage( text )) );
        }
    }
}
