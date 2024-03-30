using System;
using System.IO;


namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"D:\Temp";
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                Console.WriteLine($"{file} : {fileInfo.LastAccessTime}");

                if (fileInfo.LastAccessTime < currentTime.AddMinutes(-5))
                {
                    Console.WriteLine($"Deleting file {file}");
                    File.Delete(file);
                }

            }
        }
    }
}
