// Vinos blancos

namespace Vinos_blancos
{
    internal class Program
    {
        // This is the int of the max amount of vine sold in a year
        const int max = 175388;
        // This is used to shorten the amount of stars shown in the end for convinience sake
        const byte maxStar = 100;
        static void Main(string[] args)
        {

            // int[] arrayYear = { 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019 };

            // This is the array for the amount of vine sold
            int[] arrayVine = { 175134, 175388, 172818, 142709, 151437, 152620, 150979, 152210, 149450, 154398, 150160 };
            // This part sorts the array
            Array.Sort(arrayVine);
            Array.Reverse(arrayVine);

            // This loop prints out stars for all the vine sold
            for (int i = 0; i < arrayVine.Length; i++)
            {
                arrayVine[6] += 35432;// This part adds to the amount of vine sold in the year 2014
                int star = maxStar * arrayVine[i] / max;

                string starSting = new string('*', star);
                Console.WriteLine(starSting);
            }
            Console.ReadLine();
        }
    }
}
