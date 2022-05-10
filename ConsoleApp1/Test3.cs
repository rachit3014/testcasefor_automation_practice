using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Test;

namespace ConsoleApp1
{
    internal class Test3 : Library1
    {
        public void case3()
        {
            chrome("http://automationpractice.com/index.php");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
           
            time(2000);
            Findxpath("//a[@class='login']").Click();
            Findxpath("//input[@id='email_create']").SendKeys("tr@gail.com");
            time(2000);
            Findxpath("//button[@id='SubmitCreate']").Click();

            time(2000);
            js.ExecuteScript("window.scrollBy(0,900)");

            Findxpath("//button[@id='submitAccount']").Click();
            time(3000);
            quit();
        }
    }
}
