using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<string> strengthAndDirection = Console.ReadLine().Split(' ').ToList();
            bool someoneIsDead = false;


            int indexOfBullet = 0;
            for (int i = 0; i < cylinder.Length; i++)
            {
                if (cylinder[i] == 1)
                {
                    indexOfBullet = i;
                    break;
                }
            }

            for (int i = 0; i < strengthAndDirection.Count; i++)
            {
                string[] array = strengthAndDirection[i].Split(',').ToArray();
                int strength = int.Parse(array[0]);
                string direction = array[1];

                if (direction == "Right")
                {
                    indexOfBullet = (indexOfBullet + strength) % cylinder.Length;
                }
                else
                {
                    if (indexOfBullet - strength < 0)
                    {
                        indexOfBullet = cylinder.Length - (Math.Abs(indexOfBullet - strength) % cylinder.Length);
                    }
                    else
                    {
                        indexOfBullet -= strength;
                    }
                }

                if (indexOfBullet == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    someoneIsDead = true;
                    break;
                }

                indexOfBullet = indexOfBullet + 1 == cylinder.Length ? 0 : indexOfBullet + 1;
            }

            if(!someoneIsDead)
                Console.WriteLine("Everybody got lucky!");
        }
    }
}
