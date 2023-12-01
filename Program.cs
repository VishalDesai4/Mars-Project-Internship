using ProjectMars.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    private static void Main(string[] args)
    {
        // Open the browser
        IWebDriver driver = new ChromeDriver();

        // log in page object initialization

        LogIn loginPageObj = new LogIn();
        loginPageObj.LogInActions(driver);



    }
}