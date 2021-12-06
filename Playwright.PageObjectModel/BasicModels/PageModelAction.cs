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
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Playwright.PageObjectModel;

public partial class PageModel
{
    public virtual void Open(string url, PageGotoOptions? options = null)
    {
        this.Page.GotoAsync(url, options).GetAwaiter().GetResult();
    }

    public virtual void WaitForLoadPage() { }

    protected virtual IElementHandle FindElement(string selector, PageQuerySelectorOptions? options = null, string exceptionMessage = "Element not found")
    {
        this.WaitForLoadPage();
        var element = this.Page.QuerySelectorAsync(selector, options).GetAwaiter().GetResult();
        if (element is null) throw new ApplicationException(exceptionMessage);
        else return element;
    }

    protected virtual IElementHandle? FindElementOrNull(string selector, PageQuerySelectorOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = this.Page.QuerySelector(selector, options);
        return element;
    }

    protected virtual IReadOnlyCollection<IElementHandle> FindElements(string selector)
    {
        this.WaitForLoadPage();
        var elements = this.Page.QuerySelectorAll(selector);
        return elements;
    }

    protected virtual TBlockModel FindBlock<TBlockModel>(string selector)
        where TBlockModel : class
    {
        this.WaitForLoadPage();

        var blockType = typeof(TBlockModel);
        var ctorArgs = new[] { this.GetType(), typeof(string) };

        var ctor = blockType.GetConstructor(ctorArgs);
        if (ctor is null) throw new ApplicationException("Block Model not found");

        var block = ctor.Invoke(new[] { this, (object)selector });
        if (block is null) throw new ApplicationException("Block Model not created");

        return (TBlockModel)block;
    }

    protected virtual TBlockModel? FindBlockOrNull<TBlockModel>(string selector)
        where TBlockModel : class
    {
        this.WaitForLoadPage();

        var blockType = typeof(TBlockModel);
        var ctorArgs = new[] { this.GetType(), typeof(string) };

        var ctor = blockType.GetConstructor(ctorArgs);
        if (ctor is null) throw new ApplicationException("Block Model not found");

        object? block = null;
        try
        {
            block = ctor.Invoke(new[] { this, (object)selector });
        }
        catch { }

        return (TBlockModel?)block;
    }

    protected virtual IReadOnlyCollection<TBlockModel> FindBlocks<TBlockModel>(string selector)
        where TBlockModel : class
    {
        this.WaitForLoadPage();

        var elements = this.Page.QuerySelectorAll(selector);
        var blocks = new List<TBlockModel>();

        foreach (var element in elements)
        {
            var blockType = typeof(TBlockModel);
            var ctorArgs = new[] { this.GetType(), typeof(string) };
            var ctor = blockType.GetConstructor(ctorArgs);
            if (ctor is null) throw new ApplicationException("Block Model not found");

            var block = ctor.Invoke(new[] { this, (object)selector });

            blocks.Add((TBlockModel)block);
        }

        return blocks;
    }

    protected virtual IElementHandle? QuerySelector(string selector, PageQuerySelectorOptions? options = null)
    {
        this.WaitForLoadPage();
        return this.Page.QuerySelector(selector, options);
    }

    protected virtual IReadOnlyList<IElementHandle> QuerySelectorAll(string selector)
    {
        this.WaitForLoadPage();
        return this.Page.QuerySelectorAll(selector);
    }

    protected virtual void Click(string selector, PageClickOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.Click(selector, options);
        this.WaitForLoadPage();
    }

    protected virtual TReturnPage Click<TReturnPage>(string selector, PageClickOptions? options = null)
        where TReturnPage : PageModel
    {
        this.Click(selector, options);

        var ctor = typeof(TReturnPage).GetConstructor(new[] { typeof(IPage) });
        if (ctor is null) throw new ApplicationException("Page Model not found");

        var returnPage = ctor.Invoke(new[] { this.Page });
        return (TReturnPage)returnPage;
    }

