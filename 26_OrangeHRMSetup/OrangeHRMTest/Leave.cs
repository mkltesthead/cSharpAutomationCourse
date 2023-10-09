using Microsoft.Playwright;
using NUnit.Framework;
using System.Threading.Tasks;
namespace OrangeHRMTests
{

    public class Leave
    {
        private readonly IPage _page;

        public Leave(IPage page)
        {
            _page = page;
        }

        public async Task Navigate()
        {
            await _page.GotoAsync("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index");
        }

          [Test]
            public async Task TestNavigationToLeaveTab()
            {
                // Navigate to the dashboard page
                await page.GotoAsync("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index");

                // Wait for the "Leave" tab to be visible and clickable (you can change this selector)
                var leaveTab = await page.WaitForSelectorAsync("#menu_leave_viewLeaveModule");

                // Click on the "Leave" tab
                await leaveTab.ClickAsync();

                // Wait for a specific element on the "Leave" page to confirm navigation (you can change this selector)
                await page.WaitForSelectorAsync("#leaveList_chkSearchFilter_checkboxgroup");

                // Assert that you have successfully navigated to the "Leave" tab
                Assert.IsTrue(await page.UrlAsync() == "https://opensource-demo.orangehrmlive.com/web/index.php/leave/viewLeaveList");
            }

            [TearDown]
            public async Task Teardown()
            {
                await browser.CloseAsync();
                playwright.Dispose();
            }
        }
    }