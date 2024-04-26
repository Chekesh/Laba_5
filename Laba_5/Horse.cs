using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Hourse : Animal
{
    string farm;
    public Hourse(int food, string locathion, string farm) : base(food, locathion)
    {
        this.farm = farm;
    }
    public override void eat()
    {
        food++;
        Console.WriteLine("Лошадь покушала");
    }
    public override void makeNoise()
    {
        Console.WriteLine($"Лошадь на ферме: {farm}\nlocathion {locathion}\nfood {food}");
    }
}