using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Reflection;
using System.Threading;
using OpenQA.Selenium.Safari;
using System.Web;


namespace SeleniumFacebook
{
    public class FacebookLoginSelenium
    {
       public static void Main(string[] args)
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            Thread.Sleep(3000);
            var cookies = driver.Manage().Cookies.AllCookies;
            var Cookies = driver.FindElement(By.XPath("//button[@class='_42ft _4jy0 _9xo7 _4jy3 _4jy1 selected _51sy']"));
            Cookies.Click();

            var login = driver.FindElement(By.Id("email"));
            login.SendKeys("ExampleEmail@x.com");
            var PW = driver.FindElement(By.Id("pass"));
            PW.SendKeys("yourpassword");
            var Signin = driver.FindElement(By.XPath("//button[@class='_42ft _4jy0 _6lth _4jy6 _4jy1 selected _51sy']"));
            Signin.Click();

            var test2 = driver.FindElement(By.XPath("//p[contains(text(), 'Komentarz ')]/span")).GetAttribute("innerText");
            Console.WriteLine(test2);

            Console.ReadKey();

            Thread.Sleep(3000);
            driver.Quit();


        }
    }
}
