namespace ElementInteractionsMSTest
{
    [TestClass]
    public class KeyPressTest
    {
        [TestMethod]
        public async Task KeyPress()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync();
            var page = await browser.NewPageAsync();

            await page.GotoAsync("https://the-internet.herokuapp.com/key_presses");

            await page.Locator("#target").ClickAsync();

            // Simulate a key press event (e.g., pressing the 'A' key)
            await page.Keyboard.PressAsync("a");

            // Wait for a moment to allow any UI updates
            await page.WaitForTimeoutAsync(1000); // Adjust the delay as needed

            // Use EvaluateAsync to get the text content of the result element
            var resultText = await page.EvaluateAsync<string>("() => document.getElementById('result').textContent");

            // Assert that the result contains the expected key name ('a' in this case)
            Assert.IsTrue(resultText.Contains("a", StringComparison.OrdinalIgnoreCase));

            // Close the browser
            await browser.CloseAsync();
        }
    }
}
