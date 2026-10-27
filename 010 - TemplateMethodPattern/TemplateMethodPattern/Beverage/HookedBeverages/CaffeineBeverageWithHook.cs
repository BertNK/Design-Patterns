namespace TemplateMethodPattern
{
    internal abstract class CaffeineBeverageWithHook
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondement())
            {
                AddCondiments();
            }
        }

        public abstract void Brew();
        public abstract void AddCondiments();
        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public virtual bool CustomerWantsCondement()
        {
            return true;
        }
    }
}
