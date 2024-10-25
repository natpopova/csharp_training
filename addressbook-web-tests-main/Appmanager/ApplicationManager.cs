using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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

        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>(); 
        //это спец объект, который устанавливает соответствие м/д потоком и объетом типа апп.менеджер

        private ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost:8080/addressbook/";

            loginHelper = new LoginHelper(this);
            navigator = new NavigateHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
        }

        //деструктор - вызывается автоматически, обратиться к нельзя 

         ~ApplicationManager()
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

        //Singleton
        public static ApplicationManager GetInstance() 
        { 
            if (! app.IsValueCreated)
            {
                ApplicationManager newInstanse = new ApplicationManager();
                newInstanse.Navigate.OpenHomePage();
                app.Value = newInstanse;
            }
            return app.Value;
        }

        
        public IWebDriver Driver 
        {
        get { return driver; }
        }


        public LoginHelper Auth {  get { return loginHelper; } }
        public NavigateHelper Navigate { get { return navigator; } }
        public GroupHelper GroupHelper { get { return groupHelper; } }
        public ContactHelper ContactHelper { get {return contactHelper; } }


    }
}
