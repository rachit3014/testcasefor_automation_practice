using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Test;

namespace test_case_4
{
    internal class Test4 : Library1
    {
       public void case4()
        {


            
            chrome("http://automationpractice.com/index.php");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
           
            
            Findxpath("//a[@class='login']").Click();
            Findxpath("//input[@id='email_create']").SendKeys("tr@gail.com");
            time(2000);
            Findxpath("//button[@id='SubmitCreate']").Click();
            time(3000);
            IWebElement female = Findxpath("//input[@id='id_gender2']");
            js.ExecuteScript("arguments[0].click()", female);
            time(2000);
            IWebElement Male = Findxpath("//input[@id='id_gender1']");
            js.ExecuteScript("arguments[0].click()", Male);
            time(2000);
            Findxpath("//input[@id='customer_firstname']").SendKeys("12345");
            time(2000);
            Findxpath("//input[@id='customer_lastname']").SendKeys("6789");
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
            Findxpath("//input[@id='company']").SendKeys("789455655");
            time(2000);
            Findxpath("//input[@id='address1']").SendKeys("654841545");
            time(2000);
            Findxpath("//input[@id='city']").SendKeys("67869745");
            Findxpath("//div[@id='uniform-id_state']").Click();
            Findxpath("//select[@id='id_state']//option[6]").Click();
            time(2000);
            Findxpath("//input[@id='postcode']").SendKeys("iolhkiuh");
            time(2000);
            Findxpath("//textarea[@id='other']").SendKeys("Hello!");
            time(2000);
            Findxpath("//input[@id='phone_mobile']").SendKeys("trdtre");
            time(2000);

            // js.ExecuteScript("window.scrollBy(0,900)");

            Findxpath("//button[@id='submitAccount']").Click();
            time(3000);
            quit();
        }
    }
}
