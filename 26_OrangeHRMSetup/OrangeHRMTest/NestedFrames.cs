using Microsoft.Playwright.MSTest;

namespace OrangeHRMTest
{

    [TestClass]
    public class NestedFrames : PageTest
    {
        [TestMethod]
        [TestCategory("PositiveTest")]
        [TestCategory("WorkingWithNestedFrames")]
        public async Task WorkingWithNestedFrames()
        {
            await Page.GotoAsync("https://the-internet.herokuapp.com/nested_frames");

            // Interacting with the left frame
            var leftFrameText = await Page.FrameLocator("frame[name=\"frame-top\"]").FrameLocator("frame[name=\"frame-left\"]").GetByText("LEFT").InnerTextAsync();
            Assert.AreEqual("LEFT", leftFrameText);

            // Clicking the body of the middle frame (not much to assert here)
            await Page.FrameLocator("frame[name=\"frame-top\"]").FrameLocator("frame[name=\"frame-middle\"]").Locator("body").ClickAsync();

            // Interacting with the right frame
            var rightFrameText = await Page.FrameLocator("frame[name=\"frame-top\"]").FrameLocator("frame[name=\"frame-right\"]").GetByText("RIGHT").InnerTextAsync();
            Assert.AreEqual("RIGHT", rightFrameText);

            // Interacting with the bottom frame
            var bottomFrameText = await Page.FrameLocator("frame[name=\"frame-bottom\"]").GetByText("BOTTOM").InnerTextAsync();
            Assert.AreEqual("BOTTOM", bottomFrameText);

            // Demonstrating another interaction within the middle frame
            await Page.FrameLocator("frame[name=\"frame-top\"]").FrameLocator("frame[name=\"frame-middle\"]").GetByText("MIDDLE").ClickAsync();

            // You've already clicked on RIGHT and LEFT, so not repeating them here.

            // After all interactions, maybe assert some global state or condition of the page or frames.
        }
    }
}