namespace RefactoredElementInteractionsMSTest.Tests
{
    [TestClass]
    public class SecureAreaLoginTests : FirefoxBase
    {
        [TestMethod]
        [TestCategory("PositiveTest")]
        [TestCategory("LoginTest")]

        public async Task SecureAreaLoginTest()
        {
            await Page.GotoAsync(LoginUrl);

            await Page.GetByLabel("Username").FillAsync("tomsmith");
            await Page.GetByLabel("Password").FillAsync("SuperSecretPassword!");
            await Page.GetByRole(AriaRole.Button, new() { Name = " Login" }).ClickAsync();

            // Assert that the page contains the expected text
            var pageText = await Page.TextContentAsync(".example");
            Assert.IsNotNull(pageText);
            Console.WriteLine("Page Text: " + pageText);
        }

        [TestMethod]
        [TestCategory("NegativeTest")]
        [TestCategory("LoginTest")]

        public async Task SecureAreaLoginIncorrectCredentials()
        {
            await Page.GotoAsync(LoginUrl);

            // Fill in incorrect credentials
            await Page.GetByLabel("Username").FillAsync("invalidUsername");
            await Page.GetByLabel("Password").FillAsync("InvalidPassword");
            await Page.GetByRole(AriaRole.Button, new() { Name = " Login" }).ClickAsync();

            // Assert that the login failed and an error message is displayed
            var errorMessage = await Page.TextContentAsync(".flash.error");
            Assert.IsNotNull(errorMessage);
            Console.WriteLine("Error Message: " + errorMessage);
        }
    }
}