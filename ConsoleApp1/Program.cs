using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://google.com");
        }
    }
}
