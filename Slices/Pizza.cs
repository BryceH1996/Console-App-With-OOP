using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slices
{
    public abstract class Pizza
    {
        public int Amount { get; set; }
        public string Base { get; set; }
        public double Cost { get; set; }

        public virtual string Price(string Type, string Size)
        {
            Type = "Margherita";
            if (Size == "1")
            {
                Size = "Small";
                Cost = 30;
                return $"Cost: R{Cost},Size: {Size},Type: {Type}";
            }

            if (Size == "2")
            {
                Size = "Medium";
                Cost = 50;
                return $"Cost: R{Cost},Size: {Size},Type: {Type}";
            }

            if (Size == "3")
            {
                Size = "Large";
                Cost = 70;
                return $"Cost: R{Cost},Size: {Size},Type: {Type}";
            }

            return Cost.ToString();

        }
    }
}
