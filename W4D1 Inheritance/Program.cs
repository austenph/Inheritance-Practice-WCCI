﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D1_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal(2, "Tan");
            Animal animal2 = new Animal(6, 1, 1);

            animal1.PrintAnimalInfo();
            animal2.PrintAnimalInfo();

            Cat cat1 = new Cat("Grumpy", "Short", false, "grey");
            cat1.Legs = 2;//changes legs to 2
            cat1.GoodToEat = false;
            Console.WriteLine("Is good to eat: " + cat1.GoodToEat);
            cat1.PrintAnimalInfo();
        }
    }
}
