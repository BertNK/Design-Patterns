using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENTI
    }
    internal abstract class Beverage
    {
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                if (baseBeverage != null)
                {
                    baseBeverage.Size = value;
                }
            }
        }
        private Size size = Size.TALL;
        protected string description = "Unknown";
        protected Beverage baseBeverage = null;

        public virtual string GetDescription()
        {
            return description;
        }

        protected double PriceBySize(double tall, double grande, double venti)
        {
            return Size switch
            {
                Size.GRANDE => grande,
                Size.VENTI => venti,
                _ => tall
            };
        }

        public abstract double cost();
    }
}
