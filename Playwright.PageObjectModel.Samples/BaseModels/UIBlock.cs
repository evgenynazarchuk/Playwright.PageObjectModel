using Microsoft.Playwright;
using Playwright.PageObjectModel;

namespace Playwright.PageObjectModel.Samples.BaseModels;

public class UIBlock<TPageModel> : BlockModel<TPageModel>
    where TPageModel : PageModel
{
    // create default constructors
    public UIBlock(TPageModel pageModel, IElementHandle element) : base(pageModel, element)
    {
    }

    public UIBlock(BlockModel<TPageModel> parentBlockModel, IElementHandle element) : base(parentBlockModel, element)
    {
    }

    public UIBlock(BlockModel<TPageModel> parentBlockModel, string selector, ElementHandleWaitForSelectorOptions? waitOptions = null) : base(parentBlockModel, selector, waitOptions)
    {
    }

    public UIBlock(TPageModel pageModel, string selector, PageWaitForSelectorOptions? waitOptions = null, PageQuerySelectorOptions? queryOptions = null) : base(pageModel, selector, waitOptions, queryOptions)
    {
    }
}