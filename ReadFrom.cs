using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class ReadFrom
    {
        public int roundnum;

        public void read_s()
        {
            //Janek's path: @"D:\University of Lincoln\SEM B\Assessment1Data.txt";
            //Max's path:
            //Matt's path:

            //reads the contents of a file
            Console.WriteLine("Enter address path to the file");
            var fileName = @"" + Console.ReadLine();       

            string[] lines = System.IO.File.ReadAllLines(fileName);
            //12 lines total
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            Console.WriteLine("\n");

            //writes a line based on the user inputs of the name of the party
            Console.Write("Specify the name of the party : ");
            string partyName = Console.ReadLine();

            foreach (var line in File.ReadLines(fileName))
            {
                if (line.Contains(partyName))
                {
                    Console.WriteLine("Party: {0}", line);
                    break;
                }
            }

            Console.Write("\nHow many rounds would you like the calculation to go through? : ");
            roundnum = Convert.ToInt32(Console.ReadLine());
        }

    }
}
