/*
 * MIT License
 *
 * Copyright (c) Evgeny Nazarchuk.
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using Microsoft.Playwright;
using Playwright.Synchronous;
using System.Collections.Generic;

namespace Playwright.PageObjectModel;

public static class PageModelActionExtensions
{
    public static TPageModel Click<TPageModel>(this TPageModel pageModel, string selector, PageClickOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.Click(selector, options);
        return pageModel;
    }

    public static TPageModel DblClick<TPageModel>(this TPageModel pageModel, string selector, PageDblClickOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.DblClick(selector, options);
        return pageModel;

    }

    public static TPageModel Type<TPageModel>(this TPageModel pageModel, string selector, string value, PageTypeOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.Type(selector, value, options);
        return pageModel;
    }

    public static TPageModel Check<TPageModel>(this TPageModel pageModel, string selector, PageCheckOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.Check(selector, options);
        return pageModel;
    }

    public static TPageModel Uncheck<TPageModel>(this TPageModel pageModel, string selector, PageUncheckOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.Uncheck(selector, options);
        return pageModel;
    }

    public static TPageModel SetChecked<TPageModel>(this TPageModel pageModel, string selector, bool checkedState, PageSetCheckedOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.SetChecked(selector, checkedState, options);
        return pageModel;
    }

    public static TPageModel Tap<TPageModel>(this TPageModel pageModel, string selector, PageTapOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.Tap(selector, options);
        return pageModel;
    }

    public static TPageModel DragAndDrop<TPageModel>(this TPageModel pageModel, string source, string target, PageDragAndDropOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.DragAndDrop(source, target, options);
        return pageModel;
    }

    public static TPageModel Focus<TPageModel>(this TPageModel pageModel, string selector, PageFocusOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.Focus(selector, options);
        return pageModel;
    }

    public static TPageModel Fill<TPageModel>(this TPageModel pageModel, string selector, string value, PageFillOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.Fill(selector, value, options);
        return pageModel;
    }

    public static TPageModel ReloadPage<TPageModel>(this TPageModel pageModel, PageReloadOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.Reload(options);
        return pageModel;
    }

    public static TPageModel Hover<TPageModel>(this TPageModel pageModel, string selector, PageHoverOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.Hover(selector, options);
        return pageModel;
    }

    public static TPageModel Press<TPageModel>(this TPageModel pageModel, string selector, string key, PagePressOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.Press(selector, key, options);
        return pageModel;
    }

    public static TPageModel SelectOption<TPageModel>(this TPageModel pageModel, string selector, string values, PageSelectOptionOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.SelectOption(selector, values, options);
        return pageModel;
    }

    public static TPageModel SelectOption<TPageModel>(this TPageModel pageModel, string selector, IElementHandle values, PageSelectOptionOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.SelectOption(selector, values, options);
        return pageModel;
    }

    public static TPageModel SelectOption<TPageModel>(this TPageModel pageModel, string selector, IEnumerable<string> values, PageSelectOptionOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.SelectOption(selector, values, options);
        return pageModel;
    }

    public static TPageModel SelectOption<TPageModel>(this TPageModel pageModel, string selector, SelectOptionValue values, PageSelectOptionOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.SelectOption(selector, values, options);
        return pageModel;
    }

    public static TPageModel SelectOption<TPageModel>(this TPageModel pageModel, string selector, IEnumerable<IElementHandle> values, PageSelectOptionOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.SelectOption(selector, values, options);
        return pageModel;
    }

    public static TPageModel SelectOption<TPageModel>(this TPageModel pageModel, string selector, IEnumerable<SelectOptionValue> values, PageSelectOptionOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.SelectOption(selector, values, options);
        return pageModel;
    }

    public static TPageModel SetInputFiles<TPageModel>(this TPageModel pageModel, string selector, string files, PageSetInputFilesOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.SetInputFiles(selector, files, options);
        return pageModel;
    }

    public static TPageModel SetInputFiles<TPageModel>(this TPageModel pageModel, string selector, FilePayload files, PageSetInputFilesOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.SetInputFiles(selector, files, options);
        return pageModel;
    }

    public static TPageModel SetInputFiles<TPageModel>(this TPageModel pageModel, string selector, IEnumerable<string> files, PageSetInputFilesOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.SetInputFiles(selector, files, options);
        return pageModel;
    }

    public static TPageModel SetInputFiles<TPageModel>(this TPageModel pageModel, string selector, IEnumerable<FilePayload> files, PageSetInputFilesOptions? options = null)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.SetInputFiles(selector, files, options);
        return pageModel;
    }

    public static TPageModel Reload<TPageModel>(this TPageModel pageModel)
        where TPageModel : PageModel, IWait
    {
        pageModel.Wait();
        pageModel.Page.Reload();
        return pageModel;
    }
}
