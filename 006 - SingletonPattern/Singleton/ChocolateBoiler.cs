namespace Singleton
{
    internal class ChocolateBoiler
    {
        private static volatile ChocolateBoiler? instance;
        private static readonly object lockObject = new object();

        private bool empty;
        private bool boiled;

        public bool IsEmpty { get { return this.empty; } }
        public bool IsBoiled { get { return this.boiled; } }

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            var current = instance;
            if (current == null)
            {
                lock (lockObject)
                {
                    current = instance;
                    if (current == null)
                    {
                        current = new ChocolateBoiler();
                        instance = current;
                    }
                }
            }

            return current;
        }

        public void fill()
        {
            if (empty)
            {
                empty = false;
                boiled = false;
            }
        }

        public void drain()
        {
            if (!empty && boiled)
            {
                empty = true;
            }
        }

        public void boil()
        {
            if (!empty && !boiled)
            {
                boiled = true;
            }
        }
    }
}
