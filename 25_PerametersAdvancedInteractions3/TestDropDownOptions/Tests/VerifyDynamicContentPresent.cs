namespace ParameterElementInteractions.Tests
{
    [TestClass]
    public class DynamicContentTests : ChromiumBase
    {
        [TestMethod]
        [TestCategory("PositiveTest")]
        [TestCategory("VerifyDynamicContent")]
        public async Task VerifyDynamicContentPresence()
        {
            await Page.GotoAsync(DynamicContentUrl);

            // Use a selector to identify the dynamic content element(s)
            string dynamicContentSelector = ".large-2.columns";
            var dynamicContent = await Page.QuerySelectorAllAsync(dynamicContentSelector);

            // Assert that at least one dynamic content element is present
            Console.WriteLine($"What appears in my dynanic content selector: " + dynamicContentSelector);
            Console.WriteLine($"What do we have for our dynamic content value: " + dynamicContent);
            Assert.IsTrue(dynamicContent.Count > 0);
        }
    }
}