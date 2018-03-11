using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Re_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("output");
            string[] files = Directory.GetFiles("input");

            foreach (var file in files)
            {
                string extension = file.Substring(file.LastIndexOf(".") + 1);

                if (!Directory.Exists(extension + "s"))
                {
                    Directory.CreateDirectory("output" + "/" + extension + "s");
                }

                string name = file.Substring(file.LastIndexOf("\\"));

                Directory.Move(file, "output" + "/" + extension + "s" + "/" + name);
            }
        }
    }
}
