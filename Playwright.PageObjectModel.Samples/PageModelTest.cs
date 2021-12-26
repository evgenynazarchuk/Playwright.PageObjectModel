using NUnit.Framework;
using Microsoft.Playwright.NUnit;
using Playwright.PageObjectModel.Samples.Support;
using Playwright.FluentAssertions;
using Playwright.Synchronous;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace Playwright.PageObjectModel.Samples;

public class PageModelTest : PageTest
{
    [Test]
    public void Test()
    {
        Page.Goto("https://playwright.dev/");
        var page = new PlayWrightModel(Page);

        page.Click("//a[text()='Docs']");
        page.Wait();
        page.Page.Should().HaveTitle("Getting started | Playwright");
    }
}

public class PlayWrightModel : PageModel
{
    public PlayWrightModel(IPage page) : base(page) { }

    public override void Wait()
    {
        Page.WaitForLoadState(LoadState.NetworkIdle);
    }
}



public interface IBasePage
{
    IPage Page { get; }
}

public class BasePage : IBasePage
{
    public IPage Page { get; }

    public BasePage(IPage page)
    {
        Page = page;
    }

    public virtual void Wait()
    {
    }

    public virtual void Click(string selector)
    {
        Page.Click(selector);
        Wait();
    }
}

public class PlayWrightTestPage : BasePage
{
    public PlayWrightTestPage(IPage page) : base(page) { }

    public override void Wait()
    {
        Page.WaitForLoadState(LoadState.NetworkIdle);
    }
}