using System;

namespace Bevezeto
{
    // Java megfelelő:
    // class Cat extends Animal implements IPetable
    class Cat : Animal, IPetable
    {
        // Konstruktor
        // a ': base(name, age)' a 'super(name, age)' megfelelője
        public Cat(string name, int age) : base(name, age) {}

        // Ez azért virtual mert a Lion (oroszlán) felül fogjuk írni.
        public virtual void Pet()
        {
            Console.WriteLine("Köszi a simogatást!");
        }

    }
}
