class Program
{
    static async Task LaunchIPhone(string[] args)
    {
        using var playwright = await Playwright.CreateAsync();

        var browser = await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false, // Change to true for headless mode
            Channel = "chrome",
        });

        var context = await browser.NewContextAsync(new BrowserNewContextOptions
        {
            ViewportSize = new ViewportSize
            {
                Width = 375, // iPhone 12 width
                Height = 812, // iPhone 12 height
            },
            UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 14_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/14.0 Mobile/15E148 Safari/604.1",
        });

        var page = await context.NewPageAsync();

        // Navigate to a website and perform actions
        await page.GotoAsync("https://example.com");
        // Perform your interactions and tests here

        // Close the browser
        await browser.CloseAsync();
    }
}
