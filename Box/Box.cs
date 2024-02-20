using System;
using System.Collections.Generic;
using System.Text;

namespace Box
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length,double width,double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get
            =>length;
                
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Lenght cannot be zero or negative.");
                }
                length = value;
            }
        }

        public double Width
        {
            get => width;
            /*{
                return this.width;
                ;
            }*/
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Width cannot be zero or negative.");
                }
                width = value;
            }
        }

        public double Height
        {
            get => height;
            /*{
                return this.height;
                ;
            }*/
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Height cannot be zero or negative.");
                }
                height = value;
            }
        }
        public double SurfaceArea() => 2 * length * width + 2 * length * height + 2 * width * height;

        public double LateralSurfaceArea()
        { return 2 * length * height + 2 * width * height; }

        public double Volume()
            => length * width * height;
    }
}