    protected virtual void DblClick(string selector, PageDblClickOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.DblClick(selector, options);
        this.WaitForLoadPage();
    }

    protected virtual void Type(string selector, string value, PageTypeOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.Type(selector, value, options);
        this.WaitForLoadPage();
    }

    protected virtual void Check(string selector, PageCheckOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.Check(selector, options);
        this.WaitForLoadPage();
    }

    protected virtual void Uncheck(string selector, PageUncheckOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.Uncheck(selector, options);
        this.WaitForLoadPage();
    }

    protected virtual void SetChecked(string selector, bool checkedState, PageSetCheckedOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.SetChecked(selector, checkedState, options);
        this.WaitForLoadPage();
    }

    protected virtual void Tap(string selector, PageTapOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.Tap(selector, options);
        this.WaitForLoadPage();
    }

    protected virtual void DragAndDrop(string source, string target, PageDragAndDropOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.DragAndDrop(source, target, options);
        this.WaitForLoadPage();
    }

    protected virtual void Focus(string selector, PageFocusOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.Focus(selector, options);
    }

    protected virtual void FillAsync(string selector, string value, PageFillOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.Fill(selector, value, options);
        this.WaitForLoadPage();
    }

    protected virtual TPageModel GoBack<TPageModel>(PageGoBackOptions? options = null)
        where TPageModel : PageModel
    {
        this.Page.GoBack(options);

        var ctor = typeof(TPageModel).GetConstructor(new[] { typeof(IPage) });
        if (ctor is null) throw new ApplicationException("Page Model not found");
        var returnPage = ctor.Invoke(new[] { this.Page });

        return (TPageModel)returnPage;
    }

    protected virtual TPageModel GoForward<TPageModel>(PageGoForwardOptions? options = null)
        where TPageModel : PageModel
    {
        this.Page.GoForward(options);

        var ctor = typeof(TPageModel).GetConstructor(new[] { typeof(IPage) });
        if (ctor is null) throw new ApplicationException("Page Model not found");
        var returnPage = ctor.Invoke(new[] { this.Page });

        return (TPageModel)returnPage;
    }

    protected virtual TPageModel Goto<TPageModel>(string url, PageGotoOptions? options = null)
        where TPageModel : PageModel
    {
        this.Page.Goto(url, options);

        var ctor = typeof(TPageModel).GetConstructor(new[] { typeof(IPage) });
        if (ctor is null) throw new ApplicationException("Page Model not found");
        var returnPage = ctor.Invoke(new[] { this.Page });

        return (TPageModel)returnPage;
    }

    protected virtual TPageModel ReloadPage<TPageModel>(PageReloadOptions? options = null)
        where TPageModel : PageModel
    {
        this.Page.ReloadAsync(options).GetAwaiter().GetResult();

        var ctor = typeof(TPageModel).GetConstructor(new[] { typeof(IPage) });
        if (ctor is null) throw new ApplicationException("Page Model not found");
        var returnPage = ctor.Invoke(new[] { this.Page });

        return (TPageModel)returnPage;
    }

    protected virtual void Hover(string selector, PageHoverOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.Hover(selector, options);
        this.WaitForLoadPage();
    }

    protected virtual void Press(string selector, string key, PagePressOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.Press(selector, key, options);
        this.WaitForLoadPage();
    }

    protected virtual IReadOnlyList<string> SelectOption(string selector, string values, PageSelectOptionOptions? options = null)
    {
        this.WaitForLoadPage();
        var result = this.Page.SelectOption(selector, values, options);
        this.WaitForLoadPage();
        return result;
    }

    protected virtual IReadOnlyList<string> SelectOption(string selector, IElementHandle values, PageSelectOptionOptions? options = null)
    {
        this.WaitForLoadPage();
        var result = this.Page.SelectOption(selector, values, options);
        this.WaitForLoadPage();
        return result;
    }

