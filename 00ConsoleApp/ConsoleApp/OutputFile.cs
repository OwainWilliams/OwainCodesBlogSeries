using System;
using System.IO;
using System.Text;

namespace ConsoleApp
{
    public class OutputFile
    {
        public OutputFile(string path, string text)
        {
            var fileDeleted = DeleteFile(path);
            bool fileCreated = false;

            if (fileDeleted)
                fileCreated = CreateFile(path, text);

            if (fileCreated)
                ReadFile(path);

        }

        public bool DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            return true;
        }

        public bool CreateFile(string path, string text)
        {
            using (FileStream fs = File.Create(path))
            {
                AddText(fs, text);
                AddText(fs, "This is some more text,");
                AddText(fs, "\r\nand this is on a new line");

                return true;
            }

            return false;
           
        }

        public void ReadFile(string path)
        {
            //Open the stream and read it back.
            using (FileStream fs = File.OpenRead(path))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    Console.WriteLine(temp.GetString(b));
                }
            }
        }
        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
           
}