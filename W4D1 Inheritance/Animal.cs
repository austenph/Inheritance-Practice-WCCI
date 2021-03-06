﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D1_Inheritance
{
    class Animal
    {
            private int legs;
            private int size;
            private int weight;

            protected string color;

            protected bool isGoodToEat;
        public int Legs
        {
            get { return this.legs; }
            set { this.legs = value; }
        }
        public bool GoodToEat
        {
            get { return this.isGoodToEat; }
            set { this.isGoodToEat = value; }
        }
            public Animal()
            {
            }

            public Animal(int legs, string color)
            {
                this.legs = legs;
                this.color = color;
            }

            public Animal(int size, int weight)
            {
                this.legs = 4;
                this.size = size;
                this.weight = weight;
            }

            public Animal(int legs, int size, int weight, string color)
            {
                this.legs = legs;
                this.size = size;
                this.weight = weight;
                this.color = color;
            }

            public void PrintAnimalInfo()
            {
                Console.WriteLine("This animal has " + legs + " legs");
                Console.WriteLine("It's size is  " + size);
                Console.WriteLine("It weighs " + weight);
                Console.WriteLine("And it's color is " + color);
            }
        protected void WhoAmI()
        {
            Console.WriteLine("I am an animal");
        }
        }
     }
