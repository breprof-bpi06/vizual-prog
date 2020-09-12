// Beimportálja a System namespace-t
// Ezért van az hogy Console.ReadKey() és nem System.Console.Readkey();
using System;

// Projekt namesapce-e (névtere)
namespace Bevezeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Béla", 2);
            dog.Name = "Pista";
            dog.Eat();

            Dog dog2 = new Dog("Józsi", 1);
            dog2.Bark();
            dog2.Pet();
            // Csak egy kis extra -> DogExtension
            dog2.Barmi();

            Cat cat = new Cat("Cirmi", 2);
            cat.Pet();

            Cat oroszlan = new Lion("Simba", 1);
            oroszlan.Pet();

            Console.ReadKey();
        }
    }
}
