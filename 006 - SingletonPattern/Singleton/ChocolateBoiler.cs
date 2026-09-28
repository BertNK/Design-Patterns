namespace Singleton
{
    internal class ChocolateBoiler
    {
        private static ChocolateBoiler instance;
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
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new ChocolateBoiler();
                }

                return instance;
            }
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
