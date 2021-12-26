using Microsoft.Playwright;
using Playwright.PageObjectModel;
using Playwright.Synchronous;

namespace Playwright.PageObjectModel.Samples.BaseModels;

public class UIPage : PageModel
{
    // create default constructor
    public UIPage(IPage page) : base(page)
    {
    }

    public override void Wait()
    {
        //Page.WaitForLoadState(LoadState.Load);
        Page.WaitForLoadState(LoadState.DOMContentLoaded);
        //Page.WaitForLoadState(LoadState.NetworkIdle);
    }
}