    protected virtual IReadOnlyList<string> SelectOption(string selector, IEnumerable<string> values, PageSelectOptionOptions? options = null)
    {
        this.WaitForLoadPage();
        var result = this.Page.SelectOption(selector, values, options);
        this.WaitForLoadPage();
        return result;
    }

    protected virtual IReadOnlyList<string> SelectOption(string selector, SelectOptionValue values, PageSelectOptionOptions? options = null)
    {
        this.WaitForLoadPage();
        var result = this.Page.SelectOption(selector, values, options);
        this.WaitForLoadPage();
        return result;
    }

    protected virtual IReadOnlyList<string> SelectOption(string selector, IEnumerable<IElementHandle> values, PageSelectOptionOptions? options = null)
    {
        this.WaitForLoadPage();
        var result = this.Page.SelectOption(selector, values, options);
        this.WaitForLoadPage();
        return result;
    }

    protected virtual IReadOnlyList<string> SelectOption(string selector, IEnumerable<SelectOptionValue> values, PageSelectOptionOptions? options = null)
    {
        this.WaitForLoadPage();
        var result = this.Page.SelectOption(selector, values, options);
        this.WaitForLoadPage();
        return result;
    }

    protected virtual void SetInputFiles(string selector, string files, PageSetInputFilesOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.SetInputFiles(selector, files, options);
        this.WaitForLoadPage();
    }

    protected virtual void SetInputFiles(string selector, FilePayload files, PageSetInputFilesOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.SetInputFiles(selector, files, options);
        this.WaitForLoadPage();
    }

    protected virtual void SetInputFiles(string selector, IEnumerable<string> files, PageSetInputFilesOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.SetInputFiles(selector, files, options);
        this.WaitForLoadPage();
    }

    protected virtual void SetInputFiles(string selector, IEnumerable<FilePayload> files, PageSetInputFilesOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.SetInputFiles(selector, files, options);
        this.WaitForLoadPage();
    }

    protected virtual void AddInitScript(string? script = null, string? scriptPath = null)
    {
        this.WaitForLoadPage();
        this.Page.AddInitScript(script, scriptPath);
    }

    protected virtual void AddScriptTag(PageAddScriptTagOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.AddScriptTag(options);
    }

    protected virtual void AddStyleTag(PageAddStyleTagOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.AddStyleTag(options);
    }

    protected virtual void BringToFront()
    {
        this.WaitForLoadPage();
        this.Page.BringToFront();
    }

    protected virtual string Content()
    {
        this.WaitForLoadPage();
        return this.Page.Content();
    }

    protected virtual void DispatchEvent(string selector, string type, object? eventInit = null, PageDispatchEventOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.DispatchEvent(selector, type, eventInit, options); ;
    }

    protected virtual void EmulateMedia(PageEmulateMediaOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.EmulateMedia(options);
    }

    protected virtual void EvalOnSelectorAll(string selector, string expression, object? arg = null)
    {
        this.WaitForLoadPage();
        this.Page.EvalOnSelectorAll(selector, expression, arg);
    }

    protected virtual void EvalOnSelectorAll<T>(string selector, string expression, object? arg = null)
    {
        this.WaitForLoadPage();
        this.Page.EvalOnSelectorAll<T>(selector, expression, arg);
    }

    protected virtual void EvalOnSelector(string selector, string expression, object? arg = null)
    {
        this.WaitForLoadPage();
        this.Page.EvalOnSelector(selector, expression, arg);
    }

    protected virtual void EvalOnSelector<T>(string selector, string expression, object? arg = null, PageEvalOnSelectorOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.EvalOnSelector<T>(selector, expression, arg, options);
    }

    protected virtual void Evaluate(string expression, object? arg = null)
    {
        this.WaitForLoadPage();
        this.Page.Evaluate(expression, arg);
    }

