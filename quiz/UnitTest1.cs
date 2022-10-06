using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace quiz
{

    [TestClass]
    [TestCategory ("user Register")]
    public class UnitTest1
    {
        private TestContext instance;
        public TestContext TestContext
        {
            get { return instance; }
            set { instance = value; }
        }
        string browser_name = "firefox";
        string url = "https://automationexercise.com/";

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "F:\\contour bootcamp\\Selenium\\quiz\\quiz\\testdata.xml", "register", DataAccessMethod.Sequential)]
        public void SignUp()
        {


           string fName = TestContext.DataRow["fullname"].ToString();
          
            string Gmail= TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            string first = TestContext.DataRow["first"].ToString();
            string last = TestContext.DataRow["last"].ToString();
            string count = TestContext.DataRow["country"].ToString();
            string addr = TestContext.DataRow["address"].ToString();
            string state = TestContext.DataRow["state"].ToString();
            string city = TestContext.DataRow["city"].ToString();
            string zipcode = TestContext.DataRow["zipcode"].ToString();
            string mobile = TestContext.DataRow["mobile"].ToString();


            Register reg = new Register();
            reg.BrowserMethod(browser_name);
            reg.BrowserUrl(url);
           reg.linkSign(fName, Gmail, pass, first, last, count, addr, state, city, zipcode, mobile);

        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "F:\\contour bootcamp\\Selenium\\quiz\\quiz\\testdata.xml", "login", DataAccessMethod.Sequential)]
        public void login()
        {

          
          

            string email = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();

            login log= new login();
            log.BrowserMethod(browser_name);
            log.BrowserUrl(url);
            log.linksign(email, password);
        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "F:\\contour bootcamp\\Selenium\\quiz\\quiz\\testdata.xml", "login", DataAccessMethod.Sequential)]
        public void logout()
        {
            string email = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();

            logout log = new logout();
            log.BrowserMethod(browser_name);
            log.BrowserUrl(url);
            log.linksign(email, password);
        }

    }
}
