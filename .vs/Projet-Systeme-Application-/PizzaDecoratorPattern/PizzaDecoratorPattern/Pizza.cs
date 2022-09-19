using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public interface Pizza
{
    string MakePizza();
}

public class PlainPizza : Pizza
{
    public string MakePizza()
    {
        return "Plain Pizza";
    }
}

public abstract class PizzaDecorator : Pizza
{
    protected Pizza pizza;

    public PizzaDecorator(Pizza pizza)
    {
        this.pizza = pizza;
    }

    public virtual string MakePizza()
    {
        return pizza.MakePizza();
    }
}


public class CheeseDecorator : PizzaDecorator
{
    public CheeseDecorator(Pizza pizza) : base(pizza) { }

    public override string MakePizza()
    {
        return pizza.MakePizza() + addCheese();
    }

    private string addCheese()
    {
        return ", Cheese added";
    }
}

public class TomatoDecorator : PizzaDecorator
{
    public TomatoDecorator(Pizza pizza) : base(pizza) { }

    public override string MakePizza()
    {
        return pizza.MakePizza() + addTomato();
    }

    private string addTomato()
    {
        return ", Tomato added";
    }
}

public class VeggieDecorator : PizzaDecorator
{
    public VeggieDecorator(Pizza pizza) : base(pizza) { }

    public override string MakePizza()
    {
        return pizza.MakePizza() + addVeggie();
    }

    private string addVeggie()
    {
        return ", Vegetables added";
    }
}