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
        //IWebDriver driver = new FirefoxDriver();
        static void Main(string[] args)
        {
            ////Methods
            //Console.WriteLine("____Methods______");
            //Method methodclass = new Method();
            //methodclass.MethodTest();
            //methodclass.Add();
            //methodclass.Add(1, 2);


            //Console.WriteLine("___________________________");

            ////implicit convertion
            //Console.WriteLine("____implicit convertion______");
            ////using var for creating instance
            //var loginPage2 = new LoginPage();
            //loginPage2.UserName();
            //LoginPage loginPage = new LoginPage();
            //loginPage.ImplicitMethod();
            //Console.WriteLine("___________________________");



            ////Test Method. Calling the class
            //Console.WriteLine("____Test Method. Calling the class______");
            //TestMethod testCases = new TestMethod();
            //testCases.TestCase1("Momosea");
            //testCases.TestCase2("NE TROGATI");
            //testCases.SetValue(5);
            //testCases.GetValue();
            //Console.WriteLine("___________________________");

            //Console.Read();

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
            //SetMethod.EnterText(driver, "Initial", "AutomationTester", "ID");
            //SetMethod.SelectDropDown(driver, "TitleId", "Mr.", "ID");
            //Console.WriteLine("The element from tex field is : " + GetMethod.GetText(driver, "Initial", "ID"));
            //Console.WriteLine("the value of dropdown is : " + GetMethod.GetValueDropDown(driver, "TitleId", "ID"));

            //SetMethod.ClickElement(driver, "Save", "Name");


            //dupa refactoring
            //SetMethod.EnterText("Initial", "AutomationTester",ElementProperty.Id);
            //SetMethod.SelectDropDown("TitleId", "Mr.", ElementProperty.Id);
            //Console.WriteLine("The element from tex field is : " + GetMethod.GetText("Initial", ElementProperty.Id));
            //Console.WriteLine("the value of dropdown is : " + GetMethod.GetValueDropDown("TitleId", ElementProperty.Id));

            //SetMethod.ClickElement("Save", ElementProperty.Name);

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








