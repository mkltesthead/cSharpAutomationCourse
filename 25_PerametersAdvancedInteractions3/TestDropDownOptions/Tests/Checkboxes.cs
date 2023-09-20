namespace ParameterElementInteractions.Tests
{
    [TestClass]
    [TestCategory("PositiveTest")]
    [TestCategory("Checkbox")]

    public class FirefoxCheckboxTest : FirefoxBase
    {

        [TestMethod]
        public async Task FirefoxUncheckFirstCheckbox()
        {
            await Page.GotoAsync(CheckboxUrl);

            // Uncheck the first checkbox
            await Page.GetByRole(AriaRole.Checkbox).First.UncheckAsync();

            // Assert that the first checkbox is unchecked
            var isChecked = await Page.GetByRole(AriaRole.Checkbox).First.IsCheckedAsync();
            Assert.IsFalse(isChecked);
        }
    }

    [TestClass]
    [TestCategory("PositiveTest")]
    [TestCategory("Checkbox")]

    public class ChromiumCheckboxTest : ChromiumBase
    {

        [TestMethod]
        public async Task ChromiumUncheckFirstCheckbox()
        {
            await Page.GotoAsync(CheckboxUrl);

            // Uncheck the first checkbox
            await Page.GetByRole(AriaRole.Checkbox).First.UncheckAsync();

            // Assert that the first checkbox is unchecked
            var isChecked = await Page.GetByRole(AriaRole.Checkbox).First.IsCheckedAsync();
            Assert.IsFalse(isChecked);
        }
        [TestMethod]
        [TestCategory("NegativeTest")]
        [TestCategory("Checkbox")]

        public async Task ChromiumUncheckAlreadyUncheckedCheckbox()
        {
            await Page.GotoAsync(CheckboxUrl);

            // Ensure the first checkbox is already unchecked (if not, uncheck it first)
            var isFirstCheckboxChecked = await Page.GetByRole(AriaRole.Checkbox).First.IsCheckedAsync();
            if (isFirstCheckboxChecked)
            {
                await Page.GetByRole(AriaRole.Checkbox).First.UncheckAsync();
            }

            // Attempt to uncheck the already unchecked first checkbox again
            await Page.GetByRole(AriaRole.Checkbox).First.UncheckAsync();

            // Assert that the first checkbox is still unchecked
            var isChecked = await Page.GetByRole(AriaRole.Checkbox).First.IsCheckedAsync();
            Assert.IsFalse(isChecked);
        }
    }
}





