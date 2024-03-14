using System;

namespace GeometryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder(38.64, 22.48);
            cylinder.Process();
            cylinder.DisplayResult();
        }
    }
}
