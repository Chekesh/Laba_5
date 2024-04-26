using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Cat : Animal
{

    string name;

    public Cat(int food, string locathion, string name): base(food,locathion)
    {
        this.name = name;
    }

    
    public override void makeNoise() {
        Console.WriteLine($"Кошка {name}:\nlocathion: + {locathion}\nfood = {food}");
    }

    public override void eat() {
        food++;
        Console.WriteLine("Кошка покушала");
    }
}

