using System;
using Xunit;
using OpenQA.Selenium.Safari;
using System.Threading;
using OpenQA.Selenium;

namespace CicekSepetiSeleniumCaseExample
{
    public class FailLogin
    {
        [Fact]
        public void FailLogin_MailAddress()
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
            emailBox.SendKeys("test@test.com");

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
            var failLoginRemark = safariDriver.FindElementByXPath("//*[@id='modalBox']/div/div/div[3]/button");
            
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
        public void FailLogin_Password()
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
            emailBox.SendKeys("testuser@testuser.com");

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
            var failLoginRemark = safariDriver.FindElementByXPath("//*[@id='modalBox']/div/div/div[3]/button");

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
