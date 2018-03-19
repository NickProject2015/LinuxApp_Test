using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinuxApp_Test
{
    class Method
    {
        public void MethodTest()
        {
            Console.WriteLine("MethodTest: ");
        }
        public void Add()
        {
            Console.WriteLine("this is an empty add methood:");
        }
        public  int Add(int num1, int num2)
        {
            Console.WriteLine("this is an method with 2 parametr :");
            Console.WriteLine("num one is: " + num1);
            Console.WriteLine("num two is: " + num2);
            int result = num1 + num2;
            Console.WriteLine("add mwthod one plus two: " + result);
            return result;
            

        }
    }
}
