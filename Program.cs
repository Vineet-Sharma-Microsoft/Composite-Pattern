using System;
using System.Collections.Generic;

// Component interface
interface IFruit
{
    void Eat();
}

// Leaf class
class Apple : IFruit
{
    public void Eat()
    {
        Console.WriteLine("Eating an apple");
    }
}

// Leaf class
class Banana : IFruit
{
    public void Eat()
    {
        Console.WriteLine("Eating a banana");
    }
}

// Composite class
class FruitBasket : IFruit
{
    private List<IFruit> fruits = new List<IFruit>();

    public void AddFruit(IFruit fruit)
    {
        fruits.Add(fruit);
    }

    public void Eat()
    {
        Console.WriteLine("Eating from the fruit basket:");
        foreach (var fruit in fruits)
        {
            fruit.Eat();
        }
    }
}

class Program
{
    static void Main()
    {
        var apple = new Apple();
        var banana = new Banana();

        var basket1 = new FruitBasket();
        basket1.AddFruit(apple);
        basket1.AddFruit(banana);

        var basket2 = new FruitBasket();
        basket2.AddFruit(apple);

        Console.WriteLine("Eating from individual fruits:");
        apple.Eat();
        banana.Eat();

        Console.WriteLine();
        basket1.Eat();

        Console.WriteLine();
        basket2.Eat();
    }
}
