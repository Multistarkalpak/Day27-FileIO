using System;
using System.IO;
namespace FileIO

{
    class Program
    {
        public static void FileExist()
        {
            string InputFile = @"C:\Users\kalpak\Documents\Adobe";
            if (File.Exists(InputFile))
            {
                Console.WriteLine("File Exist");
            }
            else
            {
                Console.WriteLine("not Exist");
            }
        }
        public static void ReadFile()
        {
            string InputFile = @"C:\Users\kalpak\Documents\Adobe";
            using (StreamReader read = new StreamReader(InputFile))
            {
                string s = "";
                while ((s = read.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                read.Close();
            }

        }
        public static void CopyFile()
        {
            string path = @"C:\Users\kalpak\Documents\Adobe";
            string CopyPath = @"C:\Users\kalpak\Documents\Adobe";
            File.Copy(path, CopyPath);
        }
        public static void Main(string[] args)
        {


            FileExist();
            ReadFile();
            CopyFile();

        }
    }
}