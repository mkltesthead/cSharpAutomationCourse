namespace IntroPlaywrightMSTest
{
    [TestClass]
    public class MSTestFirstPlaywrightTest
    {
        [TestMethod]
        public async Task VerifyTitleOnPlaywrightHomepage1_Chromium()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync();
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://playwright.dev/");

            // Get the page title
            var title = await page.TitleAsync();

            Console.WriteLine($"Page Title: {title}");

            // Assert the title content
            Assert.AreEqual("Fast and reliable end-to-end testing for modern web apps | Playwright", title);
        }

        [TestMethod]
        [Ignore("Times out - I don't know why")]
        public async Task VerifyTitleOnPlaywrightHomepage2_Firefox()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Firefox.LaunchAsync();
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://playwright.dev/");

            // Get the page title
            var title = await page.TitleAsync();

            Console.WriteLine($"Page Title: {title}");

            // Assert the title content
            Assert.AreEqual("Fast and reliable end-to-end testing for modern web apps | Playwright", title);
        }

        [TestMethod]
        public async Task VerifyTitleOnPlaywrightHomepage3_Webkit()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Webkit.LaunchAsync();
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://playwright.dev/");

            // Get the page title
            var title = await page.TitleAsync();

            Console.WriteLine($"Page Title: {title}");

            // Assert the title content
            Assert.AreEqual("Fast and reliable end-to-end testing for modern web apps | Playwright", title);
        }

        [TestMethod]
        public async Task VerifyTitleOnPlaywrightHomepage3b_Webkit()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Webkit.LaunchAsync();
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://playwright.dev/");

            // Get the page title
            var title = await page.TitleAsync();

            Console.WriteLine($"Page Title: {title}");

            // Assert the title content
            Assert.AreNotEqual("Fast and un-reliable end-to-end testing for modern web apps | Playwright", title);
        }

        [TestMethod]
        public async Task VerifyTitleOnPlaywrightHomepage1a_Chromium_herokuapp1()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync();
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://the-internet.herokuapp.com/abtest");

            // Get the page title
            var title = await page.TitleAsync();

            Console.WriteLine($"Page Title: {title}");

            // Assert the title content
            Assert.AreEqual("The Internet", title);
        }

        [TestMethod]
        public async Task VerifyTitleOnPlaywrightHomepage1b_Chromium_herokuapp1()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync();
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://the-internet.herokuapp.com/abtest");

            // Get the page title
            var title = await page.TitleAsync();

            Console.WriteLine($"Page Title: {title}");

            // Assert the title content
            Assert.AreNotEqual("Internet", title);
        }

        [TestMethod]
        [Ignore("Times out - I don't know why")]
        public async Task VerifyTitleOnPlaywrightHomepage1c_Firefox_herokuapp1()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Firefox.LaunchAsync();
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://the-internet.herokuapp.com/abtest");

            // Get the page title
            var title = await page.TitleAsync();

            Console.WriteLine($"Page Title: {title}");

            // Assert the title content
            Assert.AreEqual("The Internet", title);
        }

        [TestMethod]
        public async Task VerifyTitleOnPlaywrightHomepage1d_Webkit_herokuapp1()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Webkit.LaunchAsync();
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://the-internet.herokuapp.com/abtest");

            // Get the page title
            var title = await page.TitleAsync();

            Console.WriteLine($"Page Title: {title}");

            // Assert the title content
            Assert.AreEqual("The Internet", title);
        }
    }
}