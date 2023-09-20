namespace ElementInteractionsMSTest
{
    [TestClass]
    public class HoverOverItemsTest
    {
        [TestMethod]
        public async Task TestHover()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync();
            var page = await browser.NewPageAsync();

            await page.GotoAsync("https://the-internet.herokuapp.com/hovers");

            // Select all the avatar elements
            var avatarElement = await page.QuerySelectorAsync(".figure");

            // Use the "hover" method of the element
            await avatarElement.HoverAsync();

            // Custom JavaScript evaluation to check visibility
            var isFigcaptionVisible = await page.EvaluateAsync<bool>(@"
                () => {
                const figcaption = document.querySelector('.figcaption');
                return window.getComputedStyle(figcaption).getPropertyValue('display') !== 'none';
                }
                ");

            // Assert the figcaption is visible

            Console.WriteLine($"Hover action performed. isFigcaptionVisible: {isFigcaptionVisible}");
            Assert.IsTrue(isFigcaptionVisible);

            // Close the browser
            await browser.CloseAsync();
        }
    }
}