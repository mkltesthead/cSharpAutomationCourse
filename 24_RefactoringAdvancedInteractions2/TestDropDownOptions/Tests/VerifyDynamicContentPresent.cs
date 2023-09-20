namespace RefactoredElementInteractionsMSTest.Tests
{
    [TestClass]
    public class DynamicContentTests : ChromiumBase
    {
        [TestMethod]
        [TestCategory("PositiveTest")]
        [TestCategory("VerifyDynamicContent")]
        public async Task VerifyDynamicContentPresence()
        {
            string url = "https://the-internet.herokuapp.com/dynamic_content";
            await Page.GotoAsync(url);

            // Use a selector to identify the dynamic content element(s)
            string dynamicContentSelector = ".large-2.columns";
            var dynamicContent = await Page.QuerySelectorAllAsync(dynamicContentSelector);

            // Assert that at least one dynamic content element is present
            Assert.IsTrue(dynamicContent.Count > 0);
        }
    }
}