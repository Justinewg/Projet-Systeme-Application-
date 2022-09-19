using System;



class Program
{
    static void Main(string[] args)
    {
        PlainPizza plainPizzaObj = new PlainPizza();
        string plainPizza = plainPizzaObj.MakePizza();
        Console.WriteLine(plainPizza);

        PizzaDecorator cheeseDecorator = new CheeseDecorator(plainPizzaObj);
        string cheesePizza = cheeseDecorator.MakePizza();
        Console.WriteLine("\n'" + cheesePizza + "' using CheeseDecorator");

        VeggieDecorator veggieDecorator = new VeggieDecorator(plainPizzaObj);
        string veggiePizza = veggieDecorator.MakePizza();

        TomatoDecorator tomatoDecorator = new TomatoDecorator(plainPizzaObj);
        veggiePizza = tomatoDecorator.MakePizza();
        Console.WriteLine("\n'" + veggiePizza + "' using VeggieDecorator");

        Console.Read();
    }
}
