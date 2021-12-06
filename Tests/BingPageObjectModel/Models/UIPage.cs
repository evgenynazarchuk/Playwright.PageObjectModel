using Microsoft.Playwright;
using Playwright.PageObjectModel;
using Playwright.Synchronous;

namespace BingPageObjectModel.Models;

public class UIPage : PageModel
{
    // default constructor
    public UIPage(IPage page)
        : base(page) { }

    public override void WaitForLoadPage()
    {
        Page.WaitForLoadState(LoadState.Load);
        //Page.WaitForLoadState(LoadState.DOMContentLoaded);
        //Page.WaitForLoadState(LoadState.NetworkIdle);
    }
}

