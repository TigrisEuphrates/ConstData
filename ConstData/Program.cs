using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class MyMathClass
    {
        //public const double PI = 3.14;
        public static readonly double PI=3.14;
        //public MyMathClass()
        //{
        //    PI = 3.14;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The value of PI is {MyMathClass.PI}");
            //Error: MyMathClass.PI = 3.1444;
            Console.WriteLine();
        }
        static void LocalConstStringVariable()
        {
            const string fixedStr = "Fixed string Data";
            Console.WriteLine(fixedStr);
        }
    }
}
