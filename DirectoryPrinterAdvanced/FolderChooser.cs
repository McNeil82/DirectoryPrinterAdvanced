using System;
using System.Windows.Forms;

namespace DirectoryPrinterAdvanced
{
    public partial class FolderChooser : Form
    {
        private string selectedDirectoryPath;
        private string destinationFolderPath;

        public FolderChooser()
        {
            InitializeComponent();
        }

        private void getDestinationFolder()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                destinationFolderPath = saveFileDialog.FileName;
            }
            else
            {
                destinationFolderPath = null;
            }
        }

        private void printFolder()
        {
            Printer printer = new Printer(selectedDirectoryPath, destinationFolderPath, filesCheckbox.Checked);
            printer.print();
            MessageBox.Show("Files printed.", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void getFolderToPrint()
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                selectedDirectoryPath = folderBrowserDialog.SelectedPath;
            }
            else
            {
                selectedDirectoryPath = null;
            }
        }

        private void chooseDirectoryButton_Click(object sender, EventArgs e)
        {
            getFolderToPrint();
            if (selectedDirectoryPath != null)
            {
                getDestinationFolder();
                if (destinationFolderPath != null)
                {
                    printFolder();
                }
            }
        }
    }
}
