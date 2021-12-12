using Microsoft.Playwright;
using Playwright.Synchronous;

namespace Playwright.PageObjectModel;

public static class ElementExtensions
{
    public static string GetComputedStyle(this IElementHandle element, string name)
    {
        var value = element.Evaluate<string>($"e => getComputedStyle(e).{name}", element);
        return value;
    }
}
