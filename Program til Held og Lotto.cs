
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Held_og_Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This part dose all the random number genaration and stores the number in the array
            Random random = new Random();
            int[] lotryNumbers = new int[7];
            for (int i = 0; i < 7; i++)
            {
                //This part makes sure the number has not already been picked
                int newnumber = random.Next(1, 37);
                while (lotryNumbers.Contains(newnumber))
                {
                    newnumber = random.Next(1, 37);
                }
                lotryNumbers[i] = newnumber;
            }
            Array.Sort(lotryNumbers);

            //This part writes out the numbers from the arry, adds a space in between and waits 2 seconds between each number for dramatic effect
            for (int i = 0; i < lotryNumbers.Length; i++)
            {
                Console.Write(lotryNumbers[i] + " ");
                Thread.Sleep(2000);
            }
            
            //This part draws the joker number and writes it in red
            Console.ForegroundColor = ConsoleColor.Red;
            int jokerNumber = random.Next(1, 37);
            Console.Write(jokerNumber);

            Console.ReadLine();
        }
    }
}
