using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using AutomacaoWebSelenium.Driver;

namespace AutomacaoWebSelenium.Helper.HelperC
{
    public class HelperC
    {
        public readonly ChromeDriver driver;
        public HelperC() { 
            driver = new ChromeDriver();
        }
        #region Clicar
        public void ClicarPorId(string id) => driver.FindElement(By.Id(id)).Click();
        public void ClicarPorXpath(string xpath) => driver.FindElement(By.XPath(xpath)).Click();         
        public void ClicarPorNome(string name) => driver.FindElement(By.Name(name)).Click();
        public void ClicarPorClasse(string classname) => driver.FindElement(By.ClassName(classname)).Click();
         public void ClicarPorCssSelector(string cssSelector) => driver.FindElement(By.CssSelector(cssSelector)).Click();
        public void ClicarPorLink(string link) => driver.FindElement(By.LinkText(link)).Click();
        #endregion
        #region Preencher
        public void PreencherPorId(string id, string texto) => driver.FindElement(By.Id(id)).SendKeys(texto);
        public void PreencherPorXpath(string xpath, string texto) => driver.FindElement(By.XPath(xpath)).SendKeys(texto);
        public void PreencherPorNome(string name, string texto) => driver.FindElement(By.Name(name)).SendKeys(texto);
        public void PreencherPorClasse(string classname, string texto) => driver.FindElement(By.ClassName(classname)).SendKeys(texto);
        #endregion
        #region Navegar
        public void NavegarPorUrl(string url) => driver.Navigate().GoToUrl(url);
        public void MaximizarNavegador() => driver.Manage().Window.Maximize();
        public void FecharNavegador() => driver.Dispose();
        #endregion
    }
}
