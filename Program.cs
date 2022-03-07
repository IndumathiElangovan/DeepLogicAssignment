using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace Test.Selenium;

public class Testclass {
    public static IWebDriver driver;
        [Test]
        
        public void CreateBugInJira()
        {
           
            driver =new ChromeDriver(@"C:\Users\Deepak.Jaganathan\Downloads\chromedriver_win32");
            // This will open up the URL
            driver.Url = "https://induelangovan.atlassian.net/jira/";            
            driver.FindElement(By.Id("username")).SendKeys("xxxxxxx@gmail.com");
            driver.FindElement(By.Id("login-submit")).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Id("password")).SendKeys("xxxxxxx");
            driver.FindElement(By.Id("login-submit")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("createGlobalItem")).Click();
                        System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("summary-field")).SendKeys("TEST");
            driver.FindElement(By.ClassName("ProseMirror-trailingBreak")).SendKeys("TEST");
            driver.FindElement(By.XPath("//*[@id='issue-create-modal-dropzone-container']/div[2]/div/div")).Click();     
            driver.FindElement(By.XPath("//*[@id='issue-create-modal-dropzone-container']/div[2]/div/div/div[2]")).Click(); 
                    System.Threading.Thread.Sleep(3000);    
            driver.FindElement(By.XPath("//button[contains(@type,'submit')]")).Submit();
                    System.Threading.Thread.Sleep(10000);  
            driver.Close();

        }
    
        

    }