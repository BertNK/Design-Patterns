using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.CompareTo
{
    internal class Duck : IComparable<Duck>
    {
        string name;
        int weight;

        public Duck(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public int CompareTo(Duck? other)
        {
            if (other is null)
            {
                return 1;
            }

            return weight.CompareTo(other.weight);
        }

        public override string ToString()
        {
            return $"{name} weights {weight}";
        }
    }
}
