using Microsoft.Playwright;
using Playwright.Synchronous;
using System.Collections.Generic;

namespace Playwright.PageObjectModel.ActionExtensions;

public static class PageModelActionExtensions
{
    public static TPageModel Click<TPageModel>(this TPageModel pageModel, string selector, PageClickOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Click(selector, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }

    public static TPageModel DblClick<TPageModel>(this TPageModel pageModel, string selector, PageDblClickOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.DblClick(selector, options);
        pageModel.WaitForLoadPage();
        return pageModel;

    }

    public static TPageModel Type<TPageModel>(this TPageModel pageModel, string selector, string value, PageTypeOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.Type(selector, value, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }

    public static TPageModel Check<TPageModel>(this TPageModel pageModel, string selector, PageCheckOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.Check(selector, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }

    public static TPageModel Uncheck<TPageModel>(this TPageModel pageModel, string selector, PageUncheckOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.Uncheck(selector, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }

    public static TPageModel SetChecked<TPageModel>(this TPageModel pageModel, string selector, bool checkedState, PageSetCheckedOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.SetChecked(selector, checkedState, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }

    public static TPageModel Tap<TPageModel>(this TPageModel pageModel, string selector, PageTapOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.Tap(selector, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }

    public static TPageModel DragAndDrop<TPageModel>(this TPageModel pageModel, string source, string target, PageDragAndDropOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.DragAndDrop(source, target, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }

    public static TPageModel Focus<TPageModel>(this TPageModel pageModel, string selector, PageFocusOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.Focus(selector, options);
        return pageModel;
    }

    public static TPageModel Fill<TPageModel>(this TPageModel pageModel, string selector, string value, PageFillOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.Fill(selector, value, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }

    public static TPageModel ReloadPage<TPageModel>(this TPageModel pageModel, PageReloadOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.Page.ReloadAsync(options).GetAwaiter().GetResult();
        return pageModel;
    }

    public static TPageModel Hover<TPageModel>(this TPageModel pageModel, string selector, PageHoverOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.Hover(selector, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }

    public static TPageModel Press<TPageModel>(this TPageModel pageModel, string selector, string key, PagePressOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.Press(selector, key, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }

    public static TPageModel SelectOption<TPageModel>(this TPageModel pageModel, string selector, string values, PageSelectOptionOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.SelectOption(selector, values, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }

    public static TPageModel SelectOption<TPageModel>(this TPageModel pageModel, string selector, IElementHandle values, PageSelectOptionOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.SelectOption(selector, values, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }

    public static TPageModel SelectOption<TPageModel>(this TPageModel pageModel, string selector, IEnumerable<string> values, PageSelectOptionOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.SelectOption(selector, values, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }

    public static TPageModel SelectOption<TPageModel>(this TPageModel pageModel, string selector, SelectOptionValue values, PageSelectOptionOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.SelectOption(selector, values, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }

    public static TPageModel SelectOption<TPageModel>(this TPageModel pageModel, string selector, IEnumerable<IElementHandle> values, PageSelectOptionOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.SelectOption(selector, values, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }

    public static TPageModel SelectOption<TPageModel>(this TPageModel pageModel, string selector, IEnumerable<SelectOptionValue> values, PageSelectOptionOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        var result = pageModel.Page.SelectOption(selector, values, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }

    public static TPageModel SetInputFiles<TPageModel>(this TPageModel pageModel, string selector, string files, PageSetInputFilesOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.SetInputFiles(selector, files, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }

    public static TPageModel SetInputFiles<TPageModel>(this TPageModel pageModel, string selector, FilePayload files, PageSetInputFilesOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.SetInputFiles(selector, files, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }

    public static TPageModel SetInputFiles<TPageModel>(this TPageModel pageModel, string selector, IEnumerable<string> files, PageSetInputFilesOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.SetInputFiles(selector, files, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }

    public static TPageModel SetInputFiles<TPageModel>(this TPageModel pageModel, string selector, IEnumerable<FilePayload> files, PageSetInputFilesOptions? options = null)
        where TPageModel : PageModel, IWaiter
    {
        pageModel.WaitForLoadPage();
        pageModel.Page.SetInputFiles(selector, files, options);
        pageModel.WaitForLoadPage();
        return pageModel;
    }
}
