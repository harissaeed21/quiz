using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace quiz
{
    public class login:GeneralMethod
    {
        By LinkSignUp = By.LinkText("Signup / Login");
        By username = By.XPath("/html/body/section/div/div/div[1]/div/form/input[2]");
        By loginPassword = By.XPath("/html/body/section/div/div/div[1]/div/form/input[3]");
        By loginbtn = By.XPath("//button[text()='Login']");
        By Deletebtn = By.LinkText("Delete Account");




        public void linksign(string userName, string password)
        {
            clickItems(LinkSignUp);
            sendData(username, userName);
            sendData(loginPassword, password);
            clickItems(loginbtn);
           // clickItems(Deletebtn);
        }



    }
}