    protected virtual void Evaluate<T>(string expression, object? arg = null)
    {
        this.WaitForLoadPage();
        this.Page.Evaluate<T>(expression, arg);
    }

    protected virtual void EvaluateHandle(string expression, object? arg = null)
    {
        this.WaitForLoadPage();
        this.Page.EvaluateHandle(expression, arg);
    }

    protected virtual void ExposeBinding(string name, Action<BindingSource> callback)
    {
        this.Page.ExposeBinding(name, callback);
    }

    protected virtual void ExposeBinding(string name, Action callback, PageExposeBindingOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.ExposeBinding(name, callback, options);
    }

    protected virtual void ExposeBinding<T>(string name, Action<BindingSource, T> callback)
    {
        this.WaitForLoadPage();
        this.Page.ExposeBinding<T>(name, callback);
    }

    protected virtual void ExposeBinding<TResult>(string name, Func<BindingSource, TResult> callback)
    {
        this.WaitForLoadPage();
        this.Page.ExposeBinding<TResult>(name, callback);
    }

    protected virtual void ExposeBinding<TResult>(string name, Func<BindingSource, IJSHandle, TResult> callback)
    {
        this.WaitForLoadPage();
        this.Page.ExposeBinding<TResult>(name, callback);
    }

    protected virtual void ExposeBinding<T, TResult>(string name, Func<BindingSource, T, TResult> callback)
    {
        this.WaitForLoadPage();
        this.Page.ExposeBinding<T, TResult>(name, callback);
    }

    protected virtual void ExposeBinding<T1, T2, TResult>(string name, Func<BindingSource, T1, T2, TResult> callback)
    {
        this.WaitForLoadPage();
        this.Page.ExposeBinding<T1, T2, TResult>(name, callback);
    }

    protected virtual void ExposeBinding<T1, T2, T3, TResult>(string name, Func<BindingSource, T1, T2, T3, TResult> callback)
    {
        this.WaitForLoadPage();
        this.Page.ExposeBinding<T1, T2, T3, TResult>(name, callback);
    }

    protected virtual void ExposeBinding<T1, T2, T3, T4, TResult>(string name, Func<BindingSource, T1, T2, T3, T4, TResult> callback)
    {
        this.WaitForLoadPage();
        this.Page.ExposeBinding<T1, T2, T3, T4, TResult>(name, callback);
    }

    protected virtual void ExposeFunction(string name, Action callback)
    {
        this.WaitForLoadPage();
        this.Page.ExposeFunction(name, callback);
    }

    protected virtual void ExposeFunction<T>(string name, Action<T> callback)
    {
        this.WaitForLoadPage();
        this.Page.ExposeFunction<T>(name, callback);
    }

    protected virtual void ExposeFunction<TResult>(string name, Func<TResult> callback)
    {
        this.WaitForLoadPage();
        this.Page.ExposeFunction<TResult>(name, callback);
    }

    protected virtual void ExposeFunction<T, TResult>(string name, Func<T, TResult> callback)
    {
        this.WaitForLoadPage();
        this.Page.ExposeFunction<T, TResult>(name, callback);
    }

    protected virtual void ExposeFunction<T1, T2, TResult>(string name, Func<T1, T2, TResult> callback)
    {
        this.WaitForLoadPage();
        this.Page.ExposeFunction<T1, T2, TResult>(name, callback);
    }

    protected virtual void ExposeFunction<T1, T2, T3, TResult>(string name, Func<T1, T2, T3, TResult> callback)
    {
        this.WaitForLoadPage();
        this.Page.ExposeFunction<T1, T2, T3, TResult>(name, callback);
    }

    protected virtual void ExposeFunction<T1, T2, T3, T4, TResult>(string name, Func<T1, T2, T3, T4, TResult> callback)
    {
        this.WaitForLoadPage();
        this.Page.ExposeFunction<T1, T2, T3, T4, TResult>(name, callback);
    }

