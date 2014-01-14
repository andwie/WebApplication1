using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace When_clicking_button
{
    [TestFixture]
    public class When_clicking_button
    {
        private IWebDriver driver;
        

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        [Category("CITest")]
        public void Should_say_good_things_about_qa()
        {
            driver.Navigate().GoToUrl("http://localhost/abcc/WebForm1.aspx");
            driver.FindElement(By.Id("Button1")).Click();
            NUnit.Framework.Assert.AreEqual(driver.FindElement(By.Id("Label1")).Text, "QA Rules!!!");
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
