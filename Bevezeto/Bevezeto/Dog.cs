using System;

namespace Bevezeto
{
    // Java megfelelő:
    // class Dog extends Animal implements ICanBark, IPetable
    class Dog : Animal, ICanBark, IPetable
    {
        // Ez itt kívülről read only, mert a setter privát.
        // Csak belülről lehet változatni.
        public bool IsBarking { get; private set; }

        // Konstruktor
        // a ': base(name, age)' a 'super(name, age)' megfelelője
        public Dog(string name, int age) : base(name, age)
        {
            this.IsBarking = false;
        }

        public void ShutUp()
        {
            this.IsBarking = false;
        }

        // Interfaceből jön (ICanBark)
        public void Bark()
        {
            Console.WriteLine("Vauu, Vauuuuuuuuuuuuuu");
        }

        // Interfaceből jön (IPetable)
        public void Pet()
        {
            Console.WriteLine("Köszi a simogatást!");
        }
    }
}
