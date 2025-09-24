using System;
using System.Windows.Forms;
namespace LegacyWinForms {
    public class MainForm : Form {
        public MainForm() {
            this.Text = "Legacy WinForms App";
        }
        [STAThread]
        public static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}
