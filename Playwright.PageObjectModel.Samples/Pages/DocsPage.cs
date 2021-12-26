using Playwright.PageObjectModel.Samples.BaseModels;
using Microsoft.Playwright;
using Playwright.PageObjectModel.Samples.Blocks;

namespace Playwright.PageObjectModel.Samples.Pages;

public class DocsPage : UIPage
{
    public DocsPage(IPage page) : base(page)
    {
    }

    public Menu<DocsPage> Menu => new(this, "//nav");
}
