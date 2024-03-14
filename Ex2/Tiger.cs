using Ex2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex2
{
    class Tiger : Animal
    {
        public Tiger(int weight, string name) : base(weight, name)
        {
        }

        public override void Show()
        {
            Console.WriteLine($"Name: {name}, Weight {weight}");
        }
    }
}
