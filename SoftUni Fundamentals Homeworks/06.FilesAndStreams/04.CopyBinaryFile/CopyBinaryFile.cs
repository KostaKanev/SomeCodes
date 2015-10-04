using System;
using System.IO;
using System.Diagnostics;
public class CopyBinaryFile
{
    public static void Main()
    {
        FileStream file = new FileStream(@"..\..\Radioactive.mp3", FileMode.Open);
        FileStream fileCopy = new FileStream(@"..\..\copyOf_Radioactive.mp3", FileMode.Create);
        
        using (file)
        {
            using (fileCopy)
            {
                //Copy all bytes of mp3 file and copy them to another mp3 file
                byte[] buffer = new byte[4096];
                Console.WriteLine("Coping the file... please wait");
                while (true)
                {
                    int readBytes = file.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }
                    fileCopy.Write(buffer, 0, buffer.Length);
                }
                Console.Clear();
                Console.WriteLine("The file has been copied.");
            }
        }
    }
}