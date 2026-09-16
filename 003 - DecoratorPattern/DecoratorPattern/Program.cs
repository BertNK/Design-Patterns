using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using BaseEspresso = DecoratorPattern.Beverages.Espresso;
using BaseWater = DecoratorPattern.Beverages.Water;
using BaseChocolate = DecoratorPattern.Beverages.Chocolate;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new BaseEspresso();
            espresso.Size = Size.TALL;
            PrintBeverage(espresso);

            Beverage doppio = new BaseEspresso();
            doppio = new Condiments.Espresso(doppio);
            PrintBeverage(doppio);

            Beverage lungo = new BaseEspresso();
            lungo = new BaseWater(lungo);
            lungo.Size = Size.GRANDE;
            PrintBeverage(lungo);

            Beverage macchiato = new BaseEspresso();
            macchiato = new MilkFoam(macchiato);
            PrintBeverage(macchiato);

            Beverage corretta = new BaseEspresso();
            corretta = new Liquor(corretta);
            PrintBeverage(corretta);

            Beverage conPanna = new BaseEspresso();
            conPanna = new Whip(conPanna);
            conPanna.Size = Size.GRANDE;
            PrintBeverage(conPanna);

            Beverage cappuccino = new BaseEspresso();
            cappuccino = new SteamedMilk(cappuccino);
            cappuccino = new MilkFoam(cappuccino);
            PrintBeverage(cappuccino);

            Beverage americano = new BaseEspresso();
            americano = new BaseWater(americano);
            americano = new BaseWater(americano);
            americano.Size = Size.VENTI;
            PrintBeverage(americano);

            Beverage caffeLatte = new BaseEspresso();
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new MilkFoam(caffeLatte);
            PrintBeverage(caffeLatte);

            Beverage flatWhite = new BaseEspresso();
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite = new SteamedMilk(flatWhite);
            PrintBeverage(flatWhite);

            Beverage romana = new BaseEspresso();
            romana = new Lemon(romana);
            PrintBeverage(romana);

            Beverage morocchino = new BaseEspresso();
            morocchino = new Condiments.Chocolate(morocchino);
            morocchino = new MilkFoam(morocchino);
            PrintBeverage(morocchino);

            Beverage mocha = new BaseEspresso();
            mocha = new Condiments.Chocolate(mocha);
            mocha = new SteamedMilk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage(mocha);

            Beverage bicerin = new BaseEspresso();
            bicerin = new BlackChocolate(bicerin);
            bicerin = new WhiteChocolate(bicerin);
            bicerin = new Whip(bicerin);
            PrintBeverage(bicerin);

            Beverage breve = new BaseEspresso();
            breve = new MilkFoam(breve);
            breve = new HalfMilk(breve);
            PrintBeverage(breve);

            Beverage rafCoffee = new BaseEspresso();
            rafCoffee = new VanillaSugar(rafCoffee);
            rafCoffee = new Cream(rafCoffee);
            PrintBeverage(rafCoffee);

            Beverage meadRaf = new BaseEspresso();
            meadRaf = new Honey(meadRaf);
            meadRaf = new Cream(meadRaf);
            PrintBeverage(meadRaf);

            Beverage galao = new BaseEspresso();
            galao = new MilkFoam(galao);
            galao = new MilkFoam(galao);
            PrintBeverage(galao);

            Beverage caffeAffogato = new BaseEspresso();
            caffeAffogato = new Condiments.Espresso(caffeAffogato);
            caffeAffogato = new IceCream(caffeAffogato);
            PrintBeverage(caffeAffogato);

            Beverage viennaCoffee = new BaseEspresso();
            viennaCoffee = new Condiments.Espresso(viennaCoffee);
            viennaCoffee = new Whip(viennaCoffee);
            viennaCoffee = new Whip(viennaCoffee);
            PrintBeverage(viennaCoffee);

            Beverage glace = new BaseEspresso();
            glace = new IceCream(glace);
            PrintBeverage(glace);

            Beverage chocolateMilk = new BaseChocolate();
            chocolateMilk = new Milk(chocolateMilk);
            chocolateMilk = new Milk(chocolateMilk);
            PrintBeverage(chocolateMilk);

            Beverage demiCreme = new BaseEspresso();
            demiCreme = new Condiments.Espresso(demiCreme);
            demiCreme = new Cream(demiCreme);
            demiCreme = new Cream(demiCreme);
            PrintBeverage(demiCreme);

            Beverage latteMacchiato = new BaseEspresso();
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new MilkFoam(latteMacchiato);
            PrintBeverage(latteMacchiato);

            Beverage freddo = new BaseEspresso();
            freddo = new Liquor(freddo);
            freddo = new Ice(freddo);
            PrintBeverage(freddo);

            Beverage frappuccino = new BaseEspresso();
            frappuccino = new Ice(frappuccino);
            frappuccino = new SteamedMilk(frappuccino);
            frappuccino = new Whip(frappuccino);
            frappuccino.Size = Size.VENTI;
            PrintBeverage(frappuccino);

            Beverage caramelFrappuccino = new BaseEspresso();
            caramelFrappuccino = new Ice(caramelFrappuccino);
            caramelFrappuccino = new SteamedMilk(caramelFrappuccino);
            caramelFrappuccino = new Cream(caramelFrappuccino);
            caramelFrappuccino = new Syrup(caramelFrappuccino);
            PrintBeverage(caramelFrappuccino);

            Beverage frappe = new BaseEspresso();
            frappe = new SteamedMilk(frappe);
            frappe = new SteamedMilk(frappe);
            frappe = new IceCream(frappe);
            PrintBeverage(frappe);

            Beverage irishCoffee = new BaseEspresso();
            irishCoffee = new Condiments.Espresso(irishCoffee);
            irishCoffee = new Whiskey(irishCoffee);
            irishCoffee = new Whip(irishCoffee);
            PrintBeverage(irishCoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " (" + beverage.Size + ") $" + beverage.cost().ToString("#.##"));
        }
    }
}