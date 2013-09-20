using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 7
            Sphere sphere = new Sphere(4.5);
            Console.WriteLine(sphere.ToString());
            Console.WriteLine("Sphere volume, called from IHasVolume,  is :: "+((IHasVolume)sphere).getVolume());

            Console.WriteLine("\nPress any key to continue...\n");
            Console.Read();

            //Part 8
            List<Sphere> spheres = new List<Sphere>();
            Random r;
            for (int i = 0; i < 10; i++)
            {
                r = new Random(i*i+20); //random seed
                spheres.Add(new Sphere((double)r.Next(1,500)+r.NextDouble())); //random sphere radius
            }

            foreach (Sphere s in spheres)
            {
                Console.WriteLine(s.ToString());
            }

            Console.Read();
            Console.Read();

        }
    }
}
