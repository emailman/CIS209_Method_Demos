using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS209_Method_Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            double d, h;

            Console.Write("Enter the diameter of a cylinder: ");          
            if (Double.TryParse(Console.ReadLine(), out d))
            {
                Console.Write("Enter the height of a cylinder: ");
                if (Double.TryParse(Console.ReadLine(), out h))
                {
                    double v = CylinderVolume(diameter: d, height: h);
                    Console.WriteLine($"The volume of a cylinder with diameter {d} and height {h} is {v:F3}");
                }
                else
                    Console.WriteLine("Input Error: height was not a numerical value");
            }
            else
                Console.WriteLine("Input Error: diameter was not a numerical value");

            double s;

            Console.Write("\nEnter side of cube or leave blank to default to 1: ");
            String reply = Console.ReadLine();

            if (Double.TryParse(reply, out s))
                Console.WriteLine($"The volume of a cube with side {s} is {CubeVolume(s)}");
 
            else if (reply == "")
                Console.WriteLine($"The volume of a cube with side 1 is {CubeVolume()}");
            else
                Console.WriteLine("Input Error: side was not a numerical value");
        }       

        static double CylinderVolume(double diameter, double height)
        {
            return Math.PI * Math.Pow((diameter / 2), 2) * height;
        }

        static double CubeVolume(double side = 1) => Math.Pow(side, 3);
    }
}
