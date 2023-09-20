namespace ParameterElementInteractions
{
    public class BrowserHandler
    {
        // Global area for common URL and object creation for Playwright and Browser
        protected IPage Page;
        protected IBrowser Browser;

        protected string BaseUrl = "https://the-internet.herokuapp.com/";
        protected string CheckboxUrl = "https://the-internet.herokuapp.com/checkboxes";
        protected string AddRemoveElementsUrl = "https://the-internet.herokuapp.com/add_remove_elements/";
        protected string HoverUrl = "https://the-internet.herokuapp.com/hovers";
        protected string LoginUrl = "https://the-internet.herokuapp.com/login";
        protected string ContextMenuUrl = "https://the-internet.herokuapp.com/context_menu";
        protected string TablesUrl = "https://the-internet.herokuapp.com/tables";
        protected string DynamicContentUrl = "https://the-internet.herokuapp.com/dynamic_content";


        [TestInitialize]
        public async Task Initialize()
        {
            var playwright = await Playwright.CreateAsync();
            Browser = await LaunchBrowser(playwright);
            Page = await Browser.NewPageAsync();
        }

        [TestCleanup]
        public async Task Cleanup()
        {
            await Page.CloseAsync();
            await Browser.CloseAsync();
        }

        //Default Browser behavior using Chromium in view mode
        protected virtual async Task<IBrowser> LaunchBrowser(IPlaywright playwright)
        {
            // Override this method in browser-specific base classes
            return await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false, // Change to false for visible mode
                // Configure Chromium-specific options here
            });
        }

        // Alternate Chromium behavior running headless
        public class ChromiumBase : BrowserHandler
        {
            protected override async Task<IBrowser> LaunchBrowser(IPlaywright playwright)
            {
                return await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = true, // Change to false for visible mode
                                     // Configure Chromium-specific options here
                });
            }
        }

        //Webkit browser running in view mode
        public class WebKitBase : BrowserHandler
        {
            protected override async Task<IBrowser> LaunchBrowser(IPlaywright playwright)
            {
                return await playwright.Webkit.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = false, // Change to false for visible mode
                                      // Configure WebKit-specific options here
                });
            }
        }

        //Webkit browser running in view mode
        public class FirefoxBase : BrowserHandler
        {
            protected override async Task<IBrowser> LaunchBrowser(IPlaywright playwright)
            {
                return await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = false, // Change to false for visible mode
                                      // Configure WebKit-specific options here
                });
            }
        }

    }
}