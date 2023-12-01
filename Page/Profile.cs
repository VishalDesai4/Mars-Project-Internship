using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_updated.Page
{
    public class Profile
    {
        //Navigation between Languages and Skills tab

        private IWebElement languageTab => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        private IWebElement skillTab => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));

        IWebDriver webDriver;
        public Profile(IWebDriver driver)
        {
            webDriver = driver;

        }
        public void ClickLanguagesTab()
        {

            languageTab.Click();

        }
        public void ClickSkillTab()
        {

            skillTab.Click();

        }
        public void GoToLanguageTab()
        {
            ClickLanguagesTab();
        }
        public void GoToSkillsTab()
        {
            ClickSkillTab();
        }
        //Add Language in Languages Tab

        private IWebElement addNewButton => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        public void ClickAddNewButton()
        {
            addNewButton.Click();

        }

        private IWebElement languageTextBox => webDriver.FindElement(By.Name("name"));
        public void AddLanguage(string language)
        {
            languageTextBox.SendKeys(language);
        }
        private IWebElement langDropdown => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
        public void ClickLevelDropdown()
        {
            langDropdown.Click();
        }
        private IWebElement langLevelBasic => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
        public void AddLevelBasic()
        {

            langLevelBasic.Click();
        }
        private IWebElement langLevelConversational => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
        public void AddLevelConversational()
        {

            langLevelConversational.Click();
        }
        private IWebElement langLevelFluent => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
        public void AddLevelFluent()
        {

            langLevelFluent.Click();
        }

        private IWebElement langLevelBilingual => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[5]"));
        public void AddLevelBilingual()
        {

            langLevelBilingual.Click();
        }

        private IWebElement addButton => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        public void ClickAddButton()
        {

            addButton.Click();

        }
        public void AddLanguage(IWebDriver driver, String language, String level)
        {


            ClickAddNewButton();

            AddLanguage(language);

            ClickLevelDropdown();

            if (level == "Basic")
            {

                AddLevelBasic();
            }
            if (level == "Conversational")
            {
                AddLevelConversational();
            }
            if (level == "Fluent")
            {
                AddLevelFluent();
            }
            if (level == "Native/Bilingual")
            {
                AddLevelBilingual();
            }

            ClickAddButton();
            Thread.Sleep(1000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }






    }
}
