using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int matchSum = int.Parse(Console.ReadLine());
            int iNum = 0;
            int jNum = 0;
            int kNum = 0;
            int counter = - 1;

            for (char i = 'A'; i <= 'T'; i++)
            {
                for (char j = 'A'; j <= 'T'; j++)
                {
                    for (char k = 'A'; k <= 'T'; k++)
                    {
                        if (i == 'A' || i == 'C' || i == 'G' || i == 'T')
                        {
                            if (j == 'A' || j == 'C' || j == 'G' || j == 'T')
                            {
                                if (k == 'A' || k == 'C' || k == 'G' || k == 'T')
                                {
                                    if (i == 'A')
                                    {
                                        iNum = 1;
                                    }
                                    else if (i == 'C')
                                    {
                                        iNum = 2;
                                    }
                                    else if (i == 'G')
                                    {
                                        iNum = 3;
                                    }
                                    else if (i == 'T')
                                    {
                                        iNum = 4;
                                    }

                                    if (j == 'A')
                                    {
                                        jNum = 1;
                                    }
                                    else if (j == 'C')
                                    {
                                        jNum = 2;
                                    }
                                    else if (j == 'G')
                                    {
                                        jNum = 3;
                                    }
                                    else if (j == 'T')
                                    {
                                        jNum = 4;
                                    }

                                    if (k == 'A')
                                    {
                                        kNum = 1;
                                    }
                                    else if (k == 'C')
                                    {
                                        kNum = 2;
                                    }
                                    else if (k == 'G')
                                    {
                                        kNum = 3;
                                    }
                                    else if (k == 'T')
                                    {
                                        kNum = 4;
                                    }
                                    counter++;
                                    if (counter % 4 == 0)
                                    {
                                        Console.WriteLine();
                                    }

                                    if (iNum + jNum + kNum >= matchSum)
                                    {
                                        Console.Write($"O{Convert.ToChar(i)}{Convert.ToChar(j)}{Convert.ToChar(k)}O ");
                                    }
                                    else
                                    {
                                        Console.Write($"X{Convert.ToChar(i)}{Convert.ToChar(j)}{Convert.ToChar(k)}X ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
