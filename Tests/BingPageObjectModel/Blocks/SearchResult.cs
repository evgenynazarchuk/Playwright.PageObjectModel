using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Playwright.PageObjectModel;
using Playwright.FluentAssertions;
using Playwright.Synchronous;
using BingPageObjectModel.Models;

namespace BingPageObjectModel.Blocks;

public class SearchResult<TPageModel> : UIBlock<TPageModel>
    where TPageModel : PageModel
{
    // default constructor
    public SearchResult(TPageModel pageModel, string selector, PageQuerySelectorOptions? options = null)
        : base(pageModel, selector, options) { }

    // default constructor
    public SearchResult(BlockModel<TPageModel> parentBlockModel, string selector)
        : base(parentBlockModel, selector) { }

    // get text from label
    public string ResultCount => this.TextContent("span.sb_count");
}