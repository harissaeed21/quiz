using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.WaitHelpers;



namespace quiz
{
    public class GeneralMethod
    {
        public static IWebDriver driver;

        public GeneralMethod()
        {
            driver = null;
        }
        public void BrowserMethod(string browserName)
        {
            if (browserName.Equals("chrome", StringComparison.CurrentCultureIgnoreCase))
            {
                driver = new ChromeDriver();
            }
            else if (browserName.Equals("firefox", StringComparison.CurrentCultureIgnoreCase))
            {
                driver = new FirefoxDriver();
            }
        }
        public void BrowserUrl(string u)
        {
            driver.Url = u;
            driver.Manage().Window.Maximize();

        }
        public IWebElement FindLocator(By path)
        {
            return driver.FindElement(path);
        }
        public void clickItems(By path)
        {
            IWebElement clickItem = FindLocator(path);
            clickItem.Click();
        }
        public void sendData(By path, string transfer)
        {
            IWebElement my = FindLocator(path);
            my.SendKeys(transfer);
        }

        public void dropDrown(By locate, string byValue)
        {
            IWebElement mydropdown= FindLocator(locate);
            SelectElement mydrop= new SelectElement(mydropdown);
            mydrop.SelectByValue(byValue);  
        }

      //public void scrollElement(By path )
      //{
      //     IJavaScriptExecutor scrolling = (IJavaScriptExecutor)driver;
      //    IWebElement element = ExplicitWaitForElement(path);
      //     scrolling.ExecuteScript("arguments[0].scrollIntoView(true);", element);

      // }

    }
}
