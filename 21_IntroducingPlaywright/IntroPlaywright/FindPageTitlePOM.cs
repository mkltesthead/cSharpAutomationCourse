namespace IntroPlaywrightMSTest
{
    using Microsoft.Playwright;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    namespace IntroPlaywrightMSTest
    {
        [TestClass]
        public class POMPlaywrightTest
        {
            private IPlaywright _playwright;
            private IBrowser _browser;
            private IPage _page;
            private HomePage _homePage;


            [TestInitialize]
            public async Task TestInitialize()
            {
                _playwright = await Playwright.CreateAsync();
                _browser = await _playwright.Chromium.LaunchAsync();
                _page = await _browser.NewPageAsync();
                _homePage = new HomePage(_page);
            }

            // <a class="menu__link menu__link--active" tabindex="0" href="/docs/writing-tests" aria-current="page">Writing tests</a>

            [TestCleanup]
            public async Task TestCleanup()
            {
                await _page.CloseAsync();
                await _browser.CloseAsync();
            }


            [TestMethod]
            public async Task POMVerifyTitleAppearsOnPlaywrightHomepage()
            {
                // Navigate to the homepage using the page object.
                await _homePage.NavigateToHomePageAsync();

                // Get the page title using the page object.
                var title = await _homePage.GetPageTitleAsync();

                Console.WriteLine($"Page Title: {title}");

                // Assert the title content.
                Assert.AreEqual("Fast and reliable end-to-end testing for modern web apps | Playwright", title);
            }
        }
    }
}