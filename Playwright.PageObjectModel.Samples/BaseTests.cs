using NUnit.Framework;
using Microsoft.Playwright.NUnit;
using Playwright.Synchronous;
using Microsoft.Playwright;

namespace Playwright.PageObjectModel.Samples;

public class BaseTests : PageTest
{
    [Test]
    public void Test()
    {
        Page.Goto("https://playwright.dev/");

        //Page.WaitForLoadState(LoadState.NetworkIdle);
        Page.Click("//a[text()='Docs']");
        Page.WaitForLoadState(LoadState.NetworkIdle);

        var title = Page.Title();
        Assert.AreEqual("Getting started | Playwright", title);
    }
}
