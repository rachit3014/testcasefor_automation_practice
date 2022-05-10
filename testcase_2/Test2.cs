using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Test;

namespace testcase_2
{
    internal class Test2 : Library1
    {
        public void case2()
        {
         
            chrome("http://automationpractice.com/index.php");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            
            time(2000);
            Findxpath("//a[@class='login']").Click();
            Findxpath("//input[@id='email_create']").SendKeys("hfej@.com");
            time(2000);
            Findxpath("//button[@id='SubmitCreate']").Click();
            time(3000);
            quit();
        }
    }
}
