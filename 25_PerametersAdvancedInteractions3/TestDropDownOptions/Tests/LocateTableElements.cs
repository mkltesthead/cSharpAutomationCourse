namespace ParameterElementInteractions.Tests
{

    [TestClass]
    public class TableTest : FirefoxBase
    {
        [TestMethod]
        [TestCategory("PositiveTest")]
        [TestCategory("ValidateTableData")]
        public async Task ValidateTableData()
        {
            await Page.GotoAsync(TablesUrl);

            await Page.GetByRole(AriaRole.Heading, new() { Name = "Example 1" }).ClickAsync();

            // Get text values from specific table cells
            var lastNameCell = await Page.Locator("#table1").GetByRole(AriaRole.Cell, new() { Name = "Bach", Exact = true }).InnerTextAsync();
            var firstNameCell = await Page.Locator("#table1").GetByRole(AriaRole.Cell, new() { Name = "Frank", Exact = true }).InnerTextAsync();
            var emailCell = await Page.Locator("#table1").GetByRole(AriaRole.Cell, new() { Name = "fbach@yahoo.com" }).InnerTextAsync();

            // Perform assertions to validate the text values
            Assert.AreEqual("Bach", lastNameCell);
            Assert.AreEqual("Frank", firstNameCell);
            Assert.AreEqual("fbach@yahoo.com", emailCell);
        }

        [TestMethod]
        [TestCategory("PositiveTest")]
        [TestCategory("ValidateTableTwoData")]
        public async Task ValidateDataInTableTwo()
        {
            await Page.GotoAsync(TablesUrl);
            await Page.GetByRole(AriaRole.Heading, new() { Name = "Example 2" }).ClickAsync();

            // Click Last Name Twice and expect the lowest letter in the Alphabet to be represented
            await Page.Locator("#table2").GetByText("Last Name").ClickAsync();
            await Page.Locator("#table2").GetByText("Last Name").ClickAsync();

            // Validate Last Name
            var lastNameCell = await Page.Locator("#table2").GetByRole(AriaRole.Cell, new() { Name = "Smith", Exact = true }).InnerTextAsync();
            Assert.AreEqual("Smith", lastNameCell);

            // Validate First Name
            var firstNameCell = await Page.Locator("#table2").GetByRole(AriaRole.Cell, new() { Name = "John" }).InnerTextAsync();
            Assert.AreEqual("John", firstNameCell);

            // Validate Email
            var emailCell = await Page.Locator("#table2").GetByRole(AriaRole.Cell, new() { Name = "jsmith@gmail.com" }).InnerTextAsync();
            Assert.AreEqual("jsmith@gmail.com", emailCell);

            // Validate Due Amount
            var dueAmountCell = await Page.GetByRole(AriaRole.Cell, new() { Name = "$50.00" }).Nth(2).InnerTextAsync();
            Assert.AreEqual("$50.00", dueAmountCell);

            // Validate Website
            var websiteCell = await Page.Locator("#table2").GetByRole(AriaRole.Cell, new() { Name = "http://www.jsmith.com" }).InnerTextAsync();
            Assert.AreEqual("http://www.jsmith.com", websiteCell);
        }
    }
}
