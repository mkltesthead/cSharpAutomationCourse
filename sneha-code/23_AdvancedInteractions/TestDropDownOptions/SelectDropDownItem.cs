namespace ElementInteractionsMSTest
{
    [TestClass]
    public class PageDropDownTest
    {
        [TestMethod]
        public async Task SelectDropDownItem()
        {
            // Set up our headless browser environment
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync();
            var page = await browser.NewPageAsync();

            // Navigate to our web page
            await page.GotoAsync("https://the-internet.herokuapp.com/dropdown");

            // Select an option in the dropdown
            await page.Locator("#dropdown").SelectOptionAsync(new[] { "1" });

            // Retrieve the text of the selected option(s) using JavaScript
            // This took some looking up and experimenting
            var selectedOptions = await page.EvaluateAsync<string[]>(@"() => {
                const selectedOptions = [];
                const options = document.querySelectorAll('#dropdown option[selected]');
                for (const option of options) {
                    selectedOptions.push(option.textContent);
                }
                return selectedOptions;
            }");

            // Check if there is at least one selected option
            Assert.IsTrue(selectedOptions.Length > 0);
            Console.WriteLine($"SelectedOptions Length: {selectedOptions.Length}");

            // Compare the text of the first selected option with the expected value
            Assert.AreEqual("Option 1", selectedOptions[0]);
            Console.WriteLine($"Selected Option text value: {selectedOptions[0]}");

            // Close the browser
            await browser.CloseAsync();
        }
    }
}