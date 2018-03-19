using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinuxApp_Test
{
    class GetMethod
    {
        //public static string GetText(IWebDriver driver, string element, string typeElement)
        //{
        //    if (typeElement == "ID")
        //        return driver.FindElement(By.Id(element)).GetAttribute("value");
        //    if (typeElement == "Name")
        //        return driver.FindElement(By.Name(element)).GetAttribute("value");
        //    else return String.Empty;
        //}
        //public static string GetValueDropDown(IWebDriver driver, string element, string typeElement)
        //{
        //    if (typeElement == "ID")
        //        return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
        //    if (typeElement == "Name")
        //        return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
        //    else return String.Empty;
        //}
        public static string GetText(string element, ElementProperty typeElement)
        {
            if (typeElement == ElementProperty.Id)
                return Utilities.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (typeElement == ElementProperty.Name)
                return Utilities.driver.FindElement(By.Name(element)).GetAttribute("value");
            else return String.Empty;
        }
        public static string GetValueDropDown(string element, ElementProperty typeElement)
        {
            if (typeElement == ElementProperty.Id)
                return new SelectElement(Utilities.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (typeElement == ElementProperty.Name)
                return new SelectElement(Utilities.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;
        }

    }
}
