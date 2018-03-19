using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinuxApp_Test
{
    class TestMethod
           
    {
        private int i = 0;
        public void SetValue(int value)
        {
            i = value;
        }
        public void GetValue()
        {
            Console.WriteLine("The value of i equal: " + i);
        }
        public void TestCase1(string Result)
        {
            Console.WriteLine("TestCase Nr 1 " + Result);
        }

        public void TestCase2(string Result)
        {
            Console.WriteLine("TestCase Nr 2 " + Result);
        }
    }
}
