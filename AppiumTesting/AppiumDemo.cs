using NUnit.Framework;
using System;
using System.Drawing.Imaging;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;



namespace AppiumTesting
{
    [TestFixture]
    public class Tests
    {

        AppiumDriver<AndroidElement> driver;


        
        
        /*public void BeforeAll()
        {
            
        }*/

        
        /*public void AfterAll()
        { 
            driver.Quit();
        }*/


        [Test]
        public void TestNotesApp()
        {
            DesiredCapabilities cap = new DesiredCapabilities();
            cap.SetCapability("platformName", "Android");
            cap.SetCapability("deviceName", "pixel");
            cap.SetCapability("platformVersion", "8.0");
            // cap.SetCapability("udid", "358240051111110");
            cap.SetCapability("noReset", "True");
            cap.SetCapability("adbExecTimeout", "100000");
            cap.SetCapability("app", "C:/Users/symayers/source/repos/Notes/Notes/Notes.Android/bin/Debug/com.companyname.Notes.apk");
            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
            //driver.FindElementByClassName("android.widget.EditText");
            AndroidElement editElement = driver.FindElementByClassName("android.widget.EditText");
            editElement.SendKeys("New Notes");
            AndroidElement saveElement = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup[1]/android.widget.Button");
            saveElement.Click();
            AndroidElement deleteElement = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup[2]/android.widget.Button");
            deleteElement.Click();
            driver.Quit();
        }
        
    

       
    }
}