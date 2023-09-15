namespace ElementInteractionsMSTest
{
    [TestClass]
    public class JavaScriptAlertTest
    {
        [TestMethod]
        public async Task HandleJavaScriptAlert()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync();
            var page = await browser.NewPageAsync();

            await page.GotoAsync("https://the-internet.herokuapp.com/javascript_alerts");

            // Click the "Click for JS Alert" button
            await page.ClickAsync("button[onclick='jsAlert()']");

            // Wait for a moment to allow the alert to appear
            await page.WaitForTimeoutAsync(1000); // Adjust the delay as needed

            // Accept the alert (dismiss it)
            await page.Keyboard.PressAsync("Enter");

            // Verify the result message on the page
            var resultText = await page.Locator("#result").EvaluateAsync<string>("element => element.textContent");
            Assert.IsTrue(resultText.Contains("You successfully clicked an alert", StringComparison.OrdinalIgnoreCase));

            // Close the browser
            await browser.CloseAsync();
        }
    }
}

