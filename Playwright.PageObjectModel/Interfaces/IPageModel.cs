using Microsoft.Playwright;

namespace Playwright.PageObjectModel;

public interface IPageModel
{
    IPage Page { get; }
}