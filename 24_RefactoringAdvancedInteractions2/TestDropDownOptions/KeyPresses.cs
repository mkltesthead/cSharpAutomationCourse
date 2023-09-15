namespace RefactoredElementInteractionsMSTest
{
    [TestClass]
    public class KeyPressTest : TestBase
    {
        [TestMethod]
        public async Task KeyPress()
        {
            string url = BaseUrl + "key_presses";
            await Page.GotoAsync(url);

            await Page.Locator("#target").ClickAsync();

            // Simulate a key press event (e.g., pressing the 'A' key)
            await Page.Keyboard.PressAsync("a");

            // Wait for a moment to allow any UI updates
            await Page.WaitForTimeoutAsync(1000); // Adjust the delay as needed

            // Use EvaluateAsync to get the text content of the result element
            var resultText = await Page.EvaluateAsync<string>("() => document.getElementById('result').textContent");

            // Assert that the result contains the expected key name ('a' in this case)
            Assert.IsTrue(resultText.Contains("a", StringComparison.OrdinalIgnoreCase));
        }
    }
}
