namespace ParameterElementInteractions.Tests
{
    [TestClass]
    [TestCategory("PositiveTest")]
    [TestCategory("HoverTest")]

    public class HoverOverItemsTest : FirefoxBase
    {
        [TestMethod]
        public async Task FirefoxTestHover()
        {
            string url = BaseUrl + "hovers";
            await Page.GotoAsync(url);

            // Select all the avatar elements
            var avatarElement = await Page.QuerySelectorAsync(".figure");

            // Use the "hover" method of the element
            await avatarElement.HoverAsync();

            // Custom JavaScript evaluation to check visibility
            var isFigcaptionVisible = await Page.EvaluateAsync<bool>(@"
                () => {
                const figcaption = document.querySelector('.figcaption');
                return window.getComputedStyle(figcaption).getPropertyValue('display') !== 'none';
                }
                ");

            // Assert the figcaption is visible
            Console.WriteLine($"Hover action performed. isFigcaptionVisible: {isFigcaptionVisible}");
            Assert.IsTrue(isFigcaptionVisible);
        }

        [TestMethod]
        [TestCategory("NegativeTest")]
        [TestCategory("HoverTest")]

        public async Task FirefoxTestNoHover()
        {
            string url = BaseUrl + "hovers";
            await Page.GotoAsync(url);

            // Select an element that should not trigger the hover effect
            var nonHoverElement = await Page.QuerySelectorAsync(".large-4");
            // Use the "hover" method of the element (should not trigger hover effect)
            await nonHoverElement.HoverAsync();

            // Custom JavaScript evaluation to check visibility
            var isFigcaptionVisible = await Page.EvaluateAsync<bool>(@"
                () => {
                    const figcaption = document.querySelector('.figcaption');
                    return window.getComputedStyle(figcaption).getPropertyValue('display') !== 'none';
                }
            ");

            // Assert that the figcaption is not visible
            Console.WriteLine($"No hover action performed. isFigcaptionVisible: {isFigcaptionVisible}");
            Assert.IsFalse(isFigcaptionVisible);
        }
    }
}