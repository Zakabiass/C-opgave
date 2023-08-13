// Body mass index

class Program
{
    // here you input your weight and height with is used to calculate your BMI value with is used to diside with BMI category you are in
    static void Main(string[] args)
    {
        Console.Write("Indtast din vægt (kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Indtast din højde (m): ");
        double height = Convert.ToDouble(Console.ReadLine());

        double bmi = CalculateBMI(weight, height);

        Console.WriteLine($"Din BMI er: {bmi:F2}");

        string bmiCategory = GetBMICategory(bmi);

        Console.WriteLine($"Du tilhører kategorien: {bmiCategory}");
    }

    static double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }

    // This part uses the BMI value to determine which category the input falls into
    static string GetBMICategory(double bmi)
    {
        if (bmi < 18.5)
        {
            return "Body weight deficit";
        }
        else if (bmi < 24)
        {
            return "Norm";
        }
        else if (bmi < 30)
        {
            return "Weight over";
        }
        else if (bmi < 35)
        {
            return "Obesity first degree";
        }
        else if (bmi < 40)
        {
            return "Obesity second degree";
        }
        else
        {
            return "Obestity third degree";
        }
    }
}