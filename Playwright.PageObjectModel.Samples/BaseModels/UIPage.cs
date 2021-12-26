using Microsoft.Playwright;

namespace Playwright.PageObjectModel.Samples.BaseModels;

public class UIPage : PageModel
{
    public UIPage(IPage page) : base(page)
    {
    }
}