using Microsoft.Playwright;

namespace Playwright.PageObjectModel;

public interface IBlockModel
{
    IElementHandle Block { get; }

    IPage Page { get; }
}