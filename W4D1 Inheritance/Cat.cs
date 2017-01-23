using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D1_Inheritance
{
    class Cat : Animal
    {
        private int age;
        private string breed;
        private string furLength;
        private bool declawed;

        public Cat()
        {

        }
        public Cat(int age)
        {
            this.age = age;
        }

        public Cat(string breed, string furLength, bool declawed, string color) : base(5, 10)
        {
            this.breed = breed;
            this.furLength = furLength;
            this.declawed = declawed;
            this.color = color;
            this.isGoodToEat = true;
        }
        public void Speak()
        {
            WhoAmI();
            Console.WriteLine("Meow!");
        }
    }
}
