namespace Fødselsdagen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here you write your birthday
            Console.WriteLine("Indtast fødselsdag i formatet ddMMyyyy:");
            string readin = Console.ReadLine();

            DateTime birthday = DateTime.ParseExact(readin,"ddMMyyyy", null);

            //Here it does all the calculations to find your age
            DateTime now = DateTime.Now;
            TimeSpan difference = now - birthday;
            int years = (int)Math.Floor(difference.TotalDays) / 365;
            birthday = birthday.AddYears(years);
            difference = now - birthday;
            int days = (int)Math.Floor(difference.TotalDays);
           
            //Here it tells you how old you are
            Console.WriteLine($"Du er {years} år og {days} dage gammel");
        }
    }
}