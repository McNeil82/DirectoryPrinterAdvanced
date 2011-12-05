using System;
using System.IO;

namespace DirectoryPrinterAdvanced
{
    class Printer
    {
        private string basicFolder;
        private string destinationPath;
        private bool filesIncluded;
        private FileStream outPutFile;
        private StreamWriter streamWriter;

        public Printer(string basicFolder, string destinationPath, bool filesIncluded)
        {
            this.basicFolder = basicFolder;
            this.destinationPath = destinationPath;
            this.filesIncluded = filesIncluded;
        }

        public void print()
        {
            createFile();
            lookUpDirectories(basicFolder);
            if (filesIncluded)
            {
                lookUpFiles(basicFolder);
            }
            closeFile();
        }

        private void closeFile()
        {
            streamWriter.Close();
            outPutFile.Close();
        }

        private void createFile()
        {
            outPutFile = File.Create(destinationPath);
            streamWriter = new StreamWriter(outPutFile);
        }

        private void lookUpDirectories(string directoryPath)
        {
            string[] directories = Directory.GetDirectories(directoryPath);
            Array.Sort(directories);
            foreach (string path in directories)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                if (checkNotHiddenOrSystem(directoryInfo.Attributes))
                {
                    try
                    {
                        lookUpDirectories(path);
                        if (filesIncluded)
                        {
                            lookUpFiles(path);
                        }
                        else
                        {
                            streamWriter.WriteLine(path);
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        streamWriter.WriteLine("Can't access: " + path);
                    }
                    catch (PathTooLongException)
                    {
                        streamWriter.WriteLine("Path too long: " + path);
                    }
                }
            }
        }

        private void lookUpFiles(string folderPath)
        {
            string[] files = Directory.GetFiles(folderPath);
            Array.Sort(files);
            foreach (string filePath in files)
            {
                FileInfo fileInfo = new FileInfo(filePath);
                if (checkNotHiddenOrSystem(fileInfo.Attributes))
                {
                    streamWriter.WriteLine(fileInfo.FullName);
                }
            }
        }

        private Boolean checkNotHiddenOrSystem(FileAttributes attributes)
        {
            if ((attributes & (FileAttributes.Hidden | FileAttributes.System)) != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
