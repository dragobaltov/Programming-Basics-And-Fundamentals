using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            phonebook["Gosho"] = "2222222";
            phonebook["Pesho"] = "111";
            string value = "1";

            phonebook.TryGetValue("Pesho", out value);
            Console.WriteLine(phonebook["Pesho"]);
        }
    }
}
