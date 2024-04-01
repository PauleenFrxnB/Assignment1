using System;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "Admin";
            string password = "Admin1234!";
            int Attempts = 3;

            while (Attempts >= 1)
            {
                Console.Write("Username : ");
                string x = Console.ReadLine();

                Console.Write("Password : ");
                string y = Console.ReadLine();

                if (x == username && y == password)
                {
                    Console.WriteLine("Login was Successful");
                    break;
                }
                else
                {
                    Attempts--;
                    Console.WriteLine("Incorrect. Please try again.");
                    Console.WriteLine();

                    if (Attempts >= 1)
                    {
                        Console.WriteLine(Attempts + " more try");
                        Console.WriteLine();
                    }
                }
            }

            if (Attempts < 1)
            {
                Console.WriteLine("Maximum attempts reached");
            }
        }
    }
}

