using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D1_Inheritance
{
    class Fish : Animal
    {
        private int fins;

        private bool scales;
        private bool teeth;
        private string waterType;

        public Fish()
        {

        }
        public Fish(int fins, bool scales, bool teeth, string waterType): base(1, "silver")
        {
            this.fins = fins;
            this.scales = scales;
            this.teeth = teeth;
            this.waterType = waterType;
            Legs = 0;//can use a property from Parent class in child class. 
        }
        public void Swim ()
        {
            WhoAmI();
            Console.WriteLine("Just keep swimming, just keep swimming......");
        }
    }
}
