using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal abstract class Pizza
    {
        internal void Bake()
        {
            Console.WriteLine("Baking the " + this.GetType().Name);
        }

        internal void Box()
        {
            Console.WriteLine("Boxing the " + this.GetType().Name);
        }

        internal void Cut()
        {
            Console.WriteLine("Cutting the " + this.GetType().Name);
        }

        internal void Prepare()
        {
            Console.WriteLine("Preparing the " + this.GetType().Name);
        }
    }
}
