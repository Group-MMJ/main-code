using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class ReadFrom
    {
        public void read_s()
        {
            //Janek's path: @"D:\University of Lincoln\SEM B\Assessment1Data.txt";
            //Max's path:
            //Matt's path:

            Console.WriteLine("Enter address path to the file");
            var fileName = @"" + Console.ReadLine();       

            string[] lines = System.IO.File.ReadAllLines(fileName);
            //12 lines total
            foreach (string line in lines)
            {
                Console.WriteLine("\n");
                Console.WriteLine("\t" + line);
            }
            Console.WriteLine("\n");

            Console.Write("Specify the name of the party : ");
            string partyName = Console.ReadLine();

            foreach (var line in File.ReadLines(fileName))
            {
                if (line.Contains(partyName))
                {
                    Console.WriteLine("test: {0}", line);
                    break;
                }
            }

            using (StreamReader read = new StreamReader(fileName))
            {
                List<int> numbers = new List<int>();
                  
                while (true)
                {
                    string max = read.ReadLine();
                    if (max == null)
                    {
                        break;
                    }

                    int test;

                    if (Int32.TryParse(max, out test))
                    {
                        numbers.Add(test);
                    }
                }
                
                Console.WriteLine("\nThe highest number of votes is {0}", numbers.Max());
            }
        }

    }
}
