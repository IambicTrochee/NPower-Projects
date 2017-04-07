using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IAlert alert;

    static void Main()
    {
        string url = "http://testing.todorvachev.com/special-elements/alert-box/";
        
        driver.Navigate().GoToUrl(url);

        alert = driver.SwitchTo().Alert();
        Console.WriteLine(alert.Text);
        alert.Accept();

        driver.Quit();
        Console.ReadLine();
    }

    private static void RedMesssage(string v)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(v);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string v)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(v);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
