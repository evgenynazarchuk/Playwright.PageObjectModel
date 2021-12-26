using Microsoft.Playwright;
using Playwright.Synchronous;

namespace Playwright.PageObjectModel.Samples.BaseModels;

public class UIPage : PageModel
{
    public UIPage(IPage page) : base(page)
    {
    }

    public override void Wait()
    {
        //System.Threading.Thread.Sleep(100);
        //Page.WaitForLoadState(LoadState.Load);
        //Page.WaitForLoadState(LoadState.DOMContentLoaded);
        //Page.WaitForLoadState(LoadState.NetworkIdle);
        Page.WaitForLoadState(LoadState.NetworkIdle);
        //Page.WaitForLoadState();
        //System.Console.WriteLine($"Url: {Page.Url}");
        //System.Console.WriteLine($"Title: {Page.Title()}");
    }
}