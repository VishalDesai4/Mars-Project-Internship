using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Mars_updated.Page;

public class Profile
{
    private object webDriver;

    //add skills to profile

    private IWebElement SkillTab => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
    private IWebElement AddSkillButton => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
    private IWebElement writeSkill => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
    private IWebElement ClickDropDown => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
    private IWebElement BegginerLevel => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
    private IWebElement IntermediateLevel => webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
    private IWebElement ExpertLevel => > webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
    public void ClickSkill
    {
        SkillTab.Click(); 

    }
}
    public void AddSkillTab
    {

    AddSkillButton.Click();

    }
    public void SkillTextBox(string Skill);
    {

    writeSkill.Sendkeys(Skill);

    }
    public void ClickDrop
    {
      ClickDropDown.Click();

    }
    public void ClickBegginerLevel
    {
    BegginerLevel.Click
    }
    public void IntermedialLevelClick
    {
    IntermediateLevel.Click();

    }
    public void ClickExpert
    {
    ExpertLevel.Click();
    }
    public void AddSkill
    {
     AddkillButton
    }
    public void AddSkils(IWebdriver driver, String Skill, String level);

    {
      public void AddSkillTab
      public void SkillTextBox(Skill);
      public void ClickDrop

    }
      if (Level == "Beginner")
    {
    AddLevelBeginner();

}
      }
      if (Level == "Intermediate")
{
    AddLevelIntermediate();

}
      }
      if (Level == "Expert")
{
    AddLevelExpert();


}
      AddSkillTab()
    Thread.Sleep(1000);
    Driver.Manage().Timeouts.ImplicitWait = TimeSpan.FromSeconds(30);

