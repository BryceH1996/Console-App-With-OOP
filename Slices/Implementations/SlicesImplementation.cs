using Slices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Slices.Implementations
{
    class SlicesImplementation : IPizzaSlices
    {
        public static string path = FileLocation();
        public static List<string> list = File.ReadAllLines(path).ToList();

        public static Customer cus = new Customer();
        public static Order ord = new Order();

        public string StartUp()
        {

            Console.WriteLine("Welcome to Slices\n*****************************\nPlease Enter Your Name: ");
            cus.Name = Console.ReadLine();


            Console.WriteLine("\nPlease Enter Your Surname: ");
            cus.Surname = Console.ReadLine();

            Console.WriteLine("\nPlease Enter Your Phone Number: ");
            cus.PhoneNumber = Console.ReadLine();
            Console.Clear();

            return ($"Name: {cus.Name},Surname: {cus.Surname},Phone Number: {cus.PhoneNumber},");
        }

        public string PizzaSelection()
        {


            Console.WriteLine("Please Select A Pizza Option:\n\n1. Margherita\n2. Hawaiian\n3. Meat Lovers");
            string Type = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please Select A Pizza Size:\n\n1. Small\n2. Medium\n3. Large");
            string Size = Console.ReadLine();
            Console.Clear();

            return ($"{ord.Price(Type, Size)}");

        }

        public string OrderNumber()
        {

            foreach (string value in list)
            {
                string[] Ordernum = value.Split(',');
                if (Convert.ToString("Order No: " + ord.OrderNum).StartsWith(Ordernum[0]))
                {
                    ord.OrderNum++;
                }
            }

            return ($"Order No: {ord.OrderNum},");
        }

        public void Save(StringBuilder builder)
        {
            StreamWriter Order = new StreamWriter(path, append: true);
            Order.WriteLine(builder);
            Order.Close();
        }

        public static string FileLocation()
        {
            const string SLICES = "\\SlicesOrder.txt";
            string path = Environment.CurrentDirectory;
            string newpath = path + SLICES;

            return newpath;
        }
    }
}
