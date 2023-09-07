namespace IntroPlaywrightMSTest
{
    [TestClass]
    public class FirstPlaywrightTest
    {
        [TestMethod]
        public async Task VerifyTitleOnPlaywrightHomepage()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync();
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://playwright.dev/");

            // Get the page title
            // Fast and reliable end-to-end testing for modern web apps | Playwright
            var title = await page.TitleAsync();

            Console.WriteLine($"Page Title: {title}");

            // Assert the title content
            Assert.AreEqual("Fast and reliable end-to-end testing for modern web apps | Playwright", title);
        }

        [TestMethod]
        public async Task FailTitleOnPlaywrightHomepage()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync();
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://playwright.dev/");

            // Get the page title
            // Fast and reliable end-to-end testing for modern web apps | Playwright
            var title = await page.TitleAsync();

            Console.WriteLine($"Page Title: {title}");

            // Assert the title content
            Assert.AreNotEqual("Fast reliable end-to-end testing for modern web apps | Playwright", title);
        }
    }
}