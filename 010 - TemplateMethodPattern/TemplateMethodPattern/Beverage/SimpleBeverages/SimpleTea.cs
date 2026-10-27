namespace TemplateMethodPattern
{
    internal class SimpleTea
    {
        public void prepareRecipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }
        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        public void SteepTeaBag()
        {
            Console.WriteLine("Steeping the tea");
        }
        public void PourInCup()
        {
            Console.WriteLine("Pouring into Cup");
        }
        public void AddLemon()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}
