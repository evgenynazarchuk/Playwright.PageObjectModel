using Playwright.PageObjectModel.Samples.BaseModels;
using Microsoft.Playwright;
using Playwright.PageObjectModel.Samples.Blocks;

namespace Playwright.PageObjectModel.Samples.Pages;

public class StartPage : UIPage
{
    public StartPage(IPage page) : base(page)
    {
    }

    public Menu<StartPage> Menu => new(this, "//nav");
}
