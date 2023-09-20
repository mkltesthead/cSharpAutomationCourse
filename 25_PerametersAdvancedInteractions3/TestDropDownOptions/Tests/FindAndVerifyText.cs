namespace ParameterElementInteractions.Tests
{
    [TestClass]

    public class FindAndVerifyText : ChromiumBase
    {
        private string capturedText; // Store the captured text

        [TestMethod]
        [TestCategory("PositiveTest")]
        [TestCategory("FindAndVerifyText")]
        public async Task FindAndVerifyTextTest()
        {
            await Page.GotoAsync(ContextMenuUrl);

            // Use Playwright to locate and extract text content
            string extractedText = await Page.InnerTextAsync(".example h3");

            // Verify that the extracted text is equal to "Context Menu"
            Assert.AreEqual("Context Menu", extractedText);
        }

        [TestMethod]
        [TestCategory("NegativeTest")]
        [TestCategory("CutTextAndVerifyAbsense")]
        public async Task CutTextAndVerifyAbsence()
        {
            await Page.GotoAsync(ContextMenuUrl);

            // Use Playwright to locate and extract text content
            string extractedText = await Page.InnerTextAsync(".example h3");

            // Simulate cutting the text by removing it from the element
            await Page.EvaluateAsync(@"() => {
        const element = document.querySelector('.example h3');
        element.textContent = ''; // Remove the text content
        }");

            // Attempt to locate the same text element again
            string newText = await Page.InnerTextAsync(".example h3");

            // Verify that the text is not present
            Assert.AreNotEqual(extractedText, newText);
        }

        [TestMethod]
        [TestCategory("PositiveTest")]
        [TestCategory("CaptureAndVerifyText")]

        public async Task CaptureAndVerifyText()
        {
            string url = "https://the-internet.herokuapp.com/context_menu";
            await Page.GotoAsync(url);

            // Use Playwright to locate and capture text content
            capturedText = await Page.InnerTextAsync(".example h3");

            // Perform other actions or navigate to different pages

            // Use an assertion to verify that the captured text is present
            bool isTextPresent = await Page.TextContentAsync("body").ContinueWith(task =>
            {
                var result = task.Result;
                return result.Contains(capturedText);
            });

            Assert.IsTrue(isTextPresent);
        }
    }
}

