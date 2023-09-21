namespace OrangeHRMTest
{

    [TestClass]
    public class FileDownloadTest
    {
        private IBrowser Browser;
        private IPage Page;

        [TestInitialize]
        public async Task TestSetup()
        {
            // Start the browser and page context for the test
            Browser = await Playwright.CreateAsync().Result.Chromium.LaunchAsync(new() { Headless = false });
            var context = await Browser.NewContextAsync(new() { AcceptDownloads = true });
            Page = await context.NewPageAsync();
        }

        [TestCleanup]
        public async Task TestCleanup()
        {
            // Close browser after the test
            await Browser.CloseAsync();
        }

        [TestMethod]
        public async Task DownloadImageTest()
        {
            // Navigate to the main page
            await Page.GotoAsync("https://the-internet.herokuapp.com/");

            // Click on "File Download" link
            await Page.ClickAsync("text=File Download");

            // Initiate the download by clicking on "image4.jpg"
            var download = await Page.RunAndWaitForDownloadAsync(() => Page.ClickAsync("text=image4.jpg"));

            // You can further inspect the downloaded file if needed:
            string path = await download.PathAsync();
            Assert.IsTrue(System.IO.File.Exists(path), "File was not downloaded successfully");
        }
    }
}