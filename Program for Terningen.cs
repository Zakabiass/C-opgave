namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int DiceSides;

                //Here it clears the console for text for when you return after the break command
                Console.Clear();
                //This makes the text green 
                Console.ForegroundColor = ConsoleColor.Green;
                //You decide the number of sides on the dice
                Console.Write("How many sides do you want your dice to have?: ");
                string Sides = Console.ReadLine();

                if (int.TryParse(Sides, out DiceSides))
                {
                    //Here it does the math and shows the reasaults
                    Random random = new Random();
                    int result = random.Next(1, DiceSides + 1);
                    Console.Write($"You rolled a {result}\nDo you want to throw again? (y/n): ");
                    string reset = Console.ReadLine();
                    //Here if you type y you will return to the start
                    if (reset.ToLower() != "y")
                    {
                        break;
                    }
                }
                else
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Invalid input for dice sides. Please enter a valid positive number.");
                }
            }


        }           
    }
}