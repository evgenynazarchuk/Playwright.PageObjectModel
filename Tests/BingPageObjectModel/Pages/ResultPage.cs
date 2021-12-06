using BingPageObjectModel.Blocks;
using BingPageObjectModel.Models;
using Microsoft.Playwright;

namespace BingPageObjectModel.Pages;

public class ResultPage : UIPage
{
    // default constructor
    public ResultPage(IPage page)
        : base(page) { }

    // add block models for result page
    public SearchBar<ResultPage> SearchBar => new(this, "form#sb_form");

    public SearchResult<ResultPage> SearchResult => new(this, "div#b_tween");
}
