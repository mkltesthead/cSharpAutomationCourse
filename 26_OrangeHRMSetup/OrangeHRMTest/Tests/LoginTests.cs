using OrangeHRMTests;

namespace OrangeHRMTest.Tests
{
    [TestClass]

    public class BaseLoginTests
    {
        private IPlaywright _playwright;
        private IBrowser _browser;
        private IPage _page;

        [TestInitialize]
        public async Task Initialize()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync();
            _page = await _browser.NewPageAsync();
        }

        [TestCleanup]
        public async Task Cleanup()
        {
            await _browser.CloseAsync();
        }

        [TestMethod]
        [TestCategory("PositiveTest")]
        [TestCategory("LogInSuccess")]
        public async Task TestLoginSuccess()
        {
            var loginPage = new LoginPage(_page);
            await loginPage.GoToLoginPage();
            await loginPage.Login("admin", "admin123");

            // Check if the dashboard is visible
            bool isDashboardVisible = await loginPage.IsDashboardVisible();
            Assert.IsTrue(isDashboardVisible, "Dashboard heading not found");

        }

        [TestMethod]
        [TestCategory("NegativeTest")]
        [TestCategory("LogInNotSuccess")]
        public async Task TestInvalidLogin()
        {
            var loginPage = new LoginPage(_page);

            // Navigate to the login page using the constant URL
            await loginPage.GoToLoginPage();

            // Attempt to login with invalid credentials
            loginPage.Login("invalidUsername", "invalidPassword");

            // Wait for a short period to ensure that any potential login processing has completed
            await _page.WaitForTimeoutAsync(2000);

            // Check if the "Invalid credentials" message is displayed
            bool isInvalidCredentialsMessageDisplayed = await loginPage.IsInvalidCredentialsMessageDisplayed();

            Assert.IsTrue(isInvalidCredentialsMessageDisplayed, "Expected 'Invalid credentials' message was not displayed.");
        }
    }
}
