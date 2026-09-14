internal class Beverage{

    protected string description;
	public virtual double cost()
    {
        double total = 0.0;

        if (HasMilk())
            total += 0.5;
        if (HasSoy())
            total += 0.4;
        if (HasMocha())
            total += 0.3;
        if (HasWhip())
            total += 0.2;
        return total;

	}
}

internal class DarkRoast : Beverage
{
    public DarkRoast()
    {
        description = "Most Expensive Dark Roast";
    }

    public override double cost()
    {
        return base.cost() + 1.0;
    }
}