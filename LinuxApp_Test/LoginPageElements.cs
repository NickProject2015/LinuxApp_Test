using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinuxApp_Test
{
    class LoginPageElements
    {
        public LoginPageElements()
        {
            PageFactory.InitElements(Utilities.driver, this);
        }

        [FindsBy(How = How.Name,Using ="UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public PageProperties Login(string UserName, string Password)
        {
            
            txtUserName.SendKeys(UserName);
            txtPassword.SendKeys(Password);
            btnLogin.Submit();
            return new PageProperties();
        }
    }
}