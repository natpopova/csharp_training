﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAaddressbookTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;

        protected LoginHelper loginHelper;
        protected NavigateHelper navigator;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;


        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook/";

            loginHelper = new LoginHelper(this);
            navigator = new NavigateHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
        }

        public IWebDriver Driver 
        {
        get { return driver; }
        }

        public void Stop()
        {

            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public LoginHelper Auth {  get { return loginHelper; } }
        public NavigateHelper Navigate { get { return navigator; } }
        public GroupHelper GroupHelper { get { return groupHelper; } }
        public ContactHelper ContactHelper { get {return contactHelper; } }


    }
}