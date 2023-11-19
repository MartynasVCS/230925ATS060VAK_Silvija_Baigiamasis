﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Framework
{
    public class Driver
    {
        static IWebDriver driver;

        public static void  InitializeDriver()
        {
            driver = new ChromeDriver();
        }

        internal static IWebDriver GetDriver()
        {
            return driver;
        }

        internal static void OpenPage(string url)
        {
            driver.Url = url;
        }
        public static string GetLoginTitle()
        {
            return driver.Title;
        }

        public static void QuitDriver()
        {
            driver.Quit();
        }
    }
}
