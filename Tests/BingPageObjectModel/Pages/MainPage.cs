using BingPageObjectModel.Blocks;
using BingPageObjectModel.Models;
using Microsoft.Playwright;

namespace BingPageObjectModel.Pages;

public class MainPage : UIPage
{
    // default constructor
    public MainPage(IPage page)
        : base(page) { }

    // add search bar for main page
    public SearchBar<MainPage> SearchBar => new(this, "form#sb_form");
}
