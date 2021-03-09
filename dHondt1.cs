using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class dHondt1 : ReadFrom
    {
        private int numseat;

        private int mepnum = 5;

        // ''roundnum'' is inherited from ReadFrom class and it's encapsulation is used here

        public void Victor()
        {
            ReadFrom object1 = new ReadFrom();
            object1.read_s();

            Console.Write("\nGive number of votes for a party: ");
            numseat = Convert.ToInt32(Console.ReadLine());

            //divides the number by 2 and adds amount of MEP's there is

            Console.Write("\nHow many rounds would you like the calculation to go through? : ");
            roundnum = Convert.ToInt32(Console.ReadLine());

            int numend = (numseat / 2) - mepnum;

            //Victor dHondt calculation
            int x = 1;
            do
            {
                numend = (numseat / 2) - mepnum;
                Console.WriteLine($"Round : {x} \tVotes after : {numend}");
                x++;
            } while (x <= roundnum);

            //saves the result into a new file
            Console.WriteLine("What will be your name of the file? : ");
            string nameNew = Console.ReadLine();
            string pathNew = @"C:\Users\janek\Desktop\" + nameNew + ".txt";

            if (!File.Exists(pathNew))
            {
                using (StreamWriter sw = File.CreateText(pathNew))
                {
                    sw.WriteLine(numend);
                }

                using (StreamReader sr = File.OpenText(pathNew))
                {
                    string a = "";
                    while ((a = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(a);
                    }
                }
            }

        }
    }
}