    protected virtual string? GetAttribute(string selector, string name, PageGetAttributeOptions? options = null)
    {
        this.WaitForLoadPage();
        return this.Page.GetAttribute(selector, name, options);
    }

    protected virtual string InnerHTML(string selector, PageInnerHTMLOptions? options = null)
    {
        this.WaitForLoadPage();
        return this.Page.InnerHTML(selector, options);
    }

    protected virtual string InnerText(string selector, PageInnerTextOptions? options = null)
    {
        this.WaitForLoadPage();
        return this.Page.InnerText(selector, options);
    }

    protected virtual string InputValue(string selector, PageInputValueOptions? options = null)
    {
        this.WaitForLoadPage();
        return this.Page.InputValue(selector, options);
    }

    protected virtual bool IsChecked(string selector, PageIsCheckedOptions? options = null)
    {
        this.WaitForLoadPage();
        return this.Page.IsChecked(selector, options);
    }

    protected virtual bool IsDisabled(string selector, PageIsDisabledOptions? options = null)
    {
        this.WaitForLoadPage();
        return this.Page.IsDisabled(selector, options);
    }

    protected virtual bool IsEditable(string selector, PageIsEditableOptions? options = null)
    {
        this.WaitForLoadPage();
        return this.Page.IsEditable(selector, options);
    }

    protected virtual bool IsEnabled(string selector, PageIsEnabledOptions? options = null)
    {
        this.WaitForLoadPage();
        return this.Page.IsEnabled(selector, options);
    }

    protected virtual bool IsHidden(string selector, PageIsHiddenOptions? options = null)
    {
        this.WaitForLoadPage();
        return this.Page.IsHidden(selector, options);
    }

    protected virtual bool IsVisible(string selector, PageIsVisibleOptions? options = null)
    {
        this.WaitForLoadPage();
        return this.Page.IsVisible(selector, options);
    }

    protected virtual ILocator IsVisible(string selector)
    {
        this.WaitForLoadPage();
        return this.Page.Locator(selector);
    }

    protected virtual void Route(string url, Action<IRoute> handler, PageRouteOptions? options = null)
    {
        this.Page.Route(url, handler, options);
    }

    protected virtual void Route(Regex url, Action<IRoute> handler, PageRouteOptions? options = null)
    {
        this.Page.Route(url, handler, options);
    }

    protected virtual void Route(Func<string, bool> url, Action<IRoute> handler, PageRouteOptions? options = null)
    {
        this.Page.Route(url, handler, options);
    }

    protected virtual void Unroute(string url, Action<IRoute>? handler = null)
    {
        this.Page.Unroute(url, handler);
    }

    protected virtual void Unroute(Regex url, Action<IRoute>? handler = null)
    {
        this.Page.Unroute(url, handler);
    }

    protected virtual void Unroute(Func<string, bool> url, Action<IRoute>? handler = null)
    {
        this.Page.Unroute(url, handler);
    }

    protected virtual IFrame? Frame(string name)
    {
        this.WaitForLoadPage();
        return this.Page.Frame(name);
    }

    protected virtual IFrame? FrameByUrl(string url)
    {
        this.WaitForLoadPage();
        return this.Page.FrameByUrl(url);
    }

    protected virtual IFrame? FrameByUrl(Regex url)
    {
        this.WaitForLoadPage();
        return this.Page.FrameByUrl(url);
    }

    protected virtual IFrame? FrameyUrl(Func<string, bool> url)
    {
        this.WaitForLoadPage();
        return this.Page.FrameByUrl(url);
    }

    protected virtual IConsoleMessage RunAndWaitForConsoleMessage(Func<Task> action, PageRunAndWaitForConsoleMessageOptions? options = null)
    {
        return this.Page.RunAndWaitForConsoleMessage(action, options);
    }

    protected virtual IDownload RunAndWaitForDownload(Func<Task> action, PageRunAndWaitForDownloadOptions? options = null)
    {
        return this.Page.RunAndWaitForDownload(action, options);
    }

