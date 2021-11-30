using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playwright.PageObjectModel;
using Playwright.FluentAssertions;
using Microsoft.Playwright;

namespace BingPageObjectModel.Models;

public class UIBlock<TPageModel> : BlockModel<TPageModel>
    where TPageModel : PageModel
{
    public UIBlock(TPageModel pageModel, string selector, PageQuerySelectorOptions? options = null)
        : base(pageModel, selector, options) { }

    public UIBlock(BlockModel<TPageModel> parentBlockModel, string selector)
        : base(parentBlockModel, selector) { }
}
