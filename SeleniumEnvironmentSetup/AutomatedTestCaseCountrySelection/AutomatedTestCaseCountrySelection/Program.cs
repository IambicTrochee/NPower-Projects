using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();

        //Opens URL
        driver.Navigate().GoToUrl("http://opensource.demo.orangehrmlive.com/");

        //Enters the username
        IWebElement username = driver.FindElement(By.Name("txtUsername"));
        username.SendKeys("john.smith");

        //Enters the password
        IWebElement password = driver.FindElement(By.Name("txtPassword"));
        password.SendKeys("john.smith");

        //Clicks login button
        driver.FindElement(By.Id("btnLogin")).Click();

        //Click 'My Info'
        driver.FindElement(By.CssSelector("#menu_pim_viewMyDetails > b")).Click();

        //Click 'Contact Details'
        driver.FindElement(By.CssSelector("#sidenav > li:nth-child(2) > a")).Click();

        //Click 'Edit'
        driver.FindElement(By.Id("btnSave")).Click();

        //Find the 'Country' dropdown menu and set it to the variable dropdownCountry
        IWebElement dropdownCountry = driver.FindElement(By.Name("contact[country]"));

        //Selects 'United States' from the dropdown menu
        dropdownCountry.SendKeys("United States");

        //Saves changes
        driver.FindElement(By.Id("btnSave")).Click();

        Thread.Sleep(3000);
        
        driver.Quit();
    }
}