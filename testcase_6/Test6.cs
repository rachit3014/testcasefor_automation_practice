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
namespace testcase_6
{
    internal class Test6 : Library1
    {
      public void case6()
        {

            chrome("http://automationpractice.com/index.php");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            
            time(2000);
            Findxpath("//a[@class='login']").Click();
            time(2000);
            Findxpath("//input[@id='email']").SendKeys("cehirik269@topyte.com");
            time(2000);
            Findxpath("//input[@id='passwd']").SendKeys("1223@qwe");
            time(2000);
            Findxpath("//button[@id='SubmitLogin']").Click();
            //time(2000);
            Findxpath("//a[@title='Women']").Click();
            time(5000);
            IWebElement Tshirt = Findxpath("//a[@title='Women']");



            Tshirt.Click();
            Actions action = new Actions(Driver);
            action.MoveToElement(Findxpath("//a[@title='Women']"))
                .KeyDown(Keys.Down)
            .Click()
            .Perform();
            time(2000);
            js.ExecuteScript("window.scrollBy(0,800)");

            IWebElement hj = Driver.FindElements(By.XPath("//img[@class='replace-2x img-responsive']"))[2];
            Actions actions1 = new Actions(Driver);
            actions1.MoveToElement(hj)
            .Perform();
            time(5000);
            //Findxpath("//img[@id='bigpic']")).Click();
            Driver.FindElements(By.XPath("//a[@title='View']"))[1].Click();
            time(2000);
            Findxpath("//i[@class='icon-plus']").Click();

            time(2000);
            IWebElement pro = Findxpath("//select[@id='group_1']");
            pro.Click();
            Actions actions = new Actions(Driver);

            actions.MoveToElement(Findxpath("//select[@id='group_1']"))
           .KeyDown(Keys.Down)
           .KeyDown(Keys.Down)
            .Click()
            .Perform();
            time(2000);
            Findxpath("//a[@title='White']").Click();
            time(2000);
            js.ExecuteScript("window.scrollBy(0,400)");
            time(2000);
            //IWebElement cart = Driver.FindElements(By.XPath("//button[@type='submit']"))[3];
            //js.ExecuteScript("arguments[0].click()", cart);
            Findxpath("//p[@id='add_to_cart']").Click();
            time(3000);
            Driver.FindElements(By.XPath("//i[@class='icon-chevron-right right']"))[1].Click();
            time(2000);
            Driver.FindElements(By.XPath("//i[@class='icon-chevron-right right']"))[2].Click();
            time(2000);
            js.ExecuteScript("window.scrollBy(0,400)");
            Driver.FindElements(By.XPath("//i[@class='icon-chevron-right right']"))[6].Click();
            time(2000);
            Findxpath("//input[@id='cgv']").Click();
            time(2000);
            js.ExecuteScript("window.scrollBy(0,400)");

            Driver.FindElements(By.XPath("//i[@class='icon-chevron-right right']"))[2].Click();
            time(2000);
            quit();
        }
    }
}
