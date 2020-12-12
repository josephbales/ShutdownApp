using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ShutdownApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ProcessStartInfo psinfo = new ProcessStartInfo();
            psinfo.WindowStyle = ProcessWindowStyle.Hidden;
            psinfo.FileName = "shutdown.exe";
            psinfo.Arguments = "/s /t 60";

            Process process = new Process();
            process.StartInfo = psinfo;
            process.Start();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psinfo = new ProcessStartInfo();
            psinfo.WindowStyle = ProcessWindowStyle.Hidden;
            psinfo.FileName = "shutdown.exe";
            psinfo.Arguments = "/a";

            Process process = new Process();
            process.StartInfo = psinfo;
            process.Start();
            Environment.Exit(1);
        }
    }
}
