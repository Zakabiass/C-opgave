//jeg kan ikke finde ud af hvordan jeg skal lave hver anden stjerne til en rød stjerne desværre så jeg gjorde det næstbedste som jeg kunne

class Program
{
    static void Main(string[] args)
    {
        int treeHeight = 8;
        // This loop will continue until i reaches the dicided treeheight wich is 8
        for (int i = 0; i < treeHeight; i++)
        {
            // This part dicides the amount of spaces that are needed on the row.
            string spaces = new string(' ', treeHeight - i - 1);
            // This part dicides the amount of stars on the row
            if (i % 2 == 0)
            {
                string stars = new string('*', 2 * i + 1);
                Console.WriteLine(spaces + stars);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string redStars = new string('*', 2 * i + 1);
                Console.WriteLine(spaces + redStars);
                Console.ResetColor(); 
            }
        }
    }
}
