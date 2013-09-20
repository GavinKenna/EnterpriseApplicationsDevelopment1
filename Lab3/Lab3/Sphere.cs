using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Sphere:IHasVolume
    {
        private double radius;

        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                this.radius = value;
            }
        }

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public double getVolume()
        {
            return Math.PI * radius * radius * radius;
        }

        public override string ToString()
        {
            return "Information about this sphere :: \nRadius is :: "+this.radius + " \nVolume is :: " + this.getVolume()+"\n";
        }
    }
}
