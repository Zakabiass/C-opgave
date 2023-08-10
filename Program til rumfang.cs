// Rumfanget
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This part is for the diffrent values
            float L;
            float B;
            float H;
            float R;

            // This part is for the user to chose the length, width and hight of the box
            Console.Write("What is the length?: ");
            L = float.Parse(Console.ReadLine());
            Console.Write("What is the width?: ");
            B = float.Parse(Console.ReadLine());
            Console.Write("What is the hight?: ");
            H = float.Parse(Console.ReadLine());

            // And down here it calculates it and gives the resault
            R = L * B * H;
            Console.WriteLine($"\nThe volum of the box is {R}");
        }
    }
}