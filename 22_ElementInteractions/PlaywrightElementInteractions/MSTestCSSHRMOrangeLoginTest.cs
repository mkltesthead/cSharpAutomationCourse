namespace PlaywrightElementInteractions
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
        public async Task LoginToOrangeHRM()
        {
            // Navigate to the OrangeHRM login page
            await _page.GotoAsync("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            // Wait for the page to finish loading
            await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);

            // Wait for the username input field using a CSS Selector
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

            Assert.IsNotNull(dashboardElement, "Dashboard");
        }

        [TestMethod]
        public async Task NegativeLoginToOrangeHRMInvalidCredentials()
        {
            // Navigate to the OrangeHRM login page
            await _page.GotoAsync("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            // Wait for the page to finish loading
            await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);

            // Wait for the username input field using a CSS Selector
            await _page.WaitForSelectorAsync("input[name='username']");

            // Locate and fill in the username input field using a CSS Selector
            await _page.FillAsync("input[name='username']", "InvalidUser");

            // Locate and fill in the password input field using a CSS Selector
            await _page.FillAsync("input[name='password']", "invalidPassword");

            // Click the "LOGIN" button using a CSS Selector
            await _page.ClickAsync("button[type=submit]");

            var alertContent = await _page.WaitForSelectorAsync(".oxd-alert-content-text");
            Assert.IsTrue(await _page.QuerySelectorAsync(".oxd-alert-content-text") != null);
            Console.WriteLine($" Alert Content: {alertContent}");

        }

        [TestMethod]
        public async Task NegativeLoginToOrangeHRMNoUsername()
        {
            // Navigate to the OrangeHRM login page
            await _page.GotoAsync("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            // Wait for the page to finish loading
            await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);

            // Wait for the username input field using a CSS Selector
            await _page.WaitForSelectorAsync("input[name='username']");

            // Locate and fill in the username input field using a CSS Selector
            await _page.FillAsync("input[name='username']", "");

            // Locate and fill in the password input field using a CSS Selector
            await _page.FillAsync("input[name='password']", "invalidPassword");

            // Click the "LOGIN" button using a CSS Selector
            await _page.ClickAsync("button[type=submit]");

            var alertContent = await _page.WaitForSelectorAsync(".oxd-input-field-error-message");
            Assert.IsTrue(await _page.QuerySelectorAsync(".oxd-input-field-error-message") != null);
            Console.WriteLine($" Alert Content: {alertContent}");
        }

        [TestMethod]
        public async Task NegativeLoginToOrangeHRMNoPassword()
        {
            // Navigate to the OrangeHRM login page
            await _page.GotoAsync("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            // Wait for the page to finish loading
            await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);

            // Wait for the username input field using a CSS Selector
            await _page.WaitForSelectorAsync("input[name='username']");

            // Locate and fill in the username input field using a CSS Selector
            await _page.FillAsync("input[name='username']", "admin");

            // Locate and fill in the password input field using a CSS Selector
            await _page.FillAsync("input[name='password']", "");

            // Click the "LOGIN" button using a CSS Selector
            await _page.ClickAsync("button[type=submit]");

            var alertContent = await _page.WaitForSelectorAsync(".oxd-input-field-error-message");
            Assert.IsTrue(await _page.QuerySelectorAsync(".oxd-input-field-error-message") != null);
            Console.WriteLine($" Alert Content: {alertContent}");
        }

        [TestCleanup]
        public async Task TestCleanup()
        {
            // Close the browser at the end of the test
            await _browser.CloseAsync();
        }
    }
}