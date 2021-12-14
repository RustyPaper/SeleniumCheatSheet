using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumSpecTest
{
    class Program
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement textbox;
        static IWebElement button;
        static IAlert alert;
        static void Main()
        {
            string url = "https://www.youtube.com/";

            driver.Navigate().GoToUrl(url);

            alert = driver.SwitchTo().Alert();

            alert.Accept();

            textbox = driver.FindElement(By.Id("search"));

            textbox.SendKeys("Deep Focus Music");

            Thread.Sleep(3000);

            button = driver.FindElement(By.Id("search-icon-legacy"));

            button.Click();

            Thread.Sleep(3000);




            driver.Quit();
        }
    }
}
