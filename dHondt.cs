using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class dHondt : ReadFrom
    {
        private int _numseat;

        public int numseat
        {
            get { return _numseat; }
            set { _numseat = value; }
        }

        private int mepnum = 5;

        // ''roundnum'' is inherited from ReadFrom class and it's encapsulation is used here

        public void Victor()
        {
            ReadFrom object1 = new ReadFrom();
            object1.read_s();

            string[] partyNames = { "Brexit Party", "Liberal Democrats", "Labour", "Conservative", "Green", "UKIP", "Change UK", 
            "Independent Network","Independent" };

            Console.Write("\nGive number of votes for a party: ");
            numseat = Convert.ToInt32(Console.ReadLine());

            //divides the number by 2 and adds amount of MEP's there is

            Console.Write("\nHow many rounds would you like the calculation to go through? : ");
            roundnum = Convert.ToInt32(Console.ReadLine());

            int numend = (numseat / 1) + mepnum;
            Console.WriteLine($"Round : 1 \tVotes : {(numseat / 2) + mepnum}"); //First round is dividing by 2

            int x = 2;
            while (x <= roundnum)
            {
                
                /*for (int h = 1; h < roundnum; h++)
                {
                    numend = (numseat / 1) + mepnum;
                }*/
                Console.WriteLine($"Round : {x} \tVotes : {numend}");
                numend = (numseat / 1) + mepnum;
                x++;
            } 

            //saves the result into a new file

        }

    }
}

