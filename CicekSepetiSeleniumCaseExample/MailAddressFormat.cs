using System;
using Xunit;
using OpenQA.Selenium.Safari;
using System.Threading;
using OpenQA.Selenium;

namespace CicekSepetiSeleniumCaseExample
{
    public class MailAddressFormat
    {
        [Fact]
        public void WithoutAtCharOnMailAddress()
        {
            //For Mac Inıtialize the Safari Driver
            SafariDriver safariDriver = new SafariDriver();

            // Maximize the browser
            safariDriver.Manage().Window.Maximize();

            // Go to the "Lolaflora" login page
            safariDriver.Navigate().GoToUrl("https://www.lolaflora.com/en-es/login");

            // Find the email/username textbox (by ID) on the login page
            var emailBox = safariDriver.FindElementById("EmailLogin");

            // Enter the mail adress for login
            emailBox.SendKeys("testusertestuser.com");

            // Find the password (by ID) on the login page
            var passwordBox = safariDriver.FindElementById("Password");

            // Enter the password for login
            passwordBox.SendKeys("123654789");

            // Find the search button (by Name) on the homepage
            var signIn = safariDriver.FindElementByXPath("//*[@id='userLogin']/div[6]/button");

            // Click "Submit" to start the search
            signIn.SendKeys(Keys.Return);

            try
            {
                Thread.Sleep(2000);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Exception:" + e);
            }

            //Find an element on page after login
            var failLoginRemark = safariDriver.FindElementByXPath("//*[@id='userLogin']/div[2]/span[1]");
            try
            {
                Thread.Sleep(2000);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Exception:" + e);
            }

            //testuser@testuser.com
            //123654789

        
            safariDriver.Dispose();

        }

        [Fact]
        public void WrongChar()
        {
            //For Mac Inıtialize the Safari Driver
            SafariDriver safariDriver = new SafariDriver();

            // Maximize the browser
            safariDriver.Manage().Window.Maximize();

            // Go to the "Lolaflora" login page
            safariDriver.Navigate().GoToUrl("https://www.lolaflora.com/en-es/login");

            // Find the email/username textbox (by ID) on the login page
            var emailBox = safariDriver.FindElementById("EmailLogin");

            String [] wrongChar = { "!", ":", "?", ";", ",", "'", "%", "&", "/", "<", ">", "(", ")", "[", "]", "{", "}", "*"};

            Random random = new Random();
            int rand = random.Next(0,wrongChar.Length-1);

            // Enter the mail adress for login
            emailBox.SendKeys("testuser@testuser.com" + wrongChar[rand]);

            // Find the password (by ID) on the login page
            var passwordBox = safariDriver.FindElementById("Password");

            // Enter the password for login
            passwordBox.SendKeys("123456789");

            // Find the search button (by Name) on the homepage
            var signIn = safariDriver.FindElementByXPath("//*[@id='userLogin']/div[6]/button");

            // Click "Submit" to start the search
            signIn.SendKeys(Keys.Return);

            try
            {
                Thread.Sleep(2000);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Exception:" + e);
            }

            //Find an element on page after login
            var failLoginRemark = safariDriver.FindElementByXPath("//*[@id='userLogin']/div[2]/span[1]");

            try
            {
                Thread.Sleep(2000);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Exception:" + e);
            }

            //testuser@testuser.com
            //123654789

            safariDriver.Dispose();

        }

        [Fact]
        public void TurkishChar()
        {
            //For Mac Inıtialize the Safari Driver
            SafariDriver safariDriver = new SafariDriver();

            // Maximize the browser
            safariDriver.Manage().Window.Maximize();

            // Go to the "Lolaflora" login page
            safariDriver.Navigate().GoToUrl("https://www.lolaflora.com/en-es/login");

            // Find the email/username textbox (by ID) on the login page
            var emailBox = safariDriver.FindElementById("EmailLogin");

            String[] turkishChar = { "ğ", "ü", "ş", "ı", "ö", "ç"};

            Random random = new Random();
            int rand = random.Next(0, turkishChar.Length - 1);

            // Enter the mail adress for login
            emailBox.SendKeys("testuser@testuser.com" + turkishChar[rand]);

            // Find the password (by ID) on the login page
            var passwordBox = safariDriver.FindElementById("Password");

            // Enter the password for login
            passwordBox.SendKeys("123456789");

            // Find the search button (by Name) on the homepage
            var signIn = safariDriver.FindElementByXPath("//*[@id='userLogin']/div[6]/button");

            // Click "Submit" to start the search
            signIn.SendKeys(Keys.Return);

            try
            {
                Thread.Sleep(2000);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Exception:" + e);
            }

            //Find an element on page after login
            var failLoginRemark = safariDriver.FindElementByXPath("//*[@id='userLogin']/div[2]/span[1]");

            try
            {
                Thread.Sleep(2000);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Exception:" + e);
            }

            //testuser@testuser.com
            //123654789

            safariDriver.Dispose();

        }
    }
}
