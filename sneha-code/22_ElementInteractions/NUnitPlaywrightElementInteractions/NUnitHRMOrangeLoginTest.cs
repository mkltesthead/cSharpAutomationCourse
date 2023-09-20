namespace PlaywrightElementInteractions
{
    [TestFixture]
    public class HRMOrangeLoginTest
    {
        private IPlaywright _playwright;
        private IBrowser _browser;
        private IPage _page;

        [SetUp]
        public async Task TestInitialize()
        {
            // Create a Playwright instance and launch a browser
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync();
            _page = await _browser.NewPageAsync();
        }

        [Test]
        public async Task LoginToOrangeHRM()
        {
            // Navigate to the OrangeHRM login page
            await _page.GotoAsync("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            // Wait for the page to finish loading
            await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);

            // Wait for the username input field with a 10-second timeout
            await _page.WaitForSelectorAsync("input[name='username']");

            // Locate and fill in the username input field using a CSS Selector
            await _page.FillAsync("input[name='username']", "admin");

            // Locate and fill in the password input field using a CSS Selector
            await _page.FillAsync("input[name='password']", "admin123");

            // Click the "LOGIN" button using a CSS Selector
            await _page.ClickAsync("button[type=submit]");

            // Wait for the dashboard element to appear (assuming it appears after a successful login)
            await _page.WaitForSelectorAsync(".oxd-topbar-header-breadcrumb-module");

            // Verify if the dashboard element is present after a successful login
            var dashboardElement = await _page.QuerySelectorAsync(".oxd-topbar-header-breadcrumb-module");

            Assert.That(dashboardElement, Is.Not.Null, "Dashboard");
        }

        [TearDown]
        public async Task TestCleanup()
        {
            // Close the browser at the end of the test
            await _browser.CloseAsync();
        }
    }
}