namespace RefactoredElementInteractionsMSTest.Tests
{
    [TestClass]
    public class KeyPressTest : ChromiumBase
    {
        [TestMethod]
        [TestCategory("PositiveTest")]
        [TestCategory("KeyPress")]
        public async Task ChromiumKeyPress()
        {
            string url = BaseUrl + "key_presses";
            await Page.GotoAsync(url);

            await Page.Locator("#target").ClickAsync();

            // Simulate a key press event (e.g., pressing the 'A' key)
            await Page.Keyboard.PressAsync("a");

            // Use EvaluateAsync to get the text content of the result element
            var resultText = await Page.EvaluateAsync<string>("() => document.getElementById('result').textContent");

            // Assert that the result contains the expected key name ('a' in this case)
            Assert.IsTrue(resultText.Contains("a", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(resultText);
        }
    }
}
