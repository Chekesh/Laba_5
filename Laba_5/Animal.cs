using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Animal
{
    public int food;
    public string locathion;
    public Animal(int food, string locathion)
    {
        this.food = food;
        this.locathion = locathion;
    }
    public virtual void eat()
    {
        food++;
        Console.WriteLine("Животное покушало");
    }
    public void sleep()
    {
        this.locathion = "спит";
    }

    public virtual void makeNoise()
    {
        Console.WriteLine("food=" + food + "locathion" + locathion);
    }
}

