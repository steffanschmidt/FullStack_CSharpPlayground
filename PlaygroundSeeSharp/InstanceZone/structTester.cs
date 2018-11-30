using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundSeeSharp.InstanceZone
{
    public struct Animal
    {
        private int amountOfLegs;
        public int AmountOfLegs
        {
            get { return amountOfLegs; } // get => amountOfLegs;
            set { if (value > 1) { amountOfLegs = value; }  } // set => amountOfLegs = value;
        }
        private string sizeOfAnimal;
        public string SizeOfAnimal
        {
            get { return sizeOfAnimal; }
            set { sizeOfAnimal = value; }
        }
        private string soundOfAnimal;
        public string SoundOfAnimal
        {
            get { return soundOfAnimal; }
            //set { soundOfAnimal = value; }
            set => soundOfAnimal = value;
        }

        public Animal(int amountOfLegs, string sizeOfAnimal, string soundOfAnimal)
        {
            this.amountOfLegs = amountOfLegs;
            this.sizeOfAnimal = sizeOfAnimal;
            this.soundOfAnimal = soundOfAnimal;
        }
    }

    public struct TestObject
    {
        public int integerValue;
    }
}
