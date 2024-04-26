using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Dog : Animal
{
    public string owner { get; set; }

    public Dog(int food, string locathion, string owner) : base(food,locathion){
        this.owner = owner;
    }

    public override void makeNoise() {
        Console.WriteLine($"Собака с хозяином {owner}:\nlocathion {locathion}\nfood {food}");
    }

    public override void eat() {
        food++;
        Console.WriteLine("Собака покушала");
    }
}