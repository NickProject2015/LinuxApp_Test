using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinuxApp_Test
{
    class LoginPage
    {

        public void ImplicitMethod()
        {
            Int16 salary = 32767;
            Console.WriteLine("salary: " + salary.GetType().Name);
            int salaryIncrement = salary;
            salaryIncrement = 3276745;
            Console.WriteLine(salaryIncrement);

        }
        public void UserName()
        {
            Console.WriteLine("Click button");
        }
    }
}
