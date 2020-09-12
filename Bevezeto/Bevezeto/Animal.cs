using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Bevezeto
{
    // ez javában úgy menne hogy 'implements Serializable'
    [Serializable]
    abstract class Animal
    {
        // sima prop ahol a getter és setter csak ténylegesen egy sima getter és setter
        // semmi extra
        public string Name { get; set; }

        // Itt a setterbe már van logika azért néz ki az egész így
        // Kívülről továbbra is csak a nagybetűs Age látszik
        // Ez a set/get van a getAge es a setAge helyett.
        private int age;

        public int Age
        {
            get { return age; }
            set {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Age must be a number!");
                }
            }
        }


        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        
        public void YearPassed()
        {
            this.Age++;
        }

        public void Eat()
        {
            Console.WriteLine("nyamm nyamm");
        }

        public void SaveToFile()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream fs = null;
            try
            {
                fs = new FileStream("/test.txt", FileMode.Create, FileAccess.Write);
                formatter.Serialize(fs, this);
            } 
            catch (Exception e)
            {
                Console.WriteLine("Rip mentés");
            } 
            finally
            {
                fs.Close();   
            }
        }

    }
}