    protected virtual IFileChooser RunAndWaitForFileChooser(Func<Task> action, PageRunAndWaitForFileChooserOptions? options = null)
    {
        return this.Page.RunAndWaitForFileChooser(action, options);
    }

    protected virtual IResponse? RunAndWaitForNavigation(Func<Task> action, PageRunAndWaitForNavigationOptions? options = null)
    {
        return this.Page.RunAndWaitForNavigation(action, options);
    }

    protected virtual IPage RunAndWaitForPopup(Func<Task> action, PageRunAndWaitForPopupOptions? options = null)
    {
        return this.Page.RunAndWaitForPopup(action, options);
    }

    protected virtual IRequest RunAndWaitForRequest(Func<Task> action, string urlOrPredicate, PageRunAndWaitForRequestOptions? options = null)
    {
        return this.Page.RunAndWaitForRequest(action, urlOrPredicate, options);
    }

    protected virtual IRequest RunAndWaitForRequest(Func<Task> action, Regex urlOrPredicate, PageRunAndWaitForRequestOptions? options = null)
    {
        return this.Page.RunAndWaitForRequest(action, urlOrPredicate, options);
    }

    protected virtual IRequest RunAndWaitForRequest(Func<Task> action, Func<IRequest, bool> urlOrPredicate, PageRunAndWaitForRequestOptions? options = null)
    {
        return this.Page.RunAndWaitForRequest(action, urlOrPredicate, options);
    }

    protected virtual IRequest RunAndWaitForRequestFinished(Func<Task> action, PageRunAndWaitForRequestFinishedOptions? options = null)
    {
        return this.Page.RunAndWaitForRequestFinished(action, options);
    }

    protected virtual IResponse RunAndWaitForResponse(Func<Task> action, string urlOrPredicate, PageRunAndWaitForResponseOptions? options = null)
    {
        return this.Page.RunAndWaitForResponse(action, urlOrPredicate, options);
    }

    protected virtual IResponse RunAndWaitForResponse(Func<Task> action, Regex urlOrPredicate, PageRunAndWaitForResponseOptions? options = null)
    {
        return this.Page.RunAndWaitForResponse(action, urlOrPredicate, options);
    }

    protected virtual IWebSocket RunAndWaitForWebSocket(Func<Task> action, PageRunAndWaitForWebSocketOptions? options = null)
    {
        return this.Page.RunAndWaitForWebSocket(action, options);
    }

    protected virtual void RunAndWaitForWorker(Func<Task> action, PageRunAndWaitForWorkerOptions? options = null)
    {
        this.Page.RunAndWaitForWorker(action, options);
    }

    protected virtual void Screenshot(PageScreenshotOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.Screenshot(options);
    }

    protected virtual byte[] Pdf(PagePdfOptions? options = null)
    {
        this.WaitForLoadPage();
        return this.Page.Pdf(options);
    }

    protected virtual void SetContent(string html, PageSetContentOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.SetContent(html, options);
    }

    protected virtual void SetExtraHTTPHeaders(IEnumerable<KeyValuePair<string, string>> headers)
    {
        this.Page.SetExtraHTTPHeaders(headers);
    }

    protected virtual void SetViewportSize(int width, int height)
    {
        this.Page.SetViewportSize(width, height);
    }

    protected virtual string? TextContent(string selector, PageTextContentOptions? options = null)
    {
        this.WaitForLoadPage();
        return this.Page.TextContent(selector, options);
    }

    protected virtual string Title()
    {
        this.WaitForLoadPage();
        return this.Page.Title();
    }

    protected virtual IConsoleMessage WaitForConsoleMessage(PageWaitForConsoleMessageOptions? options = null)
    {
        return this.Page.WaitForConsoleMessage(options);
    }

    protected virtual IDownload WaitForDownload(PageWaitForDownloadOptions? options = null)
    {
        return this.Page.WaitForDownload(options);
    }

