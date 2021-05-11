using System;
using Composição.Entities.Enums;
using Composição.Entities;
using System.Globalization;
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
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order ?");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string nomeP = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(nomeP, price);



                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());


                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);

            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY");
            Console.WriteLine(order);
        }
    }
}