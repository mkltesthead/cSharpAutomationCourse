namespace RefactoredElementInteractionsMSTest
{
    [TestClass]
    public class SecureAreaLogin : TestBase
    {
        [TestMethod]
        public async Task SecureAreaLoginTest()
        {
            string url = BaseUrl + "login";
            await Page.GotoAsync(url);

            await Page.GetByLabel("Username").FillAsync("tomsmith");

            await Page.GetByLabel("Password").FillAsync("SuperSecretPassword!");

            await Page.GetByRole(AriaRole.Button, new() { Name = " Login" }).ClickAsync();

            // Assert that the page contains the expected text
            var pageText = await Page.TextContentAsync(".example");
            Assert.IsNotNull(pageText);
            Console.WriteLine("Page Text: " + pageText);
        }
    }
}