namespace Doof.Tests.Navigation;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class NavigationTests : PlayWrightTest
{
    [Test]
    public async Task CanNavigateFromHomePageToLoginPage()
    {
        await Page.GotoAsync(Url);

        await Page.GetByTestId("navigate-login").ClickAsync();

        Assert.IsTrue(Page.Url.Contains("login", StringComparison.OrdinalIgnoreCase));
    }

    [Test]
    public async Task CanNavigateFromHomePageToRegisterPage()
    {
        await Page.GotoAsync(Url);

        await Page.GetByTestId("navigate-register").ClickAsync();

        Assert.IsTrue(Page.Url.Contains("register", StringComparison.OrdinalIgnoreCase));
    }
}