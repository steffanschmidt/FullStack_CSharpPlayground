using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundSeeSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //if (args.Length > 0)
            //{
            //    Console.WriteLine("Numbers of arguments = " + args.Length);
            //    Console.WriteLine("The following arguments have been entered: ");
            //    for (int i = 0; i < args.Length; i++)
            //    {
            //        Console.WriteLine("Arguement[" + i + "]: " + args[i]);
            //        // Console.WriteLine("Whatever Argument[{0}] " + args[i], i);
            //    }
            //}

            //Console.WriteLine("Third Argument: " + args[2]);
            //int a = Int32.Parse(args[2]);
            //int b = Convert.ToInt32(args[2]);
            //Console.WriteLine("Third arg {0} as int using Parse", a);
            //Console.WriteLine("Third as int using Convert " + b);

            //if (Int32.Parse(args[3]) >= 10)
            //{
            //    int CountTo = Int32.Parse(args[3]);
            //    Console.WriteLine("Bigger than or equal to four, number giver {}", CountTo);
            //}


            // Creating a struct, making constructor and assigning values to properties

            //Animal.Animal animal1 = new Animal.Animal(2, "medium", "weeeee");

            //Console.WriteLine("Our animal has {0} legs, is of size {1} and says {2}", animal1.AmountOfLegs,
            //    animal1.SizeOfAnimal, animal1.SoundOfAnimal);


            //Console.ReadKey();

            //animal1.AmountOfLegs = 4;
            //animal1.SizeOfAnimal = "large";
            //animal1.SoundOfAnimal = "muuuuuhh";

            //Console.WriteLine("Our animal has {0} legs, is of size {1} and says {2}", animal1.AmountOfLegs,
            //    animal1.SizeOfAnimal, animal1.SoundOfAnimal);

            //Console.ReadKey();

            InstanceZone.Animal animal2 = new InstanceZone.Animal()
            {
                AmountOfLegs = 8,
                SizeOfAnimal = "heavy-duty",
                SoundOfAnimal = "MAAAAHHHH"
            };


            Console.WriteLine("Our animal has {0} legs, is of size {1} and says {2}", animal2.AmountOfLegs,
                animal2.SizeOfAnimal, animal2.SoundOfAnimal);

            Console.ReadKey();

            InstanceZone.TestObject testobject1 = new InstanceZone.TestObject()
            {
                integerValue = 4
            };

            Console.WriteLine("Value set to {0}", testobject1.integerValue);

            Console.ReadKey();
        }
    }
}