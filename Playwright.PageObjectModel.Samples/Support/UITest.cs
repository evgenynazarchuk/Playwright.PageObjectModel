using Microsoft.Playwright.NUnit;
using Playwright.Synchronous;
using Playwright.PageObjectModel.Samples.Pages;

namespace Playwright.PageObjectModel.Samples.Support;

public class UITest : ContextTest
{
    public StartPage Open()
    {
        var page = Context.NewPage();
        page.Goto("https://playwright.dev/");
        var pom = new StartPage(page);
        return pom;
    }
}
