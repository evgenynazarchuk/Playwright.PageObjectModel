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

public class ResultPage : UIPage
{
    // default constructor
    public ResultPage(IPage page)
        : base(page) { }

    // add block models for result page
    public SearchBar<ResultPage> SearchBar => new (this, "form#sb_form");

    public SearchResult<ResultPage> SearchResult => new (this, "div#b_tween");
}
