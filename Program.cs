namespace ConsoleApp1
    // This code is supost to create a replica of the amarican flag 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Writes all the white and red lines
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                                      \n" + "                                      ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("                                      \n" + "                                      ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                                      \n" + "                                      ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("                                      \n" + "                                      ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                                      \n" + "                                      ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("                                      \n" + "                                      ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                                      \n" + "                                      ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("                                      \n" + "                                      ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                                      \n" + "                                      ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("                                      \n" + "                                      ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                                      \n" + "                                      ");
            {
                //Writes the blue and adds the stars
                Console.SetCursorPosition(0,0);
                Console.BackgroundColor= ConsoleColor.DarkBlue;
                Console.WriteLine("                       \n" + " *   *   *   *   *   * ");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("   *   *   *   *   *   \n" + " *   *   *   *   *   * ");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("   *   *   *   *   *   \n" + " *   *   *   *   *   * ");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("   *   *   *   *   *   \n" + " *   *   *   *   *   * ");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("   *   *   *   *   *   \n" + " *   *   *   *   *   * ");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("                       ");
                {
                    //This part removes the big cloud of text at the bottom of the console
                    Console.ReadKey();
                }
            }
        }
    }
}