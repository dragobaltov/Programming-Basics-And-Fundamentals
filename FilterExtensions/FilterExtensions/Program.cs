using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilterExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string extension = Console.ReadLine();

            List<string> files = Directory.GetFiles("input").Where(f => f.Contains(extension)).ToList();

            for (int i = 0; i < files.Count; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                Console.WriteLine(info.Name);
            }
        }
    }
}
