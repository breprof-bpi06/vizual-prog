using System;

namespace Bevezeto
{
    class Lion : Cat
    {
        public Lion(string name, int age) : base(name, age) { }

        // És itt írjuk felül a Cat Pet metódusát
        public override void Pet()
        {
            Console.WriteLine("Megettem a karod :)");
        }
    }
}
