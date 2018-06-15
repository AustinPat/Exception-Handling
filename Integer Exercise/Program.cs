using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Exercise
{
    class Program
    {
        public static object Sum { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number that you want to do math operations on:");
            //Method methodName = new Method();
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type another number");
            int otherNum = Convert.ToInt32(Console.ReadLine());
            Math.Sum(userNum, otherNum);
            Math.Sub(userNum, otherNum);
            Math.Multiply(userNum, otherNum);
            Console.WriteLine ("Your numbers added together: " + Math.total + "\n Your first number subtracted by your second number: " + Math.Result + "\n your numbers multiplied by eachother: " + Math.Solution);
            Console.ReadLine();

        }
        
    }
}
