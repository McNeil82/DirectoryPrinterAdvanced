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
            getFolderToPrint();
            getDestinationFolder();
            printFolder();
            exitProgramSucessfully();
        }

        private void exitProgramSucessfully()
        {
            MessageBox.Show("Files printed.", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
            exit();
        }

        private void getDestinationFolder()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                destinationFolderPath = saveFileDialog.FileName;
            }
            else
            {
                exit();
            }
        }

        private void exit()
        {
            Environment.Exit(-1);
        }

        private void printFolder()
        {
            Printer printer = new Printer(selectedDirectoryPath, destinationFolderPath);
            printer.print();
        }

        private void getFolderToPrint()
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                selectedDirectoryPath = folderBrowserDialog.SelectedPath;
            }
            else
            {
                exit();
            }
        }
    }
}
