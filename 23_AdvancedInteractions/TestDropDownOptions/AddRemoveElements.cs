namespace ElementInteractionsMSTest
{
    [TestClass]
    public class AddRemoveElementsTests : TestBase
    {
        [TestMethod]
        public async Task AddAndRemoveElementsOnce()
        {
            string url = BaseUrl + "add_remove_elements/";
            await Page.GotoAsync(url);

            // Count the initial number of elements
            var initialElements = await Page.QuerySelectorAllAsync(".added-manually");
            var initialElementCount = initialElements.Count;

            // Click the "Add Element" button
            await Page.GetByRole(AriaRole.Button, new() { Name = "Add Element" }).ClickAsync();

            // Count the number of elements after clicking "Add Element"
            var elementsAfterAdd = await Page.QuerySelectorAllAsync(".added-manually");
            var elementCountAfterAdd = elementsAfterAdd.Count;

            // Assert that the element count has increased by 1 after clicking "Add Element"
            Assert.AreEqual(initialElementCount + 1, elementCountAfterAdd);

            // Click the "Delete" button
            await Page.GetByRole(AriaRole.Button, new() { Name = "Delete" }).ClickAsync();

            // Count the number of elements after clicking "Delete"
            var elementsAfterDelete = await Page.QuerySelectorAllAsync(".added-manually");
            var elementCountAfterDelete = elementsAfterDelete.Count;

            // Assert that the element count has decreased by 1 after clicking "Delete"
            Assert.AreEqual(initialElementCount, elementCountAfterDelete);
        }
    }
}