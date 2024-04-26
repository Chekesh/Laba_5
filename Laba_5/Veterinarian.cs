 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Veterinarian
{
    public void treatAnimal(Animal animal)
    {
        Console.WriteLine($"locathion: {animal.locathion} food: {animal.food}");
    }
}