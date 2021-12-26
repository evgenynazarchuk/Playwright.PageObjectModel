using Playwright.PageObjectModel.Samples.BaseModels;
using Playwright.PageObjectModel.Samples.Pages;
using Playwright.Synchronous;
using Microsoft.Playwright;

namespace Playwright.PageObjectModel.Samples.Blocks;

public class Menu<TPageModel> : UIBlock<TPageModel>
    where TPageModel : PageModel
{
    public Menu(TPageModel pageModel, IElementHandle element) : base(pageModel, element)
    {
    }

    public Menu(BlockModel<TPageModel> parentBlockModel, IElementHandle element) : base(parentBlockModel, element)
    {
    }

    public Menu(BlockModel<TPageModel> parentBlockModel, string selector, ElementHandleWaitForSelectorOptions? waitOptions = null) : base(parentBlockModel, selector, waitOptions)
    {
    }

    public Menu(TPageModel pageModel, string selector, PageWaitForSelectorOptions? waitOptions = null, PageQuerySelectorOptions? queryOptions = null) : base(pageModel, selector, waitOptions, queryOptions)
    {
    }

    public TPageModel ToggleTheme()
    {
        Click(".toggleTrackThumb_xI_Z");
        return PageModel;
    }

    public DocsPage Docs()
    {
        Click("//a[text()='Docs']");
        return new DocsPage(this.Page);
    }

    public ApiPage API()
    {
        Click("//a[text()='API']");
        return new ApiPage(this.Page);
    }
}