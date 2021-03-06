﻿
using System;

public class Tiger : Feline
{
    public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {
    }

    public override string AskForFood()
    {
        return "ROAR!!!";
    }

    public override void EatFood(Food food)
    {
        if (food.GetType().Name == "Meat")
        {
            this.Weight += food.Quantity * 1.0;

            this.FoodEaten += food.Quantity;
        }
        else
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
    }
}
