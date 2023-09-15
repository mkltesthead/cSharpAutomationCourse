namespace ElementInteractionsMSTest
{
    [TestClass]
    public class CheckboxTest
    {

        [TestMethod]
        public async Task UncheckFirstCheckbox()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync();
            var page = await browser.NewPageAsync();

            await page.GotoAsync("https://the-internet.herokuapp.com/checkboxes");

            // Uncheck the first checkbox
            await page.GetByRole(AriaRole.Checkbox).First.UncheckAsync();

            // Assert that the first checkbox is unchecked
            var isChecked = await page.GetByRole(AriaRole.Checkbox).First.IsCheckedAsync();
            Assert.IsFalse(isChecked);

            browser.CloseAsync().Wait();
        }
    }
}

