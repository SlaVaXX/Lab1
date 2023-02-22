using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Vector
    {
        private double angle;
        private double length;
        private Vector2 coordinates;
        public Vector (double angle, double length)
        { 
            this.angle = angle;
            if (length < 0)
                Math.Abs(length);  
            this.length = length;
            coordinates = set_coordinates(angle, length);
        }
        public Vector2 set_coordinates (double angle, double length)
        {
            double x = length * Math.Cos(angle);
            double y = length * Math.Sin(angle);
            Vector2 result = new Vector2((float)x,(float)y);
            return result;
        }
        public Vector2 Coordinates
        {
            get { return coordinates; }
        }
        ~Vector()
        {
            Console.WriteLine("The end");
        }
    }
}
