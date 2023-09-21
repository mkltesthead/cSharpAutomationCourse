namespace ParameterElementInteractions.Tests
{
    [TestClass]
    public class AddRemoveElementsTests : ChromiumBase
    {
        [TestMethod]
        [TestCategory("PositiveTest")]
        [TestCategory("AddRemoveElements")]
        public async Task AddAndRemoveElementsOnce()
        {
            await Page.GotoAsync(AddRemoveElementsUrl);

            // Count the initial number of elements
            var initialElements = await Page.QuerySelectorAllAsync(".added-manually");
            var initialElementCount = initialElements.Count;
            Console.WriteLine("Initial Element Count: " + initialElementCount);

            // Click the "Add Element" button
            await Page.GetByRole(AriaRole.Button, new() { Name = "Add Element" }).ClickAsync();

            // Count the number of elements after clicking "Add Element"
            var elementsAfterAdd = await Page.QuerySelectorAllAsync(".added-manually");
            var elementCountAfterAdd = elementsAfterAdd.Count;

            // Assert that the element count has increased by 1 after clicking "Add Element"
            Assert.AreEqual(initialElementCount + 1, elementCountAfterAdd);
            Console.WriteLine("Element Count After Add: " + elementCountAfterAdd);

            // Click the "Delete" button
            await Page.GetByRole(AriaRole.Button, new() { Name = "Delete" }).ClickAsync();

            // Count the number of elements after clicking "Delete"
            var elementsAfterDelete = await Page.QuerySelectorAllAsync(".added-manually");
            var elementCountAfterDelete = elementsAfterDelete.Count;

            // Assert that the element count has decreased by 1 after clicking "Delete"
            Assert.AreEqual(initialElementCount, elementCountAfterDelete);
            Console.WriteLine("Element Count After Delete: " + elementCountAfterDelete);

        }
        [TestMethod]
        [TestCategory("PositiveTest")]
        [TestCategory("AddRemoveElements")]

        public async Task AddAndRemoveElementsTwice()
        {
            await Page.GotoAsync(AddRemoveElementsUrl);

            // Count the initial number of elements
            var initialElements = await Page.QuerySelectorAllAsync(".added-manually");
            var initialElementCount = initialElements.Count;
            Console.WriteLine("Initial Element Count: " + initialElementCount);

            // Click the "Add Element" button twice
            await Page.GetByRole(AriaRole.Button, new() { Name = "Add Element" }).ClickAsync();
            await Page.GetByRole(AriaRole.Button, new() { Name = "Add Element" }).ClickAsync();

            // Count the number of elements after clicking "Add Element"
            var elementsAfterAdd = await Page.QuerySelectorAllAsync(".added-manually");
            var elementCountAfterAdd = elementsAfterAdd.Count;

            // Assert that the element count has increased by 1 after clicking "Add Element"
            Assert.AreEqual(initialElementCount + 2, elementCountAfterAdd);
            Console.WriteLine("Element Count After Add: " + elementCountAfterAdd);

            // Click the "Delete" button
            await Page.GetByRole(AriaRole.Button, new() { Name = "Delete" }).Nth(1).ClickAsync();

            // Count the number of elements after clicking "Delete"
            var elementsAfterDelete = await Page.QuerySelectorAllAsync(".added-manually");
            var elementCountAfterDelete = elementsAfterDelete.Count;

            // Assert that the element count has decreased by 1 after clicking "Delete"
            Assert.AreEqual(initialElementCount + 1, elementCountAfterDelete);
            Console.WriteLine("Element Count After Delete: " + elementCountAfterDelete);

        }

        [TestMethod]
        [TestCategory("PositiveTest")]
        [TestCategory("AddRemoveElements")]
        public async Task AddAndRemoveElementsTwiceWithScreenshot()
        {
            await Page.GotoAsync(AddRemoveElementsUrl);

            // Count the initial number of elements
            var initialElements = await Page.QuerySelectorAllAsync(".added-manually");
            var initialElementCount = initialElements.Count;
            Console.WriteLine("Initial Element Count: " + initialElementCount);

            // Click the "Add Element" button twice
            await Page.GetByRole(AriaRole.Button, new() { Name = "Add Element" }).ClickAsync();
            await Page.GetByRole(AriaRole.Button, new() { Name = "Add Element" }).ClickAsync();

            // Capture a screenshot of the page after clicking "Add Element"
            await Page.ScreenshotAsync(new PageScreenshotOptions
            {
                Path = "screenshot_after_add.png", // Set the path to store the screenshot
            });

            // Count the number of elements after clicking "Add Element"
            var elementsAfterAdd = await Page.QuerySelectorAllAsync(".added-manually");
            var elementCountAfterAdd = elementsAfterAdd.Count;

            // Assert that the element count has increased by 1 after clicking "Add Element"
            Assert.AreEqual(initialElementCount + 2, elementCountAfterAdd);
            Console.WriteLine("Element Count After Add: " + elementCountAfterAdd);

            // Click the "Delete" button
            await Page.GetByRole(AriaRole.Button, new() { Name = "Delete" }).Nth(1).ClickAsync();

            // Capture a screenshot of the page after clicking "Delete"
            await Page.ScreenshotAsync(new PageScreenshotOptions
            {
                Path = "screenshot_after_delete.png", // Set the path to store the screenshot
            });

            // Count the number of elements after clicking "Delete"
            var elementsAfterDelete = await Page.QuerySelectorAllAsync(".added-manually");
            var elementCountAfterDelete = elementsAfterDelete.Count;

            // Assert that the element count has decreased by 1 after clicking "Delete"
            Assert.AreEqual(initialElementCount + 1, elementCountAfterDelete);
            Console.WriteLine("Element Count After Delete: " + elementCountAfterDelete);
        }
    }
}