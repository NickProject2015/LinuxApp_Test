using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/* -----------------------------------
//Shift + Alt + Enter  -    full screen
//Shift + F10               run the prog

    Boxing and unboxing(check it)
//-----------------------------------
    */
namespace LinuxApp_Test
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
        }
        [SetUp]
        public void Initialize()
        {
            Utilities.driver = new FirefoxDriver();
            Utilities.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Opened URL");
        }
        [Test]
        public void ExecuteTestCase()
        {
            LoginPageElements pageLogin = new LoginPageElements();
            PageProperties secondePage = pageLogin.Login("Nick", "Nick");
            //Thread.Sleep(2000);
            WaitProperties.ImplicitWait(Utilities.driver);
            secondePage.PagePropertiesAction("Calean", "Calean_Doi", "Calean_trei");
            TakeScreenShotClass.TestScreenShot(Utilities.driver);
            
        }
        [TearDown]
        public void CloseBrowser()
        {
            //PropertiesCollection.driver.Close();
            Console.WriteLine("Close the broser");
        }
    }

}








