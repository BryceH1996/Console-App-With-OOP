using System;
using System.Text;
using Slices.Interfaces;
using Slices.Implementations;

namespace Slices
{
    class Program
    {

        public static StringBuilder builder = new StringBuilder();

        static void Main(string[] args)
        {

            Order ord = new Order();
            var SliceImpl = new SlicesImplementation();

            ord.Amount = 1;
            string option = "Y";

            builder.Append(OrderNo(SliceImpl));

            builder.Append(Start(SliceImpl));

            while (option == "Y")
            {
                builder.Append(Pizza(SliceImpl));
                Console.WriteLine("Add Another Pizza? (Y/N)");
                option = Console.ReadLine().ToUpper();
                Console.Clear();
                if (option == "Y")
                {
                    ord.Amount += +1;
                    builder.Append(",");
                }

            }
            builder.Append($",Amount Of Pizza's: {ord.Amount}");

            SaveFile(SliceImpl);
        }

        static string OrderNo(IPizzaSlices pizza)
        {
            return pizza.OrderNumber();
        }

        static string Start(IPizzaSlices pizza)
        {
            return pizza.StartUp();
        }

        static string Pizza(IPizzaSlices pizza)
        {
            return pizza.PizzaSelection();
        }

        static void SaveFile(IPizzaSlices pizza)
        {
            pizza.Save(builder);
        }
    }
}
