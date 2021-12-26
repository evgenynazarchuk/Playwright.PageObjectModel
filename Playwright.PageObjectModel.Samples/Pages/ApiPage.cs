using Playwright.PageObjectModel.Samples.BaseModels;
using Microsoft.Playwright;
using Playwright.PageObjectModel.Samples.Blocks;

namespace Playwright.PageObjectModel.Samples.Pages;

public class ApiPage : UIPage
{
    public ApiPage(IPage page) : base(page)
    {
    }

    public Menu<ApiPage> Menu => new(this, "//nav");
}
