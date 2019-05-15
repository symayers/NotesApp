/* Microsoft provides programming examples for illustration only, without warranty either expressed or
 implied, including, but not limited to, the implied warranties of merchantability and/or fitness
 for a particular purpose.

 This sample assumes that you are familiar with the programming language being demonstrated and the
 tools used to create and debug procedures. Microsoft support professionals can help explain the
 functionality of a particular procedure, but they will not modify these examples to provide added
 functionality or construct procedures to meet your specific needs. if you have limited programming
 experience, you may want to contact a Microsoft Certified Partner or the Microsoft fee-based consulting
 line at (800) 936-5200.*/


using NUnit.Framework;
using System;
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


        [Test]
        public void TestNotesApp()
        {
            DesiredCapabilities cap = new DesiredCapabilities();
            cap.SetCapability("platformName", "Android");
            cap.SetCapability("deviceName", "pixel2");
            cap.SetCapability("platformVersion", "8.1");
            cap.SetCapability("noReset", "True");
            cap.SetCapability("adbExecTimeout", "1000000");
            //cap.SetCapability("automationName", "UiAutomator2");
            cap.SetCapability("app", "C:/Users/symayers/source/repos/Notes/Notes/Notes.Android/bin/Debug/com.companyname.Notes.apk");
            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
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