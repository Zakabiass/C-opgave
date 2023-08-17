using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main() 
        {
            bool passwordLetters = false;
            bool passwordNumbers = false;
            bool specialchar = false;
            bool exitValue = false;

            while (exitValue =! false)
            {
                Console.WriteLine("For at sikre dit password skal det indeholde de følgende punkter\n" +
                                    "• Password SKAL være minimum 12 tegn og max. 64\n" +
                                    "• Der SKAL være et mix af både UPPER og lowercase\n" +
                                    "• Der SKAL være et mix af tegn og tal\n" +
                                    "• Og der SKAL være minimum et specialtegn");
                Console.WriteLine("\nPasswords med som indeholder de følgende punkter virker men er ikke anbefalet\n" +
                                    "• 4 bogstaver eller tal af samme type kommer lige efter hinanden, som f.eks. BBBB eller 3333\n" +
                                    "• Hvis talrækken 1234 eller 3456 er fortløbende og på minumum 4 tegn som er sammenhængende");
                string myPassword = Console.ReadLine();

                // Here it checks if the password is between 12 and 64 characters long
                if (myPassword.Length > 11 && myPassword.Length < 65)
                {
                    // Here it checks if the password contains any lower and upper case letters
                    if (myPassword.Any(char.IsUpper) && myPassword.Any(char.IsLower))
                    {
                        // Here it checks if the password contains both letters and digits
                        for (int i = 0; i < myPassword.Length; i++)
                        {
                            
                            if (Char.IsLetterOrDigit(myPassword[i]))
                            {
                                passwordLetters = true;
                            }
                            if (Char.IsNumber(myPassword[i]))
                            {
                                passwordNumbers = true;
                                if (passwordLetters == true && passwordNumbers == true)
                                {
                                    // Here it checks if the password contains any special characters
                                    for (int j = 0; j < myPassword.Length; j++)
                                    {
                                        if (Char.IsLetterOrDigit(myPassword[i]))
                                        {
                                            specialchar = true;

                                            bool containSameCharacter = false;

                                            // Here it checks if the password has 4 consectutive characters in it. If it does it will result in a 'yellow ok' message
                                            char[] password4check = myPassword.ToCharArray();
                                            for (int l = 0; l < password4check.Length - 3; l++)
                                            {
                                                if (password4check[l] == password4check[l + 1] && password4check[l + 1] == password4check[l + 2] && password4check[l + 2] == password4check[l + 3])
                                                {
                                                    containSameCharacter = true;

                                                    // this either returns you to the start or closes the program
                                                    Yellowpassword();
                                                    string reset = Console.ReadLine();
                                                    if (reset.ToLower() != "y")
                                                    {
                                                        Console.Clear();
                                                        Main();
                                                    }
                                                    else if (reset.ToLower() != "n")
                                                    {
                                                        return;
                                                    }
                                                }
                                                else
                                                {
                                                    // Here it checks if you have consecutive numbers for example 1234 or 3456. If it does it will result in a 'yellow ok' message
                                                    for (int o = 0; o < myPassword.Length - 3; o++)
                                                    {
                                                        if (Convert.ToInt32(myPassword[o]) == Convert.ToInt32(myPassword[o + 1]) - 1 && Convert.ToInt32(myPassword[o + 1]) == Convert.ToInt32(myPassword[o + 2]) - 1 && Convert.ToInt32(myPassword[o + 2]) == Convert.ToInt32(myPassword[o + 3] - 1))
                                                        {
                                                            // this either returns you to the start or closes the program
                                                            Yellowpassword();
                                                            string reset = Console.ReadLine();
                                                            if (reset.ToLower() == "y")
                                                            {
                                                                Console.Clear();
                                                                Main();
                                                            }
                                                            else if (reset.ToLower() == "n")
                                                            {
                                                                Environment.Exit(0);
                                                            }
                                                        }
                                                    }
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Great! You have created a secure password");
                                                    Console.ResetColor();
                                                    Console.ReadLine();
                                                    Environment.Exit(0);
                                                }
                                            }
                                        //minimum 1 specialtegn
                                        }
                                        else
                                        {
                                            Redpassword();
                                            continue;
                                        }
                                    }
                                //mix af tegn og tal
                                }
                                else
                                {
                                    Redpassword();
                                    continue;
                                }
                            }                                                      
                        }
                    //upper lower case
                    }
                    else
                    {
                        Redpassword();
                        continue;
                    }
                //12 - 64
                }
                else
                {
                    Redpassword();
                    continue;
                }
            }
        }
        // This is used for showing the red error mesage
        static void Yellowpassword()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("We recommend you to create a new password");
            Console.WriteLine("Do you want to create a new password? (y / n)");
            Console.ResetColor();
        }
        // This is used for showing the yellow ok mesage
        static void Redpassword()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Create a new password");
            Console.ResetColor();
        }
    }   
}