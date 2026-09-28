using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Espresso : Beverage
    {
        public Espresso(Beverage beverage = null)
        {
            description = "Espresso";
            this.baseBeverage = beverage;
        
        }
        public override string GetDescription()
        {
            if (baseBeverage != null)
            {
                return baseBeverage.GetDescription() + ", " + description;
            }
            return description;
        }
        public override double cost()
        {
            double price = Size switch
            {
                Size.TALL => 1.99,
                Size.GRANDE => 2.49,
                Size.VENTI => 2.99,
                _ => throw new ArgumentOutOfRangeException(nameof(Size), Size, "Unsupported beverage size.")
            };

            return price + (baseBeverage == null ? 0 : baseBeverage.cost());
        }
    }
}
