class Program
{
    static void Main(string[] args)
    {
        // The number of sticks you start with
        int totalSticks = 7;
        // this part makes sure whos turn it is
        bool humanTurn = true;


        while (totalSticks > 1)
        {
            string currentPlayer = humanTurn ? "Mennesket" : "Computeren";
            // finds out how many sticks can be picked
            int maxSticks = Math.Min(3, totalSticks);
            // Show how many sticks are left
            Console.WriteLine($"Der er {totalSticks} tændstikker tilbage på bordet.");

            int chosenSticks = 0;
            if (humanTurn)
            {
                Console.Write($"{currentPlayer}, hvor mange tændstikker vil du tage? (1-{maxSticks}): ");
                while (!int.TryParse(Console.ReadLine(), out chosenSticks) || chosenSticks < 1 || chosenSticks > maxSticks)
                {
                    Console.Write($"Indtast et tal mellem 1 og {maxSticks}: ");
                }
            }
            else
            {
                // the Computer picks a random number of sticks (det rimer)
                chosenSticks = Math.Min(totalSticks, new Random().Next(1, 4));
                Console.WriteLine($"Computeren tog {chosenSticks} tændstikker.");
            }
            // updates the number of sticks on the board
            totalSticks -= chosenSticks;

            Console.WriteLine($"Der er nu {totalSticks} tændstikker tilbage på bordet.\n");
            // switches between human and computer
            humanTurn = !humanTurn; 
        }

        // desides the winner bassed on who took the last stick
        string winner = humanTurn ? "Computeren" : "Mennesket";
        Console.WriteLine($"Spillet er slut! {winner} har vundet!");
    }
}

