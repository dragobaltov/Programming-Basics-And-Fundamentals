using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Dwarf> dwarfs = new List<Dwarf>();

            while (!input.Equals("Once upon a time"))
            {
                string[] tokens = input.Split(new string[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string hatColour = tokens[1];
                int physics = int.Parse(tokens[2]);

                if (dwarfs.Select(d => d.Name).Contains(name))
                {
                    bool isTheSameColour = false;

                    foreach (var dwarf in dwarfs.Where(d => d.Name == name))
                    {
                        if (dwarf.HatColour == hatColour)
                        {
                            isTheSameColour = true;
                        }
                    }

                    if (!isTheSameColour)
                    {
                        dwarfs.Add(new Dwarf(name, hatColour, physics));
                    }
                    else
                    {
                        foreach (var dwarf in dwarfs.Where(d => d.Name == name && d.HatColour == hatColour))
                        {
                            if (physics > dwarf.Physics)
                                dwarf.Physics = physics;
                        }
                    }
                }
                else
                {
                    dwarfs.Add(new Dwarf(name, hatColour, physics));
                }

                input = Console.ReadLine();
            }

            foreach (var dwarf in dwarfs.OrderByDescending(d => d.Physics)
                .ThenByDescending(d => CountDwarfsWithTheSameHatColour(dwarfs, d.HatColour)))
            {
                Console.WriteLine($"({dwarf.HatColour}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }

        static int CountDwarfsWithTheSameHatColour(List<Dwarf> dwarfs, string colour)
        {
            return dwarfs.Where(d => d.HatColour == colour).ToList().Count;
        }
    }

    class Dwarf
    {
        public string Name { get; set; }
        public string HatColour { get; set; }
        public int Physics { get; set; }

        public Dwarf(string name, string hatColour, int physics)
        {
            this.Name = name;
            this.HatColour = hatColour;
            this.Physics = physics;
        }
    }
}
