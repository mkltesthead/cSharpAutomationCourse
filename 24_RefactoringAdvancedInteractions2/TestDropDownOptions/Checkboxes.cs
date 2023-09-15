namespace RefactoredElementInteractionsMSTest
{
    [TestClass]
    public class CheckboxTest : TestBase
    {

        [TestMethod]
        public async Task UncheckFirstCheckbox()
        {
            string url = BaseUrl + "checkboxes";
            await Page.GotoAsync(url);

            // Uncheck the first checkbox
            await Page.GetByRole(AriaRole.Checkbox).First.UncheckAsync();

            // Assert that the first checkbox is unchecked
            var isChecked = await Page.GetByRole(AriaRole.Checkbox).First.IsCheckedAsync();
            Assert.IsFalse(isChecked);
        }
    }
}

