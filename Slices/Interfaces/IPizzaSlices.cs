using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slices.Interfaces
{
    public interface IPizzaSlices
    {
        string StartUp();
        string PizzaSelection();
        string OrderNumber();
        void Save(StringBuilder builder);
    }
}
