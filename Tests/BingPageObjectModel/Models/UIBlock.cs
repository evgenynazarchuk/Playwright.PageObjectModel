using Microsoft.Playwright;
using Playwright.PageObjectModel;

namespace BingPageObjectModel.Models;

public class UIBlock<TPageModel> : BlockModel<TPageModel>
    where TPageModel : PageModel
{
    // default constructor
    public UIBlock(TPageModel pageModel, string selector, PageQuerySelectorOptions? options = null)
        : base(pageModel, selector, options) { }

    // default constructor
    public UIBlock(BlockModel<TPageModel> parentBlockModel, string selector)
        : base(parentBlockModel, selector) { }
}
