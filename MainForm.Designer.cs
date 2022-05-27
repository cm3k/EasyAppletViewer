namespace EasyAppletViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RunButton = new System.Windows.Forms.Button();
            this.AppletViewerPathTextBox = new System.Windows.Forms.TextBox();
            this.AppletFileSelectorButton = new System.Windows.Forms.Button();
            this.AppletOpenFIleDialog = new System.Windows.Forms.OpenFileDialog();
            this.AppletLocationTextBox = new System.Windows.Forms.TextBox();
            this.AppletViewerOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FindAppletViewerExecutableFileButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(75, 71);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(277, 23);
            this.RunButton.TabIndex = 0;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // AppletViewerPathTextBox
            // 
            this.AppletViewerPathTextBox.Location = new System.Drawing.Point(7, 11);
            this.AppletViewerPathTextBox.Name = "AppletViewerPathTextBox";
            this.AppletViewerPathTextBox.PlaceholderText = "Applet Viewer Path";
            this.AppletViewerPathTextBox.Size = new System.Drawing.Size(259, 23);
            this.AppletViewerPathTextBox.TabIndex = 2;
            // 
            // AppletFileSelectorButton
            // 
            this.AppletFileSelectorButton.Location = new System.Drawing.Point(272, 42);
            this.AppletFileSelectorButton.Name = "AppletFileSelectorButton";
            this.AppletFileSelectorButton.Size = new System.Drawing.Size(80, 23);
            this.AppletFileSelectorButton.TabIndex = 4;
            this.AppletFileSelectorButton.Text = "Open File";
            this.AppletFileSelectorButton.UseVisualStyleBackColor = true;
            this.AppletFileSelectorButton.Click += new System.EventHandler(this.AppletFileSelectorButton_Click);
            // 
            // AppletOpenFIleDialog
            // 
            this.AppletOpenFIleDialog.FileName = "Applet Location";
            this.AppletOpenFIleDialog.Title = "Open Applet";
            // 
            // AppletLocationTextBox
            // 
            this.AppletLocationTextBox.Location = new System.Drawing.Point(7, 42);
            this.AppletLocationTextBox.Name = "AppletLocationTextBox";
            this.AppletLocationTextBox.PlaceholderText = "Applet Location";
            this.AppletLocationTextBox.Size = new System.Drawing.Size(259, 23);
            this.AppletLocationTextBox.TabIndex = 5;
            // 
            // AppletViewerOpenFileDialog
            // 
            this.AppletViewerOpenFileDialog.FileName = "Applet Viewer Path";
            this.AppletViewerOpenFileDialog.Title = "Open AppletViewer Executable";
            // 
            // FindAppletViewerExecutableFileButton
            // 
            this.FindAppletViewerExecutableFileButton.Location = new System.Drawing.Point(272, 12);
            this.FindAppletViewerExecutableFileButton.Name = "FindAppletViewerExecutableFileButton";
            this.FindAppletViewerExecutableFileButton.Size = new System.Drawing.Size(80, 23);
            this.FindAppletViewerExecutableFileButton.TabIndex = 6;
            this.FindAppletViewerExecutableFileButton.Text = "Open File";
            this.FindAppletViewerExecutableFileButton.UseVisualStyleBackColor = true;
            this.FindAppletViewerExecutableFileButton.Click += new System.EventHandler(this.FindAppletViewerExecutableFileButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(7, 71);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(62, 23);
            this.HelpButton.TabIndex = 7;
            this.HelpButton.Text = "About";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 96);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.FindAppletViewerExecutableFileButton);
            this.Controls.Add(this.AppletLocationTextBox);
            this.Controls.Add(this.AppletFileSelectorButton);
            this.Controls.Add(this.AppletViewerPathTextBox);
            this.Controls.Add(this.RunButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "EasyAppletViewer - www.CM3K.xyz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox AppletViewerPathTextBox;
        private System.Windows.Forms.Button AppletFileSelectorButton;
        private System.Windows.Forms.OpenFileDialog AppletOpenFIleDialog;
        private System.Windows.Forms.TextBox AppletLocationTextBox;
        private System.Windows.Forms.OpenFileDialog AppletViewerOpenFileDialog;
        private System.Windows.Forms.Button FindAppletViewerExecutableFileButton;
        private System.Windows.Forms.Button HelpButton;
    }
}