using BingPageObjectModel.Models;
using BingPageObjectModel.Pages;
using Microsoft.Playwright;
using Playwright.PageObjectModel;

namespace BingPageObjectModel.Blocks;

public class SearchBar<TPageModel> : UIBlock<TPageModel>
    where TPageModel : PageModel
{
    // default constructor
    public SearchBar(TPageModel pageModel, string selector, PageQuerySelectorOptions? options = null)
        : base(pageModel, selector, options) { }

    // default constructor
    public SearchBar(BlockModel<TPageModel> parentBlockModel, string selector)
        : base(parentBlockModel, selector) { }

    // get text from search input bar
    public string SearchText => this.InputValue("input#sb_form_q");

    // return new page
    public ResultPage SearchByText(string searchText)
    {
        ClearInput("input");
        Type("input", searchText);
        Press("Enter", "input");
        return new ResultPage(this.PageModel.Page);
    }
}
