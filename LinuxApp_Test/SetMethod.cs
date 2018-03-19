using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinuxApp_Test
{
    class SetMethod
    {
        //Enter text in text field
        //public static void EnterText(IWebDriver driver, string element, string valueElement, string typeElement)
        //{
        //    if (typeElement == "ID")
        //        driver.FindElement(By.Id(element)).SendKeys(valueElement);
        //    if (typeElement == "Name")
        //        driver.FindElement(By.Name(element)).SendKeys(valueElement);

        //}
        //public static void ClickElement(IWebDriver driver, string element, string typeElement)
        //{
        //    if (typeElement == "ID")
        //        driver.FindElement(By.Id(element)).Click();
        //    if (typeElement == "Name")
        //        driver.FindElement(By.Name(element)).Click();
        //}
        ////Select from dropdown
        //public static void SelectDropDown(IWebDriver driver, string element, string valueElement, string typeElement)
        //{
        //    if (typeElement == "ID")
        //        new SelectElement(driver.FindElement(By.Id(element))).SelectByText(valueElement);
        //    if (typeElement == "Name")
        //        new SelectElement(driver.FindElement(By.Name(element))).SelectByText(valueElement);

        //}
        public static void EnterText(string element, string valueElement, ElementProperty typeElement)
        {
            if (typeElement == ElementProperty.Id)
                Utilities.driver.FindElement(By.Id(element)).SendKeys(valueElement);
            if (typeElement == ElementProperty.Name)
                Utilities.driver.FindElement(By.Name(element)).SendKeys(valueElement);

        }
        public static void ClickElement(string element, ElementProperty typeElement)
        {
            if (typeElement == ElementProperty.Id)
                Utilities.driver.FindElement(By.Id(element)).Click();
            if (typeElement == ElementProperty.Name)
                Utilities.driver.FindElement(By.Name(element)).Click();
        }
        //Select from dropdown
        public static void SelectDropDown(string element, string valueElement, ElementProperty typeElement)
        {
            if (typeElement == ElementProperty.Id)
                new SelectElement(Utilities.driver.FindElement(By.Id(element))).SelectByText(valueElement);
            if (typeElement == ElementProperty.Name)
                new SelectElement(Utilities.driver.FindElement(By.Name(element))).SelectByText(valueElement);

        }

    }
}
