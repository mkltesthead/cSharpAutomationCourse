namespace XUnitPlaywrightElementInteractions
{
    public class CSSHRMOrangeLoginTest
    {
        private IPlaywright _playwright;
        private IBrowser _browser;
        private IPage _page;

        public CSSHRMOrangeLoginTest()
        {
            // Create a Playwright instance and launch a browser
            _playwright = Playwright.CreateAsync().GetAwaiter().GetResult();
            _browser = _playwright.Chromium.LaunchAsync().GetAwaiter().GetResult();
            _page = _browser.NewPageAsync().GetAwaiter().GetResult();
        }

        [Fact]
        public async Task CSSLoginToOrangeHRM()
        {
            // Navigate to the OrangeHRM login page
            await _page.GotoAsync("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            // Wait for the page to finish loading
            await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);

            // Wait for the username input field
            await _page.WaitForSelectorAsync("input[name='username']");

            // Locate and fill in the username input field
            await _page.FillAsync("input[name='username']", "admin");

            // Locate and fill in the password input field
            await _page.FillAsync("input[name='password']", "admin123");

            // Click the "LOGIN" button
            await _page.ClickAsync("button[type=submit]");

            // Wait for the dashboard element to appear
            await _page.WaitForSelectorAsync(".oxd-topbar-header-breadcrumb-module");

            // Verify if the dashboard element is present after a successful login
            var dashboardElement = await _page.QuerySelectorAsync(".oxd-topbar-header-breadcrumb-module");
            Assert.NotNull(dashboardElement);
        }

        [Fact]
        public void Dispose()
        {
            // Close the browser at the end of the test
            _browser.CloseAsync().GetAwaiter().GetResult();
        }
    }
}
