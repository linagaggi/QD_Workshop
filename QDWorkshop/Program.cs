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
            Console.WriteLine("Enter first word: ");
            var x = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter second word: ");
            var y = Convert.ToString(Console.ReadLine());

            var mathOperations = new Conjoin(x, y);
            Console.WriteLine(mathOperations.ConjoinFunc());
            Console.ReadLine();
        }
    }
}
