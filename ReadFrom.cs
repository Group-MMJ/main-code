using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class ReadFrom
    {
        public void read_s()
        {

            //Janek's path: @"D:\University of Lincoln\SEM B\Assessment1Data.txt";
            Console.WriteLine("Enter address path to the file");
            var fileName = @"" + Console.ReadLine();       

            string[] lines = System.IO.File.ReadAllLines(fileName);
            //12 lines total
            foreach (string line in lines)
            {
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
        }
    }
}
