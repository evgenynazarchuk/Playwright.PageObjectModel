using BingPageObjectModel.Pages;
using Microsoft.Playwright.NUnit;
using Playwright.Synchronous;

namespace BingSearchTests.NUnit.Support;

public class BingTest : ContextTest
{
    public MainPage OpenMainPage()
    {
        //Desktop Chrome
        //Galaxy S5
        var options = Playwright.Devices["Desktop Chrome"];
        options.Locale = "en-US";

        var context = this.NewContext(options).GetAwaiter().GetResult();
        var page = context.NewPage();

        page.Goto("https://bing.com");

        return new MainPage(page);
    }
}
