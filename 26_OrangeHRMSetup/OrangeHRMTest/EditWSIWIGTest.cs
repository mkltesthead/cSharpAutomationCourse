namespace OrangeHRMTest
{

    [TestClass]
    public class WYSIWYGEditorTest
    {
        private IBrowser Browser;
        private IPage Page;

        [TestInitialize]
        public async Task TestSetup()
        {
            // Start the browser and page context for the test
            Browser = await Playwright.CreateAsync().Result.Chromium.LaunchAsync(new() { Headless = false });
            Page = await Browser.NewPageAsync();
        }

        [TestCleanup]
        public async Task TestCleanup()
        {
            // Close browser after the test
            await Browser.CloseAsync();
        }

        [TestMethod]
        public async Task EditWYSIWYGTest()
        {
            // Navigate to the WYSIWYG Editor page
            await Page.GotoAsync("https://the-internet.herokuapp.com/tinymce");

            // Switch to the TinyMCE iframe
            var frameElement = await Page.Locator("iframe[title=\"Rich Text Area\"]").ElementHandleAsync();
            var frame = await frameElement.ContentFrameAsync();


            // Clear the existing content and type new content
            await frame.Locator("body").FillAsync("This is a section of text that I entered.");

            // Verify the content was updated
            var actualContent = await frame.Locator("body").InnerTextAsync();
            var expectedContent = "This is a section of text that I entered.";
            StringAssert.Contains(actualContent, expectedContent, "The expected content is not present.");

            // You can add more actions here to interact with the editor's features...
        }
    }
}