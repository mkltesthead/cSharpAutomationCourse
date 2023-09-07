namespace IntroPlaywrightXUnit
{
    public class XUnitPlaywrightFixture : IAsyncLifetime
    {
        public IBrowser Browser { get; private set; }

        public async Task InitializeAsync()
        {
            var playwright = await Playwright.CreateAsync();
            Browser = await playwright.Chromium.LaunchAsync();
        }

        public async Task DisposeAsync()
        {
            await Browser.CloseAsync();
        }
    }
    public class XUnitPlaywrightTests : IClassFixture<XUnitPlaywrightFixture>
    {
        private readonly XUnitPlaywrightFixture _fixture;

        public XUnitPlaywrightTests(XUnitPlaywrightFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task VerifyTitleOnPlaywrightHomepage()
        {
            var page = await _fixture.Browser.NewPageAsync();
            await page.GotoAsync("https://playwright.dev/");

            // Get the page title
            var title = await page.TitleAsync();

            // Assert the title content
            Assert.Equal("Fast and reliable end-to-end testing for modern web apps | Playwright", title);
        }
    }

}