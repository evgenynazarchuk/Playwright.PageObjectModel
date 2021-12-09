using Microsoft.Playwright;
using Playwright.Synchronous;

namespace TestParallel.ActionExtensions;

public static class ActionSearchSyncExtensions
{
    public static void OpenSearchPage(this IPage page)
    {
        page.Goto("https://www.google.com/?hl=en");
        page.WaitForLoadState(LoadState.NetworkIdle);
    }

    public static void SearchByText(this IPage page, string searchText)
    {
        page.Type("div+input[name='q']", searchText);
        page.Press("div+input[name='q']", "Enter");
        page.WaitForLoadState(LoadState.NetworkIdle);
    }

    public static void ClearSearchText(this IPage page)
    {
        var searchInputElement = page.QuerySelector("div+input[name='q']");
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
