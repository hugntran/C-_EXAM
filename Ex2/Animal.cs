using System;

namespace Ex2
{
    class Animal
    {
        protected int weight;
        protected string name;

        public Animal(int weight, string name)
        {
            SetMe(weight, name);
        }

        public void SetMe(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {name}, Weight: {weight}");
        }
    }
}
