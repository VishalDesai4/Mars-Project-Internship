using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_updated.Page
{
    public class LogIn
    {
        public void LogInActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            //launch mars portal and navigate to sign in
            driver.Navigate().GoToUrl("http://localhost:5000/");

            //identify signin button and click button
            IWebElement SignIn = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            SignIn.Click();

            //Identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            usernameTextbox.SendKeys("hkrocks92@gmail.com");

            //Identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("Hiya12345@");

            //identify log in button and click on the button
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();





















        }






    }
}
