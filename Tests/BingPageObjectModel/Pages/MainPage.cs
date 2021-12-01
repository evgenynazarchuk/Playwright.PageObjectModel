using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Playwright.PageObjectModel;
using Playwright.FluentAssertions;
using Playwright.Synchronous;
using BingPageObjectModel.Blocks;
using BingPageObjectModel.Models;

namespace BingPageObjectModel.Pages;

public class MainPage : UIPage
{
    // default constructor
    public MainPage(IPage page)
        : base(page) { }

    // add search bar for main page
    public SearchBar<MainPage> SearchBar => new (this, "form#sb_form");
}
