using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Test;

namespace Testcase_1
{
    internal class Test1 : Library1
    {
        public void  case1()
        {
            
            chrome("http://automationpractice.com/index.php");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            
            time(2000);
            Findxpath("//a[@class='login']").Click();
            Findxpath("//input[@id='email_create']").SendKeys("ltgtt@vusra.com");
            time(2000);
            Findxpath("//button[@id='SubmitCreate']").Click();
            time(3000);
            IWebElement female = Findxpath("//input[@id='id_gender2']");
            js.ExecuteScript("arguments[0].click()", female);
            time(2000);
            IWebElement Male = Findxpath("//input[@id='id_gender1']");
            js.ExecuteScript("arguments[0].click()", Male);
            time(2000);
            Findxpath("//input[@id='customer_firstname']").SendKeys("REtg");
            time(2000);
            Findxpath("//input[@id='customer_lastname']").SendKeys("Kumar");
            time(2000);
            Findxpath("//input[@id='passwd']").SendKeys("1223@qwe");
            time(2000);
            Findxpath("//select[@id='days']").Click();
            time(2000);
            Findxpath("//select[@id='days']//option[17]").Click();

            time(2000);
            Findxpath("//select[@id='days']").Click();
            time(3000);
            Findxpath("//select[@id='months']//option[3]").Click();
            time(2000);
            Findxpath("//select[@id='years']").Click();
            time(2000);
            Findxpath("//select[@id='years']//option[10]").Click();
            time(2000);
            Findxpath("//input[@id='newsletter']").Click();
            time(2000);
            Findxpath("//input[@id='optin']").Click();
            time(2000);
            Findxpath("//input[@id='company']").SendKeys("gutsdfhjgsd");
            time(2000);
            Findxpath("//input[@id='address1']").SendKeys("pass road");
            time(2000);
            Findxpath("//input[@id='city']").SendKeys("Los Angeles");
            time(2000);
            Findxpath("//div[@id='uniform-id_state']").Click();
            Findxpath("//select[@id='id_state']//option[6]").Click();
            time(2000);
            Findxpath("//input[@id='postcode']").SendKeys("90001");
            time(2000);
            Findxpath("//textarea[@id='other']").SendKeys("Hello!");
            time(2000);
            Findxpath("//input[@id='phone_mobile']").SendKeys("789654210");
            time(2000);
            Findxpath("//button[@id='submitAccount']").Click();
            time(3000);
            quit();
        }
    }
}
