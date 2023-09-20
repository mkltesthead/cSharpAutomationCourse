namespace ParameterElementInteractions.Tests
{
    [TestClass]
    public class PageDropDownTest : FirefoxBase
    {
        [TestMethod]
        [TestCategory("PositiveTest")]
        [TestCategory("SelectDropdown")]

        public async Task SelectDropDownItem()
        {
            string url = BaseUrl + "dropdown";
            await Page.GotoAsync(url);

            // Select an option in the dropdown
            await Page.Locator("#dropdown").SelectOptionAsync(new[] { "1" });

            // Retrieve the text of the selected option(s) using JavaScript
            var selectedOptions = await Page.EvaluateAsync<string[]>(@"() => {
                const selectedOptions = [];
                const options = document.querySelectorAll('#dropdown option[selected]');
                for (const option of options) {
                    selectedOptions.push(option.textContent);
                }
                return selectedOptions;
            }");

            // Check if there is at least one selected option
            Assert.IsTrue(selectedOptions.Length > 0);
            Console.WriteLine($"SelectedOptions Length: {selectedOptions.Length}");

            // Compare the text of the first selected option with the expected value
            Assert.AreEqual("Option 1", selectedOptions[0]);
            Console.WriteLine($"Selected Option text value: {selectedOptions[0]}");
        }
    }
}