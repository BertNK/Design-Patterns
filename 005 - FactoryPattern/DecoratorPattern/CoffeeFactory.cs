using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

using BaseEspresso = DecoratorPattern.Beverages.Espresso;
using BaseWater = DecoratorPattern.Beverages.Water;
using BaseChocolate = DecoratorPattern.Beverages.Chocolate;

namespace DecoratorPattern
{
    internal enum CoffeeType
    {
        Espresso,
        Doppio,
        Lungo,
        Macchiato,
        Corretta,
        ConPanna,
        Cappuccino,
        Americano,
        CaffeLatte,
        FlatWhite,
        Romana,
        Morocchino,
        Mocha,
        Bicerin,
        Breve,
        RafCoffee,
        MeadRaf,
        Galao,
        CaffeAffogato,
        ViennaCoffee,
        Glace,
        ChocolateMilk,
        DemiCreme,
        LatteMacchiato,
        Freddo,
        Frappuccino,
        CaramelFrappuccino,
        Frappe,
        IrishCoffee
    }

    internal static class CoffeeFactory
    {
        public static Beverage CreateCoffee(
            CoffeeType coffeeType,
            Size size = Size.TALL)
        {
            Beverage coffee;

            switch (coffeeType)
            {
                case CoffeeType.Espresso:
                    coffee = new BaseEspresso();
                    break;

                case CoffeeType.Doppio:
                    coffee = new BaseEspresso();
                    coffee = new Condiments.Espresso(coffee);
                    break;

                case CoffeeType.Lungo:
                    coffee = new BaseEspresso();
                    coffee = new BaseWater(coffee);
                    break;

                case CoffeeType.Macchiato:
                    coffee = new BaseEspresso();
                    coffee = new MilkFoam(coffee);
                    break;

                case CoffeeType.Corretta:
                    coffee = new BaseEspresso();
                    coffee = new Liquor(coffee);
                    break;

                case CoffeeType.ConPanna:
                    coffee = new BaseEspresso();
                    coffee = new Whip(coffee);
                    break;

                case CoffeeType.Cappuccino:
                    coffee = new BaseEspresso();
                    coffee = new SteamedMilk(coffee);
                    coffee = new MilkFoam(coffee);
                    break;

                case CoffeeType.Americano:
                    coffee = new BaseEspresso();
                    coffee = new BaseWater(coffee);
                    coffee = new BaseWater(coffee);
                    break;

                case CoffeeType.CaffeLatte:
                    coffee = new BaseEspresso();
                    coffee = new SteamedMilk(coffee);
                    coffee = new SteamedMilk(coffee);
                    coffee = new MilkFoam(coffee);
                    break;

                case CoffeeType.FlatWhite:
                    coffee = new BaseEspresso();
                    coffee = new SteamedMilk(coffee);
                    coffee = new SteamedMilk(coffee);
                    break;

                case CoffeeType.Romana:
                    coffee = new BaseEspresso();
                    coffee = new Lemon(coffee);
                    break;

                case CoffeeType.Morocchino:
                    coffee = new BaseEspresso();
                    coffee = new Condiments.Chocolate(coffee);
                    coffee = new MilkFoam(coffee);
                    break;

                case CoffeeType.Mocha:
                    coffee = new BaseEspresso();
                    coffee = new Condiments.Chocolate(coffee);
                    coffee = new SteamedMilk(coffee);
                    coffee = new Whip(coffee);
                    break;

                case CoffeeType.Bicerin:
                    coffee = new BaseEspresso();
                    coffee = new BlackChocolate(coffee);
                    coffee = new WhiteChocolate(coffee);
                    coffee = new Whip(coffee);
                    break;

                case CoffeeType.Breve:
                    coffee = new BaseEspresso();
                    coffee = new MilkFoam(coffee);
                    coffee = new HalfMilk(coffee);
                    break;

                case CoffeeType.RafCoffee:
                    coffee = new BaseEspresso();
                    coffee = new VanillaSugar(coffee);
                    coffee = new Cream(coffee);
                    break;

                case CoffeeType.MeadRaf:
                    coffee = new BaseEspresso();
                    coffee = new Honey(coffee);
                    coffee = new Cream(coffee);
                    break;

                case CoffeeType.Galao:
                    coffee = new BaseEspresso();
                    coffee = new MilkFoam(coffee);
                    coffee = new MilkFoam(coffee);
                    break;

                case CoffeeType.CaffeAffogato:
                    coffee = new BaseEspresso();
                    coffee = new Condiments.Espresso(coffee);
                    coffee = new IceCream(coffee);
                    break;

                case CoffeeType.ViennaCoffee:
                    coffee = new BaseEspresso();
                    coffee = new Condiments.Espresso(coffee);
                    coffee = new Whip(coffee);
                    coffee = new Whip(coffee);
                    break;

                case CoffeeType.Glace:
                    coffee = new BaseEspresso();
                    coffee = new IceCream(coffee);
                    break;

                case CoffeeType.ChocolateMilk:
                    coffee = new BaseChocolate();
                    coffee = new Milk(coffee);
                    coffee = new Milk(coffee);
                    break;

                case CoffeeType.DemiCreme:
                    coffee = new BaseEspresso();
                    coffee = new Condiments.Espresso(coffee);
                    coffee = new Cream(coffee);
                    coffee = new Cream(coffee);
                    break;

                case CoffeeType.LatteMacchiato:
                    coffee = new BaseEspresso();
                    coffee = new SteamedMilk(coffee);
                    coffee = new SteamedMilk(coffee);
                    coffee = new MilkFoam(coffee);
                    break;

                case CoffeeType.Freddo:
                    coffee = new BaseEspresso();
                    coffee = new Liquor(coffee);
                    coffee = new Ice(coffee);
                    break;

                case CoffeeType.Frappuccino:
                    coffee = new BaseEspresso();
                    coffee = new Ice(coffee);
                    coffee = new SteamedMilk(coffee);
                    coffee = new Whip(coffee);
                    break;

                case CoffeeType.CaramelFrappuccino:
                    coffee = new BaseEspresso();
                    coffee = new Ice(coffee);
                    coffee = new SteamedMilk(coffee);
                    coffee = new Cream(coffee);
                    coffee = new Syrup(coffee);
                    break;

                case CoffeeType.Frappe:
                    coffee = new BaseEspresso();
                    coffee = new SteamedMilk(coffee);
                    coffee = new SteamedMilk(coffee);
                    coffee = new IceCream(coffee);
                    break;

                case CoffeeType.IrishCoffee:
                    coffee = new BaseEspresso();
                    coffee = new Condiments.Espresso(coffee);
                    coffee = new Whiskey(coffee);
                    coffee = new Whip(coffee);
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(coffeeType),
                        coffeeType,
                        "This coffee type is not available.");
            }

            coffee.Size = size;
            return coffee;
        }
    }
}

