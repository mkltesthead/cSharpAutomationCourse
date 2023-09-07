namespace IntroPlaywrightXUnit
{
    public class PlaywrightFixture : IAsyncLifetime
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
    public class PlaywrightTests : IClassFixture<PlaywrightFixture>
    {
        private readonly PlaywrightFixture _fixture;

        public PlaywrightTests(PlaywrightFixture fixture)
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

        [Fact]
        public async Task FailTitleOnPlaywrightHomepage()
        {
            var page = await _fixture.Browser.NewPageAsync();
            await page.GotoAsync("https://playwright.dev/");

            // Get the page title
            var title = await page.TitleAsync();

            // Assert the title content
            Assert.NotEqual("Fast reliable end-to-end testing for modern web apps | Playwright", title);
        }
    }

}