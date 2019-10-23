using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QDWorkshop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            var y = Convert.ToInt32(Console.ReadLine());

            var mathOperations = new MathOperations(x, y);
            Console.WriteLine(mathOperations.Multiply());
            Console.ReadLine();

            Console.WriteLine(mathOperations.Add());
            Console.ReadLine();
        }
    }
}
