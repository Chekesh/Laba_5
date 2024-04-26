using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(10, "Не спит", "Никита");
            Cat cat = new Cat(11, "Не спит", "Мартис");
            Hourse hourse = new Hourse(15, "Не спит", "ферма дяди берна");

            Veterinarian vet = new Veterinarian();

            
            vet.treatAnimal(dog);
            vet.treatAnimal(cat);
            vet.treatAnimal(hourse);

            Console.Read();

        }
    }
}
