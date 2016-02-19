using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCircle
{
    class Program
    {

        static decimal PI = 3.14159m;
        int radius;
        static void Main(string[] args)
        {
            Console.OpenStandardOutput();

            bool inputtingData = true;
            Decimal circleArea, CircleCircumference, result;

            while(inputtingData)
            {
                Console.Write("Enter the radius of a circle: (type ? to end)");

                String data = Console.ReadLine();
                if (data == "?")
                {

                    inputtingData = false;
                    break;


                }
                else
                {
                    Console.WriteLine(" Illegal characters, tyr again");

                }
                
                if (decimal.TryParse(data, out result))
                {
                    circleArea = ComputeCircleArea(result);
                    CircleCircumference = ComputeCircumference(result);
                    Console.WriteLine("Area ={0}", circleArea);
                    Console.WriteLine("Circumference ={0}", CircleCircumference);
                }   

            }

        }


        static decimal ComputeCircleArea(decimal radius)
        {
            decimal area = Program.PI * radius * radius;
            return area;

        }

        static decimal ComputeCircumference(decimal radius)
        {
            decimal circumference = Program.PI * radius * 2;
            return circumference;

        }
    }
}
