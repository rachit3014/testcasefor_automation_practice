using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Test;
namespace testcase_5
{
    internal class Test5 : Library1
    {
        public void case5()
        {
            chrome("http://automationpractice.com/index.php");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            time(2000);
            Findxpath("//a[@title='Women']").Click();
            time(5000);
            IWebElement Tshirt = Findxpath("//a[@title='Women']");



            Tshirt.Click();
            Actions action = new Actions(Driver);
            action.MoveToElement(Findxpath("//a[@title='Women']"))
                .KeyDown(Keys.Down)
            .Click()
            .Perform();

            js.ExecuteScript("arguments[0].click()", Tshirt);
            time(5000);
            //incompltete
            quit();
        }
    }
}
