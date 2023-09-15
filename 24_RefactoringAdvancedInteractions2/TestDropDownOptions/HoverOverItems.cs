namespace RefactoredElementInteractionsMSTest
{
    [TestClass]
    public class HoverOverItemsTest : TestBase
    {
        [TestMethod]
        public async Task TestHover()
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
    }
}