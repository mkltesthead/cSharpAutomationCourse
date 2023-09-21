namespace OrangeHRMTest
{
    [TestClass]
    public class FileUploadTest
    {
        private IBrowser? Browser;
        private IPage? Page;

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
        public async Task UploadFileTest()
        {
            // Navigate to the file upload page
            await Page.GotoAsync("https://the-internet.herokuapp.com/upload");

            // Upload the file
            string filePath = System.IO.Path.Combine(System.AppContext.BaseDirectory, "DotNETTestExamples.txt");
            await Page.Locator("#file-upload").SetInputFilesAsync(filePath);

            // Click the upload button
            await Page.Locator("#file-submit").ClickAsync();

            // Verify the file was uploaded successfully
            var heading = await Page.Locator("h3").InnerTextAsync();
            Assert.AreEqual("File Uploaded!", heading, "File was not uploaded successfully");
        }
    }
}