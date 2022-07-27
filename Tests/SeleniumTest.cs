using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumUITests
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TU01()
        {
            IWebElement BotonCoca;
            IWebElement BotonPepsi;
            IWebElement BotonFanta;
            IWebElement BotonSprite;
            IWebElement MontoTotal;

            // Arrange
            string URL = "https://localhost:44337/";
            driver.Manage().Window.Maximize();
            driver.Url = URL;

            //Act
            Thread.Sleep(2000);
            BotonCoca = driver.FindElement(By.CssSelector("#banner > div > div > div.mud-table.mud-sm-table.mud-table-hover.mud-elevation-1 > div.mud-table-container > table > tbody > tr:nth-child(1) > td:nth-child(4) > div > div > div > div > button:nth-child(1)"));
            BotonCoca.Click();
            Thread.Sleep(2000);
            BotonPepsi = driver.FindElement(By.CssSelector("#banner > div > div > div.mud-table.mud-sm-table.mud-table-hover.mud-elevation-1 > div.mud-table-container > table > tbody > tr:nth-child(2) > td:nth-child(4) > div > div > div > div > button:nth-child(1)"));
            BotonPepsi.Click();
            Thread.Sleep(2000);
            BotonFanta = driver.FindElement(By.CssSelector("#banner > div > div > div.mud-table.mud-sm-table.mud-table-hover.mud-elevation-1 > div.mud-table-container > table > tbody > tr:nth-child(3) > td:nth-child(4) > div > div > div > div > button:nth-child(1)"));
            BotonFanta.Click();
            Thread.Sleep(2000);
            BotonSprite = driver.FindElement(By.CssSelector("#banner > div > div > div.mud-table.mud-sm-table.mud-table-hover.mud-elevation-1 > div.mud-table-container > table > tbody > tr:nth-child(4) > td:nth-child(4) > div > div > div > div > button:nth-child(1)"));
            BotonSprite.Click();
            Thread.Sleep(2000);
            MontoTotal = driver.FindElement(By.CssSelector("#banner > div > div > div.mud-grid.mud-grid-spacing-xs-3.mud-grid-justify-xs-flex-start > div.mud-grid-item.mud-grid-item-xs-3 > p"));

            //Assert
            Assert.IsTrue(MontoTotal.Text.Equals("Monto total: ₡ 2375"));
        }
    }
}