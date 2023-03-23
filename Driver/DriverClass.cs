using OpenQA.Selenium.Chrome;

namespace AutomacaoWebSelenium.Driver
{
    public class Driver
    {
        private readonly ChromeDriver driver;
        public ChromeDriver IniciarDriver()
        {
            return driver;
        }
    }
}
