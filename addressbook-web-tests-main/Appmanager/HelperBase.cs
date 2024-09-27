using OpenQA.Selenium;

namespace WebAaddressbookTests
{
    public class HelperBase
    {
        public IWebDriver driver;

        public HelperBase(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}