using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinuxApp_Test
{
    enum ElementProperty
    {

        Id,
        Name,
        ClassName,
        CssName

    }
    class Utilities
    {
       
        public static IWebDriver driver { get; set; }
    }
    static class WaitProperties
    {
        public static void ImplicitWait(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
    }
    static class TakeScreenShotClass
    {
        public static void TestScreenShot(IWebDriver driver)
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("E:\\LinuxApp_Test\\ScreenShots\\" + "snapshot" + "_" + DateTime.Now.ToString("dd_MMMM_hh_mm_ss_tt") + ".png");
        }
    }
    ////TODO: Check the method
    //static class CheckDisplayElementClass
    //{
    //    public static bool CheckDisplayElement(IWebElement element)
    //    {
    //        try
    //        {
    //            return element.Displayed{};
    //        }
    //        catch (Exception)
    //        {

    //            throw;
    //        }
    //    }
    //}
}



