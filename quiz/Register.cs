using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace quiz
{
    public class Register : GeneralMethod
    {
        By LinkSignUp = By.LinkText("Signup / Login");
        By name = By.XPath("//input[@placeholder='Name']");
        By mail = By.XPath("/html/body/section/div/div/div[3]/div/form/input[3]");
        By btnSign = By.XPath("//button[text()='Signup']");
        By genderMR = By.Id("id_gender1");
        By passReg = By.Id("password");
        By day = By.Id("days");
        By month = By.Id("months");
        By year = By.Id("years");
        By firstName= By.Id("first_name");
        By lastName = By.Id("last_name");
        By country = By.Id("company");
        By address = By.Id("address1");
        By country1 = By.Id("country");
        By state=By.Id("state");
        By city = By.Id("city");
        By zipcode = By.Id("zipcode");
        By mobile = By.Id("mobile_number");
        By create = By.XPath("//button[text()='Create Account']");








        public void linkSign(string fname, string gmail, string password, string firstNam , string lastnam, string count, string addr,
       string stat, string cit, string zcode, string mob   
            
            
            )
        {
            clickItems(LinkSignUp);
            sendData(name, fname);
            sendData(mail, gmail);
            clickItems(btnSign);
            clickItems(genderMR);
            sendData(passReg, password);
            clickItems(day);
            dropDrown(day, "15");
            Thread.Sleep(3000);
            clickItems(month);
            dropDrown(month, "4");
            clickItems(year);
            dropDrown(year, "1997");
            sendData(firstName,firstNam );
            sendData(lastName, lastnam );
            sendData(country, count);
                sendData(address, addr);
            clickItems(country1);
            dropDrown(country1, "Australia");
            Thread.Sleep(3000);
            sendData(state, stat);
            sendData(city , cit);
            sendData(zipcode, zcode);
            sendData(mobile, mob);
            clickItems(create);


        }

    }













}
