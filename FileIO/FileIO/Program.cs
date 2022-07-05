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
        public static void DeleteFile()
        {
            string Path = @"C:\Users\kalpak\Documents\Adobe";
            File.Delete(Path);
            Console.WriteLine("File deleted sucessfully");
        }
        public static void ReadAllText()
        {
            String path = @"C:\Users\kalpak\Documents\Adobe";
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            Console.ReadKey();
        }
        public static void WriteUsingStreamWriter()
        {
            string path = @"C:\Users\kalpak\Documents\Adobe";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hello world.net class");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }

        public static void ReadStreamReader()
        {
            String path = @"G:\visualstudio\FileIOTextFile\FileIO.txt";
            using (StreamReader read = File.OpenText(path))
            {
                String s = "";
                while ((s = read.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();//it will wait for a key press
        }
        public static void Main(string[] args)
        {


            FileExist();
            ReadFile();
            CopyFile();
            DeleteFile();
            ReadAllText();
            WriteUsingStreamWriter();
            ReadStreamReader();



        }
    }
}