    protected virtual IFileChooser WaitForFileChooser(PageWaitForFileChooserOptions? options = null)
    {
        return this.Page.WaitForFileChooser(options);
    }

    protected virtual IJSHandle WaitForFunction(string expression, object? arg = null, PageWaitForFunctionOptions? options = null)
    {
        return this.Page.WaitForFunction(expression, arg, options);
    }

    protected virtual void WaitForLoadState(LoadState? state = null, PageWaitForLoadStateOptions? options = null)
    {
        this.Page.WaitForLoadState(state, options);
    }

    protected virtual IResponse? WaitForNavigation(PageWaitForNavigationOptions? options = null)
    {
        return this.Page.WaitForNavigation(options);
    }

    protected virtual IPage WaitForPopup(PageWaitForPopupOptions? options = null)
    {
        return this.Page.WaitForPopup(options);
    }

    protected virtual IRequest WaitForRequest(string urlOrPredicate, PageWaitForRequestOptions? options = null)
    {
        return this.Page.WaitForRequest(urlOrPredicate, options);
    }

    protected virtual IRequest WaitForRequest(Regex urlOrPredicate, PageWaitForRequestOptions? options = null)
    {
        return this.Page.WaitForRequest(urlOrPredicate, options);
    }

    protected virtual IRequest WaitForRequest(Func<IRequest, bool> urlOrPredicate, PageWaitForRequestOptions? options = null)
    {
        return this.Page.WaitForRequest(urlOrPredicate, options);
    }

    protected virtual IRequest WaitForRequestFinished(PageWaitForRequestFinishedOptions? options = null)
    {
        return this.Page.WaitForRequestFinished(options);
    }

    protected virtual IResponse WaitForResponse(string urlOrPredicate, PageWaitForResponseOptions? options = null)
    {
        return this.Page.WaitForResponse(urlOrPredicate, options);
    }

    protected virtual IResponse WaitForResponse(Regex urlOrPredicate, PageWaitForResponseOptions? options = null)
    {
        return this.Page.WaitForResponse(urlOrPredicate, options);
    }

    protected virtual IResponse WaitForResponse(Func<IResponse, bool> urlOrPredicate, PageWaitForResponseOptions? options = null)
    {
        return this.Page.WaitForResponse(urlOrPredicate, options);
    }

    protected virtual IResponse RunAndWaitForResponse(Func<Task> action, Func<IResponse, bool> urlOrPredicate, PageRunAndWaitForResponseOptions? options = null)
    {
        return this.Page.RunAndWaitForResponse(action, urlOrPredicate, options);
    }

    protected virtual IElementHandle? WaitForSelector(string selector, PageWaitForSelectorOptions? options = null)
    {
        return this.Page.WaitForSelector(selector, options);
    }

    protected virtual void WaitForTimeout(float timeout)
    {
        this.Page.WaitForTimeout(timeout);
    }

    protected virtual void WaitForURL(Regex url, PageWaitForURLOptions? options = null)
    {
        this.Page.WaitForURL(url, options);
    }

    protected virtual void WaitForURL(Func<string, bool> url, PageWaitForURLOptions? options = null)
    {
        this.Page.WaitForURL(url, options);
    }

    protected virtual IWebSocket WaitForWebSocket(PageWaitForWebSocketOptions? options = null)
    {
        return this.Page.WaitForWebSocket(options);
    }

    protected virtual IWorker WaitForWorker(PageWaitForWorkerOptions? options = null)
    {
        return this.Page.WaitForWorker(options);
    }

    protected virtual IPage? Opener()
    {
        return this.Page.Opener();
    }

    protected virtual void Pause()
    {
        this.Page.Pause();
    }

    protected virtual void Close(PageCloseOptions? options = null)
    {
        this.WaitForLoadPage();
        this.Page.ClosePage(options);
    }
}
