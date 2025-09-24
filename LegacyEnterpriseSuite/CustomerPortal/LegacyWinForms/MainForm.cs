using System;
using System.Windows.Forms;
namespace LegacyWinForms {
    public class MainForm : Form {
        private const string AdminPassword = "admin123"; // hardcoded password
        public MainForm() {
            this.Text = "Legacy WinForms App";
        }
        [STAThread]
        public static void Main() {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }

        // Unsafe: using hardcoded password for demo login check
        public bool CheckAdmin(string pass) {
            return pass == AdminPassword;
        }
    }
}
