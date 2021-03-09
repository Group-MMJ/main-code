using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class dHondt : ReadFrom
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

            int numend = (numseat / 1) + mepnum;

            int x = 1;
            while (x <= roundnum)
            {
                for (int h = 1; h < roundnum; h++)
                {
                    numend = (numseat / 2) + mepnum;
                }
                Console.WriteLine($"Round : {x} \tFinal number : {numend}");
                x++;
            } 

            //saves the result into a new file

        }
    }
}

