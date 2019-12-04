using System;
using Xunit;
using OpenQA.Selenium.Safari;
using System.Threading;
using OpenQA.Selenium;

namespace CicekSepetiSeleniumCaseExample
{
    public class SuccessLogin
    {
        [Fact]
        public void SuccessLoginSc1()
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
            passwordBox.SendKeys("123654789");

            try{
                Thread.Sleep(1000);
            }
            catch (NullReferenceException e) {
                Console.WriteLine("Exception:" + e);
            }

            // Find the search button (by Name) on the homepage
            var signIn = safariDriver.FindElementByXPath("//*[@id='userLogin']/div[6]/button");

            // Click "Submit" to start the search
            signIn.SendKeys(Keys.Return);

            try
            {
                Thread.Sleep(3000);
            }
            catch (NullReferenceException e){
                Console.WriteLine("Exception:" + e);
            }

            //Find an element on page after login
            var successLoginRemark = safariDriver.FindElementByXPath("/html/body/div[2]/div[2]/div/div[2]/div[2]/nav/ul/li[3]");

            try
            {
                Thread.Sleep(5000);
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
        public void SuccessLoginCapital()
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
            emailBox.SendKeys("TESTUSER@TESTUSER.COM");

            // Find the password (by ID) on the login page
            var passwordBox = safariDriver.FindElementById("Password");

            // Enter the password for login
            passwordBox.SendKeys("123654789");

            try
            {
                Thread.Sleep(1000);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Exception:" + e);
            }

            // Find the search button (by Name) on the homepage
            var signIn = safariDriver.FindElementByXPath("//*[@id='userLogin']/div[6]/button");

            // Click "Submit" to start the search
            signIn.SendKeys(Keys.Return);

            try
            {
                Thread.Sleep(3000);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Exception:" + e);
            }

            //Find an element on page after login
            var successLoginRemark = safariDriver.FindElementByXPath("/html/body/div[2]/div[2]/div/div[2]/div[2]/nav/ul/li[3]");

            try
            {
                Thread.Sleep(5000);
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
