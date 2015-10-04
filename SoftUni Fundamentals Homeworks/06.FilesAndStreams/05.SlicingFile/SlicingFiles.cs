using System;
using System.Collections.Generic;
using System.IO;

public class SlicingFiles
{
    public static void Main()
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        Console.WriteLine("Enter full file path to slice!");
        string inputFile = Console.ReadLine();
        string fileName = Path.GetFileNameWithoutExtension(inputFile);
        string fileExtension = Path.GetExtension(inputFile);
        string assembledOutput = string.Format(@"{0}\Slice And Assemble File\{1}_assembled\",
            desktopPath, fileName);

        Console.Write("Please enter number of parts to slice: ");
        int parts = int.Parse(Console.ReadLine());

        Console.WriteLine("Slicing... please wait");
        var filesList = SliceAndReturnFilesList(inputFile, desktopPath, parts);
        Console.WriteLine("Assembling parts... please wait");
        Assemble(filesList, assembledOutput);
        Console.WriteLine("{0}DONE{0}", new string('-', 14));
    }

    public static List<string> SliceAndReturnFilesList(string inputFile, string outputDirectory, int parts)
    {
        var fileName = Path.GetFileNameWithoutExtension(inputFile);
        var fileExtension = Path.GetExtension(inputFile);
        var listOfFiles = new List<string>();
        byte[] buffer = new byte[4096];
        using (var reader = new FileStream(inputFile, FileMode.Open))
        {
            long eachPartSize = (int)Math.Ceiling((double)reader.Length / parts);
            for (int partNumber = 0; partNumber < parts; partNumber++)
            {
                string currentDir = string.Format(@"{0}\Slice And Assemble File\{1}_parts\", outputDirectory, fileName);
                string currentFile = string.Format("{0}_part_{1}{2}", fileName, partNumber, fileExtension);
                string fullPath = string.Format("{0}{1}", currentDir, currentFile);
                Directory.CreateDirectory(currentDir);

                using (var writer = new FileStream(fullPath, FileMode.Create))
                {
                    long currentSize = 0;
                    while (currentSize < eachPartSize)
                    {
                        int readBytes = reader.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        writer.Write(buffer, 0, readBytes);
                        currentSize += readBytes;
                    }
                }
                listOfFiles.Add(fullPath);
            }
        }
        return listOfFiles;
    }

    public static void Assemble(List<string> files, string outputDir)
    {
        string fileExt = Path.GetExtension(files[0]);
        Directory.CreateDirectory(outputDir);
        string outputFile = string.Format(@"{0}\assembled_file{1}", outputDir, fileExt);
        using (var writer = new FileStream(outputFile, FileMode.Create))
        {
            for (int i = 0; i < files.Count; i++)
            {
                using (var reader = new FileStream(files[i], FileMode.Open))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = reader.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        writer.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}