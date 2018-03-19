using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinuxApp_Test
{
    class PageProperties
    {

        public PageProperties()
        {
            PageFactory.InitElements(Utilities.driver, this);
        }

        [FindsBy(How =How.Name,Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement lsTitle { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }
        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        public void PagePropertiesAction(string initial, string firstName, string midleName)
        {
            
            txtInitial.SendKeys(initial);

            txtFirstName.SendKeys(firstName);

            txtMiddleName.SendKeys(midleName);

            btnSave.Click();
        }
    }
}

