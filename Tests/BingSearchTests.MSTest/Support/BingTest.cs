using BingPageObjectModel.Pages;
using Microsoft.Playwright.MSTest;
using Playwright.Synchronous;

namespace BingSearchTests.MSTest.Support;

public class BingTest : ContextTest
{
    public MainPage OpenMainPage()
    {
        var Page = NewContextAsync(new Microsoft.Playwright.BrowserNewContextOptions()).GetAwaiter().GetResult().NewPage();
        Page.Goto("https://bing.com");
        return new MainPage(Page);
    }
}
