namespace DirectoryPrinterAdvanced
{
    partial class FolderChooser
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.chooseDirectoryButton = new System.Windows.Forms.Button();
            this.filesCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "print.txt";
            this.saveFileDialog.Filter = "*.txt|*.*";
            // 
            // chooseDirectoryButton
            // 
            this.chooseDirectoryButton.AutoSize = true;
            this.chooseDirectoryButton.Location = new System.Drawing.Point(174, 227);
            this.chooseDirectoryButton.Name = "chooseDirectoryButton";
            this.chooseDirectoryButton.Size = new System.Drawing.Size(98, 23);
            this.chooseDirectoryButton.TabIndex = 0;
            this.chooseDirectoryButton.Text = "Choose Directory";
            this.chooseDirectoryButton.UseVisualStyleBackColor = true;
            this.chooseDirectoryButton.Click += new System.EventHandler(this.chooseDirectoryButton_Click);
            // 
            // filesCheckbox
            // 
            this.filesCheckbox.AutoSize = true;
            this.filesCheckbox.Checked = true;
            this.filesCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filesCheckbox.Location = new System.Drawing.Point(13, 13);
            this.filesCheckbox.Name = "filesCheckbox";
            this.filesCheckbox.Size = new System.Drawing.Size(67, 17);
            this.filesCheckbox.TabIndex = 1;
            this.filesCheckbox.Text = "print files";
            this.filesCheckbox.UseVisualStyleBackColor = true;
            // 
            // FolderChooser
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.filesCheckbox);
            this.Controls.Add(this.chooseDirectoryButton);
            this.Name = "FolderChooser";
            this.Text = "Directory Printer Advanced";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button chooseDirectoryButton;
        private System.Windows.Forms.CheckBox filesCheckbox;
    }
}

