namespace ParameterElementInteractions.Tests
{
    [TestClass]
    public class JavaScriptAlertTest : FirefoxBase
    {
        [TestMethod]
        [TestCategory("PositiveTest")]
        [TestCategory("JavaScriptAlert")]

        public async Task HandleJavaScriptAlert()
        {
            string url = BaseUrl + "javascript_alerts";
            await Page.GotoAsync(url);

            // Click the "Click for JS Alert" button
            await Page.ClickAsync("button[onclick='jsAlert()']");

            // Accept the alert (dismiss it)
            await Page.Keyboard.PressAsync("Enter");

            // Verify the result message on the page
            var resultText = await Page.Locator("#result").EvaluateAsync<string>("element => element.textContent");
            Assert.IsTrue(resultText.Contains("You successfully clicked an alert", StringComparison.OrdinalIgnoreCase));
        }
    }
}