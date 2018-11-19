using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slices
{
    public class Order : Pizza
    {
        public int OrderNum { get; set; }

        public override string Price(string Type, string Size)
        {
            if (Type == "2")
            {
                Type = "Hawaiian";
                if (Size == "1")
                {
                    Size = "Small";
                    Cost = 40;
                    return $"Cost: R{Cost},Size: {Size},Type: {Type}";
                }

                if (Size == "2")
                {
                    Size = "Medium";
                    Cost = 65;
                    return $"Cost: R{Cost},Size: {Size},Type: {Type}";
                }

                if (Size == "3")
                {
                    Size = "Large";
                    Cost = 93;
                    return $"Cost: R{Cost},Size: {Size},Type: {Type}";
                }
            }

            if(Type == "3")
            {
                Type = "Meat Lovers";
                if (Size == "1")
                {
                    Size = "Small";
                    Cost = 45;
                    return $"Cost: R{Cost},Size: {Size},Type: {Type}";
                }

                if (Size == "2")
                {
                    Size = "Medium";
                    Cost = 75;
                    return $"Cost: R{Cost},Size: {Size},Type: {Type}";
                }

                if (Size == "3")
                {
                    Size = "Large";
                    Cost = 108;
                    return $"Cost: R{Cost},Size: {Size},Type: {Type}";
                }
            }

            return base.Price(Type, Size);
        }
    }
}
