namespace MSTestPlaywrightElementInteractions
{
    [TestClass]
    public class HRMOrangeLoginTest
    {
        private IPlaywright _playwright;
        private IBrowser _browser;
        private IPage _page;

        [TestInitialize]
        public async Task TestInitialize()
        {
            // Create a Playwright instance and launch a browser
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync();
            _page = await _browser.NewPageAsync();
        }

        [TestMethod]
        public async Task LoginToOrangeHRMWithXPath()
        {
            // Navigate to the OrangeHRM login page
            await _page.GotoAsync("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            // Wait for the page to finish loading
            await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);

            // Wait for the username input field using XPath
            await _page.WaitForSelectorAsync("//*[contains(@name, 'username')]");

            // Locate and fill in the username input field using XPath
            await _page.FillAsync("//*[contains(@name, 'username')]", "admin");

            // Locate and fill in the password input field using XPath
            await _page.FillAsync("//*[contains(@name, 'password')]", "admin123");

            // Click the "LOGIN" button using XPath
            await _page.ClickAsync("//*[contains(@type, 'submit')]");

            // Wait for the dashboard element to appear using XPath
            await _page.WaitForSelectorAsync("//*[contains(@class, 'oxd-topbar-header-breadcrumb-module')]");

            // Verify if the dashboard element is present after a successful login
            var dashboardElement = await _page.QuerySelectorAsync("//*[contains(@class, 'oxd-topbar-header-breadcrumb-module')]");
            Assert.IsNotNull(dashboardElement, "Dashboard");
        }

        [TestCleanup]
        public async Task TestCleanup()
        {
            // Close the browser at the end of the test
            await _browser.CloseAsync();
        }
    }
}