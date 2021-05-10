using System;

namespace Composição
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter with client data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Birth data (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter oder data");
            Console.Write("Status: ");
            
        }
    }
}