global using Microsoft.Playwright;
global using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MSSampleProject
{
    [TestClass]
    public class BaseClass
    {
        protected IPage Page;
        protected string BaseUrl = "http://the-internet.herokuapp.com/";

        [TestInitialize]
        public async Task Initialize()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await Playwright.Chromium.LauchAsync();
            Page = await browser.NewPageAsync();
        }
        [TestCleanup]
        public async Task Cleanup()
        {
            await Page.CloseAsync();
        }


    }
}