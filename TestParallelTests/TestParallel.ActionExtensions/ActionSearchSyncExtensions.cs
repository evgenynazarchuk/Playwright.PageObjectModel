using Microsoft.Playwright;
using Playwright.Synchronous;

namespace TestParallel.ActionExtensions;

public static class ActionSearchSyncExtensions
{
    public static void OpenSearchPage(this IPage page)
    {
        page.Goto("https://www.bing.com/");
        page.WaitForLoadState(LoadState.NetworkIdle);
    }

    public static void SearchByText(this IPage page, string searchText)
    {
        page.Type("input#sb_form_q", searchText);
        page.Press("input#sb_form_q", "Enter");
        page.WaitForLoadState(LoadState.NetworkIdle);
    }

    public static void ClearSearchText(this IPage page)
    {
        var searchInputElement = page.QuerySelector("input#sb_form_q");
        page.Evaluate("(e) => e.value = ''", searchInputElement);

        //var inputValue = page.Evaluate<string>("(e) => e.value", searchInputElement);
        //var inputLength = inputValue.Length;
        //
        //page.Focus("input#sb_form_q");
        //page.Keyboard.Press("End");
        //for (var i = 0; i < inputLength; i++)
        //{
        //    page.Keyboard.Press("Backspace");
        //}
        //page.Keyboard.Press("Backspace");
        //page.Keyboard.Press("Backspace");
        //page.Keyboard.Press("Backspace");
    }
}
