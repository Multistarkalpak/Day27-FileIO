using System;
using System.IO;
namespace FileIO

{
    class Program
    {
        public static void FileExist()
        {
            string InputFile = @"C:\Users\kalpak\Desktop\Project.txt";
            if (File.Exists(InputFile))
            {
                Console.WriteLine("File Exist");
            }
            else
            {
                Console.WriteLine("Not Exist");
            }
        }

        public static void Main(string[] args)
        {


            FileExist();

        }
    }
}