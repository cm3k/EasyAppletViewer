using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EasyAppletViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AppletFileSelectorButton_Click(object sender, EventArgs e)
        {
            AppletOpenFIleDialog.ShowDialog(this);
            AppletLocationTextBox.Text = AppletOpenFIleDialog.FileName;
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                string strCmdText = "/C " + AppletViewerPathTextBox.Text + " " + AppletLocationTextBox.Text;
                System.Diagnostics.Process.Start("CMD.exe", strCmdText);





            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                string strCmdText = AppletViewerPathTextBox.Text + " " + AppletLocationTextBox.Text;
                System.Diagnostics.Process.Start("bin/bash", strCmdText);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                MessageBox.Show("AppletViewer doesn't support MacOS X");
                throw new NotSupportedException("AppletViewer doesn't support MacOS X");
            }
        }

        private void FindAppletViewerExecutableFileButton_Click(object sender, EventArgs e)
        {
            AppletViewerOpenFileDialog.ShowDialog(this);
            AppletViewerPathTextBox.Text = Properties.Resources.DoubleQuotes + AppletViewerOpenFileDialog.FileName + Properties.Resources.DoubleQuotes;
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            var af = new AboutForm();
            af.Show();
        }
    }
}
