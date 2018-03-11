using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string testFolder = "TestFolder";
            Directory.CreateDirectory(testFolder);
            string[] files = Directory.GetFiles(testFolder);

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                double sizeInMB = (info.Length / 1024.0) / 1024.0;
                Console.WriteLine(sizeInMB);
            }
        }
    }
}
