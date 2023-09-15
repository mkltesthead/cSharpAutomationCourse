namespace RefactoredElementInteractionsMSTest
{
    public class TestBase
    {
        protected IPage Page;
        protected string BaseUrl = "https://the-internet.herokuapp.com/";

        [TestInitialize]
        public async Task Initialize()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync();
            Page = await browser.NewPageAsync();
        }

        [TestCleanup]
        public async Task Cleanup()
        {
            await Page.CloseAsync();
        }
    }
}

