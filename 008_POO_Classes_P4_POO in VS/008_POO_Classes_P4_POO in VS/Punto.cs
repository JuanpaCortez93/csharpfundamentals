using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_POO_Classes_P4_POO_in_VS
{
    public class Punto
    {

        public Punto (double x = 0, double y = 0)
        {

            _x = x;
            _y = y;

            //Console.WriteLine($"Coordenada x: {x}. Coordenada y: {y}");
        }

        public double Distance (Punto AnotherPoint) => Math.Sqrt(Math.Pow(AnotherPoint._x - _x,2) + Math.Pow(AnotherPoint._y - _y, 2));
        private double _x, _y;

    }
}
