using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Project0
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }

    public class Utilizations
    {
        public static void ResetControls(TabControl tabControl)
        {
            foreach (TabPage tp in tabControl.TabPages)
            {
                foreach (Control control in tp.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        textBox.Text = null;
                    }

                    if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        comboBox.SelectedIndex = 0;
                    }
                }
                tabControl.SelectedIndex = 0;
            }
        }
    }
}
