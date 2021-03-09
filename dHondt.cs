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
            Console.WriteLine($"Number given: {numseat}");

            //divides the number by 2 and adds amount of MEP's there is
            //need to test this
            int numend = (numseat / 2) - mepnum;

            for (int i = 1; i < roundnum; i++)
            {

                if (i <= roundnum)
                {   
                    //int numend = (numseat / 2) - mepnum;
                    Console.WriteLine($"Round : {i} \tFinal number : {numend}");
                }

                if (i == roundnum)
                {
                    //Console.WriteLine($"Round : {i} \tFinal number : {numend}");
                    break;
                }

            }

            //saves the result into a new file

        }
    }
}

