using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace sNulla
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] eletter = new char[20, 20];
            Random vel = new Random(Guid.NewGuid().GetHashCode());
            int dbA = 0, dbB = 0;
            int mennyi = 0;

            // feltöltés
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {

                    if (vel.NextDouble() < 0.4)
                    {
                        eletter[i, j] = 'A';
                        dbA++;
                    }
                    else
                    {
                        eletter[i, j] = 'B';
                        dbB++;
                    }
                    //Console.Write(eletter[i, j] + " ");
                }
                //Console.WriteLine();
            }
            Console.WriteLine(dbA);
            Console.WriteLine(dbB);
            Console.WriteLine(dbA / (double)dbB);
            do
            {
                bool volt = false;
                if (vel.NextDouble() < 0.5)
                // A --> B
                {
                    int i, j = 0;
                    for (i = 0; i < 20; i++)
                    {
                        for (j = 0; j < 20; j++)
                        {
                            if (eletter[i, j] == 'A')
                            {
                                volt = true;
                                break;
                            }
                        }
                        if (volt)
                            break;
                    }
                    eletter[i, j] = 'B';
                    dbA--;
                    dbB++;
                }
                else
                // B --> A
                {
                    int i, j = 0;
                    for (i = 0; i < 20; i++)
                    {
                        for (j = 0; j < 20; j++)
                        {
                            if (eletter[i, j] == 'B')
                            {
                                volt = true;
                                break;
                            }
                        }
                        if (volt)
                            break;
                    }
                    eletter[i, j] = 'A';
                    dbA++;
                    dbB--;
                }
                //Console.Clear();
                //for (int i = 0; i < 20; i++)
                //{
                //    for (int j = 0; j < 20; j++)
                //    {

                //        Console.Write(eletter[i, j] + " ");
                //    }
                //    Console.WriteLine();
                //}
                Console.WriteLine(dbA);
                Console.WriteLine(dbB);
                //Console.WriteLine(dbA / (double)dbB);
                //Console.ReadKey();
                mennyi++;
            } while (mennyi < 10000);

            Console.ReadKey();
        }
    }
}
