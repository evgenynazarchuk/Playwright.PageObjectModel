using Microsoft.Playwright;
using Playwright.Synchronous;

namespace TestParallel.ActionExtensions;

public static class BingSyncActionExtensions
{
    public static void SearchByText(this IPage page, string searchText)
    {
        page.Type("input#sb_form_q", searchText);
        page.Press("input#sb_form_q", "Enter");
        page.WaitForLoadStateAsync(LoadState.NetworkIdle);
    }

    public static void ClearSearchText(this IPage page)
    {
        var searchInputElement = page.QuerySelector("input#sb_form_q");
        var inputValue = page.Evaluate<string>("(e) => e.value", searchInputElement);
        var inputLength = inputValue.Length;

        page.Focus("input#sb_form_q");
        page.Keyboard.Press("End");
        for (var i = 0; i < inputLength; i++)
        {
            page.Keyboard.Press("Backspace");
        }
    }

    public static void OpenBingCom(this IPage page)
    {
        page.Goto("https://bing.com");
        page.WaitForLoadState(LoadState.NetworkIdle);
    }
}
