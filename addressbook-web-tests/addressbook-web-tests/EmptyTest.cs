﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class EmptyTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void TestMethod1()
        {
        }
    }
}