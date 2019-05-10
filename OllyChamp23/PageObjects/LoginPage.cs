using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace OllyChamp23.PageObjects
{
    class LoginPage
    {
        //driver.FindElement(By.LinkText("Login"
        [FindsBy(How=How.LinkText,using="Login")]
            private OpenQA.Selenium.IWebElement Login;

    public void ClickLogin()

        login.Click();
    }
}
