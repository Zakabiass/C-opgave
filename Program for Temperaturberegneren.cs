//Temperaturberegneren
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Here it asks for the temperature that you want converted from celsius.
            //After this it will show you the results
            Console.Write("Write the temperature that you want converted from celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            //This part calculates with the power of math
            double fahrenheit = (celsius * 1.8) + 32;
            double reamur = celsius * 0.8;

            //this part will show you the results of the convertion
            Console.WriteLine($"\n{celsius} Celsius is equal to:");
            Console.WriteLine($"{fahrenheit} Fahrenheit");
            Console.WriteLine($"{reamur} Reamur");

            Console.ReadKey();
        }
    }
}




