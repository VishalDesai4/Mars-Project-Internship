using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ProjectMars.Utilities
{
    public class Commondriver
    {
        public IWebDriver driver;

        [BeforeScenario]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
        [AfterScenario]
        public void QuitDriver()
        {
            driver.Quit();

        }










    }
}
