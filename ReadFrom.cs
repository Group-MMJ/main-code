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
            string[] lines = System.IO.File.ReadAllLines(@"D:\University of Lincoln\SEM B\Assessment1Data.txt");
            //12 lines total
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            Console.WriteLine("\n");

            //prints entire line if it finds a keyword
            var fileName = @"D:\University of Lincoln\SEM B\Assessment1Data.txt";
            foreach (var line in File.ReadLines(fileName))
            {
                if (line.Contains("Labour"))
                {
                    Console.WriteLine("test: {0}", line);
                    break;
                }
            }
        }
    }
}
