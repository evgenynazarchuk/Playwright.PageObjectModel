using Playwright.Synchronous;
using Microsoft.Playwright;

namespace Playwright.PageObjectModel;

public static class PageModelExtensions
{
    public static TPageModel Screenshot<TPageModel>(this TPageModel pageModel, PageScreenshotOptions? options = null)
        where TPageModel : PageModel

    {
        pageModel.WaitForLoadPage();
        pageModel.Page.Screenshot(options);
        return pageModel;
    }
}
