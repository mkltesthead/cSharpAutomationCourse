public class LoginPage
{
    private readonly IPage _page;

    public LoginPage(IPage page)
    {
        _page = page;
    }

    private IElementHandle UsernameInput => (IElementHandle)_page.Locator("input[name='username']");
    private IElementHandle PasswordInput => (IElementHandle)_page.Locator("input[name='password']");
    private IElementHandle LoginButton => (IElementHandle)_page.Locator("button[type=submit]");

    public async Task EnterUsername(string username)
    {
        await UsernameInput.FillAsync(username);
    }

    public async Task EnterPassword(string password)
    {
        await PasswordInput.FillAsync(password);
    }

    public async Task ClickLoginButton()
    {
        await LoginButton.ClickAsync();
    }
}
