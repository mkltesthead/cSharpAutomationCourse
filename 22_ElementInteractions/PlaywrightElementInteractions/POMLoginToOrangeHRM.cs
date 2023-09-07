namespace PlaywrightElementInteractions
{
    public class POMHRMOrangeLoginTest
    {
        private IPlaywright _playwright;
        private IBrowser _browser;
        private IPage _page;

        [TestInitialize]
        public async Task TestInitialize()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync();
            _page = await _browser.NewPageAsync();
        }

        [TestMethod]
        public async Task POMLoginToOrangeHRM()
        {
            var loginPage = new LoginPage(_page);

            await _page.GotoAsync("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);

            // Use the LoginPage methods to interact with elements
            await loginPage.EnterUsername("admin");
            await loginPage.EnterPassword("admin123");
            await loginPage.ClickLoginButton();

            // Assuming the dashboard element appears after a successful login
            await _page.WaitForSelectorAsync(".oxd-topbar-header-breadcrumb-module");
            var dashboardElement = await _page.QuerySelectorAsync(".oxd-topbar-header-breadcrumb-module");

            Assert.IsNotNull(dashboardElement, "Dashboard");
        }

        [TestCleanup]
        public async Task TestCleanup()
        {
            await _browser.CloseAsync();
        }
    }
}
