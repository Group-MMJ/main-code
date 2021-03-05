using System;
using System.IO;

namespace ConsoleApp1
{
    //zie plan
    /*D'Hondt method
        //first round - party with the most votes wins a seat
        //winning party's vote is divided by 2
        //whichever party comes out on top 
        //re-ordered results
        //it's looped
        //original vote of the winning party in each round
        //divide by 1 and + total of running MEPs
        //while loop -> until all the seats for the region have been taken*/

    class Program
    {
        static void Main(string[] args)
        {
            ReadFrom object1 = new ReadFrom();
            object1.read_s();

            Console.ReadKey();
        }


    }
}
