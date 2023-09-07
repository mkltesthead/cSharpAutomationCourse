namespace IntroPlaywrightMSTest
{
    public class HomePage
    {
        private readonly IPage _page;

        public HomePage(IPage page)
        {
            _page = page;
        }

        public async Task<string> GetPageTitleAsync()
        {
            return await _page.TitleAsync();
        }

        public async Task NavigateToHomePageAsync()
        {
            await _page.GotoAsync("https://playwright.dev/");
        }
    }

}
