namespace IntroPlaywrightNUnit
{
    [TestFixture]
    public class NUnitFirstPlaywrightTest
    {
        private IPlaywright playwright;
        private IBrowser browser;
        private IPage page;

        [SetUp]
        public async Task SetUp()
        {
            playwright = await Playwright.CreateAsync();
            browser = await playwright.Chromium.LaunchAsync();
            page = await browser.NewPageAsync();
        }

        [TearDown]
        public async Task TearDown()
        {
            await page.CloseAsync();
            await browser.CloseAsync();
        }

        [Test]
        public async Task VerifyTitleOnPlaywrightHomepage()
        {
            await page.GotoAsync("https://playwright.dev/");

            // Get the page title
            var title = await page.TitleAsync();

            Console.WriteLine($"Page Title: {title}");

            // Assert the title content
            Assert.That(title,
                        Is.EqualTo("Fast and reliable end-to-end testing for modern web apps | Playwright"));
        }

        [Test]
        public async Task FailTitleOnPlaywrightHomepage()
        {
            await page.GotoAsync("https://playwright.dev/");

            // Get the page title
            var title = await page.TitleAsync();

            Console.WriteLine($"Page Title: {title}");

            // Assert the title content
            Assert.That(title,
                        Is.Not.EqualTo("Fast reliable end-to-end testing for modern web apps | Playwright"));
        }
    }
}
