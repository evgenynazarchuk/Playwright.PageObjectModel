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
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UITesting.Page.Sync;

namespace UIPageModel;

public partial class PageModel
{
    public virtual void Open(string url, PageGotoOptions? options = null)
    {
        this.Page.GotoAsync(url, options).GetAwaiter().GetResult();
    }

    public virtual void Wait() { }

    public virtual IElementHandle FindElement(string selector, PageQuerySelectorOptions? options = null, string exceptionMessage = "Element not found")
    {
        this.Wait();
        this.Before();
        this.BeforeFind();

        var element = this.Page.QuerySelectorAsync(selector, options).GetAwaiter().GetResult();
        if (element is null) throw new ApplicationException(exceptionMessage);
        else return element;
    }

    public virtual IElementHandle? FindElementOrNull(string selector, PageQuerySelectorOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeFind();

        var element = this.Page.QuerySelectorAsync(selector, options).GetAwaiter().GetResult();
        return element;
    }

    public virtual IReadOnlyCollection<IElementHandle> FindElements(string selector)
    {
        this.Wait();
        this.Before();
        this.BeforeFind();

        var elements = this.Page.QuerySelectorAllAsync(selector).GetAwaiter().GetResult();
        return elements;
    }

    public virtual TBlockModel FindBlock<TBlockModel>(string selector)
        where TBlockModel : class
    {
        this.Wait();
        this.Before();
        this.BeforeFind();

        var blockType = typeof(TBlockModel);
        var ctorArgs = new[] { this.GetType(), typeof(string) };

        var ctor = blockType.GetConstructor(ctorArgs);
        if (ctor is null) throw new ApplicationException("Block Model not found");

        var block = ctor.Invoke(new[] { this, (object)selector });
        if (block is null) throw new ApplicationException("Block Model not created");

        return (TBlockModel)block;
    }

    public virtual TBlockModel? FindBlockOrNull<TBlockModel>(string selector)
        where TBlockModel : class
    {
        this.Wait();
        this.Before();
        this.BeforeFind();

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

    public virtual IReadOnlyCollection<TBlockModel> FindBlocks<TBlockModel>(string selector)
        where TBlockModel : class
    {
        this.Wait();
        this.Before();
        this.BeforeFind();

        var elements = this.Page.QuerySelectorAllAsync(selector).GetAwaiter().GetResult();
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

    public virtual void Click(string selector, PageClickOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeClick();

        this.Page.Click(selector, options);

        this.Wait();
        this.After();
        this.AfterClick();
    }

    public virtual TReturnPage Click<TReturnPage>(string selector, PageClickOptions? options = null)
        where TReturnPage : PageModel
    {
        this.Click(selector, options);

        var ctor = typeof(TReturnPage).GetConstructor(new[] { typeof(IPage) });
        if (ctor is null) throw new ApplicationException("Page Model not found");

        var returnPage = ctor.Invoke(new[] { this.Page });
        return (TReturnPage)returnPage;
    }

    public virtual void DblClick(string selector, PageDblClickOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeDbClick();

        this.Page.DblClick(selector, options);

        this.Wait();
        this.After();
        this.AfterDbClick();
    }

    public virtual void Type(string selector, string value, PageTypeOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeType();

        this.Page.Type(selector, value, options);

        this.Wait();
        this.After();
        this.AfterType();
    }

    public virtual void SetInputFiles(string selector, string files, PageSetInputFilesOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeSetInputFile();

        this.Page.SetInputFiles(selector, files, options);

        this.Wait();
        this.After();
        this.AfterSetInputFile();
    }

    public virtual void SetInputFiles(string selector, FilePayload files, PageSetInputFilesOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeSetInputFile();

        this.Page.SetInputFiles(selector, files, options);

        this.Wait();
        this.After();
        this.AfterSetInputFile();
    }

    public virtual void SetInputFiles(string selector, IEnumerable<string> files, PageSetInputFilesOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeSetInputFile();

        this.Page.SetInputFiles(selector, files, options);

        this.Wait();
        this.After();
        this.AfterSetInputFile();
    }

    public virtual void SetInputFiles(string selector, IEnumerable<FilePayload> files, PageSetInputFilesOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeSetInputFile();

        this.Page.SetInputFiles(selector, files, options);

        this.Wait();
        this.After();
        this.AfterSetInputFile();
    }

    public virtual void AddInitScript(string? script = null, string? scriptPath = null)
    {
        this.Wait();

        this.Page.AddInitScript(script, scriptPath);
    }

    public virtual void AddScriptTag(PageAddScriptTagOptions? options = null)
    {
        this.Wait();

        this.Page.AddScriptTag(options);
    }

    public virtual void AddStyleTag(PageAddStyleTagOptions? options = null)
    {
        this.Wait();

        this.Page.AddStyleTag(options);
    }

    public virtual void BringToFront()
    {
        this.Wait();

        this.Page.BringToFront();
    }

    public virtual void Check(string selector, PageCheckOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeCheck();
    
        this.Page.Check(selector, options);
    
        this.Wait();
        this.After();
        this.AfterCheck();
    }

    public virtual string Content()
    {
        this.Wait();

        return this.Page.Content();
    }

    public virtual void DispatchEvent(string selector, string type, object? eventInit = null, PageDispatchEventOptions? options = null)
    {
        this.Wait();

        this.Page.DispatchEvent(selector, type, eventInit, options);;
    }

    public virtual void DragAndDrop(string source, string target, PageDragAndDropOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeDragAndDrop();

        this.Page.DragAndDrop(source, target, options);

        this.Wait();
        this.After();
        this.AfterDragAndDrop();
    }

    public virtual void EmulateMedia(PageEmulateMediaOptions? options = null)
    {
        this.Wait();

        this.Page.EmulateMedia(options);
    }

    public virtual void EvalOnSelectorAll(string selector, string expression, object? arg = null)
    {
        this.Wait();

        this.Page.EvalOnSelectorAll(selector, expression, arg);
    }

    public virtual void EvalOnSelectorAll<T>(string selector, string expression, object? arg = null)
    {
        this.Wait();

        this.Page.EvalOnSelectorAll<T>(selector, expression, arg);
    }

    public virtual void EvalOnSelector(string selector, string expression, object? arg = null)
    {
        this.Wait();

        this.Page.EvalOnSelector(selector, expression, arg);
    }

    public virtual void EvalOnSelector<T>(string selector, string expression, object? arg = null, PageEvalOnSelectorOptions? options = null)
    {
        this.Wait();

        this.Page.EvalOnSelector<T>(selector, expression, arg, options);
    }

    public virtual void Evaluate(string expression, object? arg = null)
    {
        this.Wait();

        this.Page.Evaluate(expression, arg);
    }

    public virtual void Evaluate<T>(string expression, object? arg = null)
    {
        this.Wait();

        this.Page.Evaluate<T>(expression, arg);
    }

    public virtual void EvaluateHandle(string expression, object? arg = null)
    {
        this.Wait();

        this.Page.EvaluateHandle(expression, arg);
    }

    public virtual void ExposeBinding(string name, Action callback, PageExposeBindingOptions? options = null)
    {
        this.Wait();

        this.Page.ExposeBinding(name, callback, options);
    }

    public virtual void ExposeBinding<T>(string name, Action<BindingSource, T> callback)
    {
        this.Wait();

        this.Page.ExposeBinding<T>(name, callback);
    }

    public virtual void ExposeBinding<TResult>(string name, Func<BindingSource, TResult> callback)
    {
        this.Wait();

        this.Page.ExposeBinding<TResult>(name, callback);
    }

    public virtual void ExposeBinding<TResult>(string name, Func<BindingSource, IJSHandle, TResult> callback)
    {
        this.Wait();

        this.Page.ExposeBinding<TResult>(name, callback);
    }

    public virtual void ExposeBinding<T, TResult>(string name, Func<BindingSource, T, TResult> callback)
    {
        this.Wait();

        this.Page.ExposeBinding<T, TResult>(name, callback);
    }

    public virtual void ExposeBinding<T1, T2, TResult>(string name, Func<BindingSource, T1, T2, TResult> callback)
    {
        this.Wait();

        this.Page.ExposeBinding<T1, T2, TResult>(name, callback);
    }

    public virtual void ExposeBinding<T1, T2, T3, TResult>(string name, Func<BindingSource, T1, T2, T3, TResult> callback)
    {
        this.Wait();

        this.Page.ExposeBinding<T1, T2, T3, TResult>(name, callback);
    }

    public virtual void ExposeBinding<T1, T2, T3, T4, TResult>(string name, Func<BindingSource, T1, T2, T3, T4, TResult> callback)
    {
        this.Wait();

        this.Page.ExposeBinding<T1, T2, T3, T4, TResult>(name, callback);
    }

    public virtual void ExposeFunction(string name, Action callback)
    {
        this.Wait();

        this.Page.ExposeFunction(name, callback);
    }

    public virtual void ExposeFunction<T>(string name, Action<T> callback)
    {
        this.Wait();

        this.Page.ExposeFunction<T>(name, callback);
    }

    public virtual void ExposeFunction<TResult>(string name, Func<TResult> callback)
    {
        this.Wait();

        this.Page.ExposeFunction<TResult>(name, callback);
    }

    public virtual void ExposeFunction<T, TResult>(string name, Func<T, TResult> callback)
    {
        this.Wait();

        this.Page.ExposeFunction<T, TResult>(name, callback);
    }

    public virtual void ExposeFunction<T1, T2, TResult>(string name, Func<T1, T2, TResult> callback)
    {
        this.Wait();

        this.Page.ExposeFunction<T1, T2, TResult>(name, callback);
    }

    public virtual void ExposeFunction<T1, T2, T3, TResult>(string name, Func<T1, T2, T3, TResult> callback)
    {
        this.Wait();

        this.Page.ExposeFunction<T1, T2, T3, TResult>(name, callback);
    }

    public virtual void ExposeFunction<T1, T2, T3, T4, TResult>(string name, Func<T1, T2, T3, T4, TResult> callback)
    {
        this.Wait();

        this.Page.ExposeFunction<T1, T2, T3, T4, TResult>(name, callback);
    }

    public virtual void Focus(string selector, PageFocusOptions? options = null)
    {
        this.Wait();

        this.Page.Focus(selector, options);
    }

    public virtual IFrame? Frame(string name)
    {
        this.Wait();

        return this.Page.Frame(name);
    }

    public virtual IFrame? FrameByUrl(string url)
    {
        this.Wait();

        return this.Page.FrameByUrl(url);
    }

    public virtual IFrame? FrameByUrl(Regex url)
    {
        this.Wait();

        return this.Page.FrameByUrl(url);
    }

    public virtual IFrame? FrameyUrl(Func<string, bool> url)
    {
        this.Wait();

        return this.Page.FrameByUrl(url);
    }

    public virtual void GetAttribute(string selector, string name, PageGetAttributeOptions? options = null)
    {
        this.Wait();

        this.Page.GetAttribute(selector, name, options);
    }

    public virtual void GoBack(PageGoBackOptions? options = null)
    {
        this.Page.GoBack(options);
    }

    public virtual void GoForward(PageGoForwardOptions? options = null)
    {
        this.Page.GoForward(options);
    }

    public virtual void Goto(string url, PageGotoOptions? options = null)
    {
        this.Page.Goto(url, options);
    }

    public virtual void Hover(string selector, PageHoverOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeHover();

        this.Page.Hover(selector, options);

        this.Wait();
        this.After();
        this.AfterHover();
    }

    public virtual void InnerHTML(string selector, PageInnerHTMLOptions? options = null)
    {
        this.Wait();

        this.Page.InnerHTML(selector, options);
    }

    public virtual void InnerText(string selector, PageInnerTextOptions? options = null)
    {
        this.Wait();

        this.Page.InnerText(selector, options);
    }

    public virtual string InputValue(string selector, PageInputValueOptions? options = null)
    {
        this.Wait();

        return this.Page.InputValue(selector, options);
    }

    public virtual bool IsChecked(string selector, PageIsCheckedOptions? options = null)
    {
        this.Wait();

        return this.Page.IsChecked(selector, options);
    }

    public virtual bool IsDisabled(string selector, PageIsDisabledOptions? options = null)
    {
        this.Wait();

        return this.Page.IsDisabled(selector, options);
    }

    public virtual bool IsEditable(string selector, PageIsEditableOptions? options = null)
    {
        this.Wait();

        return this.Page.IsEditable(selector, options);
    }

    public virtual bool IsEnabled(string selector, PageIsEnabledOptions? options = null)
    {
        this.Wait();

        return this.Page.IsEnabled(selector, options);
    }

    public virtual bool IsHidden(string selector, PageIsHiddenOptions? options = null)
    {
        this.Wait();

        return this.Page.IsHidden(selector, options);
    }

    public virtual bool IsVisible(string selector, PageIsVisibleOptions? options = null)
    {
        this.Wait();

        return this.Page.IsVisible(selector, options);
    }

    public virtual ILocator IsVisible(string selector)
    {
        this.Wait();

        return this.Page.Locator(selector);
    }

    public virtual IPage? Opener()
    {
        return this.Page.Opener();
    }

    public virtual void Pause()
    {
        this.Page.Pause();
    }

    public virtual byte[] Pdf(PagePdfOptions? options = null)
    {
        this.Wait();

        return this.Page.Pdf(options);
    }

    public virtual void Press(string selector, string key, PagePressOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforePress();

        this.Page.Press(selector, key, options);

        this.Wait();
        this.After();
        this.AfterPress();
    }

    public virtual void Route(string url, Action<IRoute> handler, PageRouteOptions? options = null)
    {
        this.Page.Route(url, handler, options);
    }

    public virtual void Route(Regex url, Action<IRoute> handler, PageRouteOptions? options = null)
    {
        this.Page.Route(url, handler, options);
    }

    public virtual void Route(Func<string, bool> url, Action<IRoute> handler, PageRouteOptions? options = null)
    {
        this.Page.Route(url, handler, options);
    }

    public virtual IConsoleMessage RunAndWaitForConsoleMessage(Func<Task> action, PageRunAndWaitForConsoleMessageOptions? options = null)
    {
        return this.Page.RunAndWaitForConsoleMessage(action, options);
    }

    public virtual IDownload RunAndWaitForDownload(Func<Task> action, PageRunAndWaitForDownloadOptions? options = null)
    {
        return this.Page.RunAndWaitForDownload(action, options);
    }

    public virtual IFileChooser RunAndWaitForFileChooser(Func<Task> action, PageRunAndWaitForFileChooserOptions? options = null)
    {
        return this.Page.RunAndWaitForFileChooser(action, options);
    }

    public virtual IResponse? RunAndWaitForNavigation(Func<Task> action, PageRunAndWaitForNavigationOptions? options = null)
    {
        return this.Page.RunAndWaitForNavigation(action, options);
    }

    public virtual IPage RunAndWaitForPopup(Func<Task> action, PageRunAndWaitForPopupOptions? options = null)
    {
        return this.Page.RunAndWaitForPopup(action, options);
    }

    public virtual IRequest RunAndWaitForRequest(Func<Task> action, string urlOrPredicate, PageRunAndWaitForRequestOptions? options = null)
    {
        return this.Page.RunAndWaitForRequest(action, urlOrPredicate, options);
    }

    public virtual IRequest RunAndWaitForRequest(Func<Task> action, Regex urlOrPredicate, PageRunAndWaitForRequestOptions? options = null)
    {
        return this.Page.RunAndWaitForRequest(action, urlOrPredicate, options);
    }

    public virtual IRequest RunAndWaitForRequest(Func<Task> action, Func<IRequest, bool> urlOrPredicate, PageRunAndWaitForRequestOptions? options = null)
    {
        return this.Page.RunAndWaitForRequest(action, urlOrPredicate, options);
    }

    public virtual IRequest RunAndWaitForRequestFinished(Func<Task> action, PageRunAndWaitForRequestFinishedOptions? options = null)
    {
        return this.Page.RunAndWaitForRequestFinished(action, options);
    }

    public virtual IResponse A(Func<Task> action, string urlOrPredicate, PageRunAndWaitForResponseOptions? options = null)
    {
        return this.Page.RunAndWaitForResponse(action, urlOrPredicate, options);
    }

    public virtual IResponse RunAndWaitForResponse(Func<Task> action, Regex urlOrPredicate, PageRunAndWaitForResponseOptions? options = null)
    {
        return this.Page.RunAndWaitForResponse(action, urlOrPredicate, options);
    }

    public virtual IWebSocket RunAndWaitForWebSocket(Func<Task> action, PageRunAndWaitForWebSocketOptions? options = null)
    {
        return this.Page.RunAndWaitForWebSocket(action, options);
    }

    public virtual void RunAndWaitForWorker(Func<Task> action, PageRunAndWaitForWorkerOptions? options = null)
    {
        this.Page.RunAndWaitForWorker(action, options);
    }

    public virtual IReadOnlyList<string> SelectOption(string selector, string values, PageSelectOptionOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeSelectOption();

        var result = this.Page.SelectOption(selector, values, options);

        this.Wait();
        this.After();
        this.AfterSelectOption();

        return result;
    }

    public virtual IReadOnlyList<string> SelectOption(string selector, IElementHandle values, PageSelectOptionOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeSelectOption();

        var result = this.Page.SelectOption(selector, values, options);

        this.Wait();
        this.After();
        this.AfterSelectOption();

        return result;
    }

    public virtual IReadOnlyList<string> SelectOption(string selector, IEnumerable<string> values, PageSelectOptionOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeSelectOption();

        var result = this.Page.SelectOption(selector, values, options);

        this.Wait();
        this.After();
        this.AfterSelectOption();

        return result;
    }

    public virtual IReadOnlyList<string> SelectOption(string selector, SelectOptionValue values, PageSelectOptionOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeSelectOption();

        var result = this.Page.SelectOption(selector, values, options);

        this.Wait();
        this.After();
        this.AfterSelectOption();

        return result;
    }

    public virtual IReadOnlyList<string> SelectOption(string selector, IEnumerable<IElementHandle> values, PageSelectOptionOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeSelectOption();

        var result = this.Page.SelectOption(selector, values, options);

        this.Wait();
        this.After();
        this.AfterSelectOption();

        return result;
    }

    public virtual IReadOnlyList<string> SelectOption(string selector, IEnumerable<SelectOptionValue> values, PageSelectOptionOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeSelectOption();

        var result = this.Page.SelectOption(selector, values, options);

        this.Wait();
        this.After();
        this.AfterSelectOption();

        return result;
    }

    public virtual void SetChecked(string selector, bool checkedState, PageSetCheckedOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeSetChecked();

        this.Page.SetChecked(selector, checkedState, options);

        this.Wait();
        this.After();
        this.AfterSetChecked();
    }

    public virtual void Screenshot(PageScreenshotOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeScreenshot();

        this.Page.Screenshot(options);

        this.Wait();
        this.After();
        this.AfterScreenshot();
    }

    public virtual TPageModel ReloadPage<TPageModel>(PageReloadOptions? options = null)
        where TPageModel : PageModel
    {
        this.Page.ReloadAsync(options).GetAwaiter().GetResult();

        var ctor = typeof(TPageModel).GetConstructor(new[] { typeof(IPage) });
        if (ctor is null) throw new ApplicationException("Page Model not found");
        var returnPage = ctor.Invoke(new[] { this.Page });

        return (TPageModel)returnPage;
    }

    public virtual void Close(PageCloseOptions? options = null)
    {
        this.Wait();
        this.Page.ClosePage(options);
    }

    public virtual void FillAsync(string selector, string value, PageFillOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeFill();

        this.Page.Fill(selector, value, options);

        this.Wait();
        this.Before();
        this.BeforeFill();
    }

    public virtual IElementHandle? QuerySelector(string selector, PageQuerySelectorOptions? options = null)
    {
        this.Wait();

        return this.Page.QuerySelector(selector, options);
    }

    public virtual IReadOnlyList<IElementHandle> QuerySelectorAll(string selector)
    {
        this.Wait();

        return this.Page.QuerySelectorAll(selector);
    }

    public virtual void Reload(PageReloadOptions? options = null)
    {
        this.Wait();

        this.Page.Reload(options);
    }

    public virtual void SetContent(string html, PageSetContentOptions? options = null)
    {
        this.Wait();

        this.Page.SetContent(html, options);
    }

    public virtual void SetExtraHTTPHeaders(IEnumerable<KeyValuePair<string, string>> headers)
    {
        this.Page.SetExtraHTTPHeaders(headers);
    }

    public virtual void SetViewportSize(int width, int height)
    {
        this.Page.SetViewportSize(width, height);
    }

    public virtual void Tap(string selector, PageTapOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeTap();

        this.Page.Tap(selector, options);

        this.Wait();
        this.After();
        this.AfterTap();
    }

    public virtual string? TextContent(string selector, PageTextContentOptions? options = null)
    {
        this.Wait();

        return this.Page.TextContent(selector, options);
    }

    public virtual string Title()
    {
        this.Wait();

        return this.Page.Title();
    }

    public virtual void Uncheck(string selector, PageUncheckOptions? options = null)
    {
        this.Wait();
        this.Before();
        this.BeforeUncheck();

        this.Page.Uncheck(selector, options);

        this.Wait();
        this.After();
        this.AfterUncheck();
    }

    public virtual void Unroute(string url, Action<IRoute>? handler = null)
    {
        this.Page.Unroute(url, handler);
    }

    public virtual void Unroute(Regex url, Action<IRoute>? handler = null)
    {
        this.Page.Unroute(url, handler);
    }

    public virtual void Unroute(Func<string, bool> url, Action<IRoute>? handler = null)
    {
        this.Page.Unroute(url, handler);
    }

    public virtual IConsoleMessage WaitForConsoleMessage(PageWaitForConsoleMessageOptions? options = null)
    {
        return this.Page.WaitForConsoleMessage(options);
    }

    public virtual IDownload WaitForDownload(PageWaitForDownloadOptions? options = null)
    {
        return this.Page.WaitForDownload(options);
    }

    public virtual IFileChooser WaitForFileChooser(PageWaitForFileChooserOptions? options = null)
    {
        return this.Page.WaitForFileChooser(options);
    }

    public virtual IJSHandle WaitForFunction(string expression, object? arg = null, PageWaitForFunctionOptions? options = null)
    {
        return this.Page.WaitForFunction(expression, arg, options);
    }

    public virtual void WaitForLoadState(LoadState? state = null, PageWaitForLoadStateOptions? options = null)
    {
        this.Page.WaitForLoadState(state, options);
    }

    public virtual IResponse? WaitForNavigation(PageWaitForNavigationOptions? options = null)
    {
        return this.Page.WaitForNavigation(options);
    }

    public virtual IPage WaitForPopup(PageWaitForPopupOptions? options = null)
    {
        return this.Page.WaitForPopup(options);
    }

    public virtual IRequest WaitForRequest(string urlOrPredicate, PageWaitForRequestOptions? options = null)
    {
        return this.Page.WaitForRequest(urlOrPredicate, options);
    }

    public virtual IRequest WaitForRequest(Regex urlOrPredicate, PageWaitForRequestOptions? options = null)
    {
        return this.Page.WaitForRequest(urlOrPredicate, options);
    }

    public virtual IRequest WaitForRequest(Func<IRequest, bool> urlOrPredicate, PageWaitForRequestOptions? options = null)
    {
        return this.Page.WaitForRequest(urlOrPredicate, options);
    }

    public virtual IRequest WaitForRequestFinished(PageWaitForRequestFinishedOptions? options = null)
    {
        return this.Page.WaitForRequestFinished(options);
    }

    public virtual IResponse WaitForResponse(string urlOrPredicate, PageWaitForResponseOptions? options = null)
    {
        return this.Page.WaitForResponse(urlOrPredicate, options);
    }

    public virtual IResponse WaitForResponse(Regex urlOrPredicate, PageWaitForResponseOptions? options = null)
    {
        return this.Page.WaitForResponse(urlOrPredicate, options);
    }

    public virtual IResponse WaitForResponse(Func<IResponse, bool> urlOrPredicate, PageWaitForResponseOptions? options = null)
    {
        return this.Page.WaitForResponse(urlOrPredicate, options);
    }

    public virtual IResponse RunAndWaitForResponse(Func<Task> action, string urlOrPredicate, PageRunAndWaitForResponseOptions? options = null)
    {
        return this.Page.RunAndWaitForResponse(action, urlOrPredicate, options);
    }

    public virtual IResponse RunAndWaitForResponse(Func<Task> action, Func<IResponse, bool> urlOrPredicate, PageRunAndWaitForResponseOptions? options = null)
    {
        return this.Page.RunAndWaitForResponse(action, urlOrPredicate, options);
    }

    public virtual IElementHandle? WaitForSelector(string selector, PageWaitForSelectorOptions? options = null)
    {
        return this.Page.WaitForSelector(selector, options);
    }

    public virtual void WaitForTimeout(float timeout)
    {
        this.Page.WaitForTimeout(timeout);
    }

    public virtual void WaitForURL(Regex url, PageWaitForURLOptions? options = null)
    {
        this.Page.WaitForURL(url, options);
    }

    public virtual void WaitForURL(Func<string, bool> url, PageWaitForURLOptions? options = null)
    {
        this.Page.WaitForURL(url, options);
    }

    public virtual IWebSocket WaitForWebSocket(PageWaitForWebSocketOptions? options = null)
    {
        return this.Page.WaitForWebSocket(options);
    }

    public virtual IWorker WaitForWorker(PageWaitForWorkerOptions? options = null)
    {
        return this.Page.WaitForWorker(options);
    }

    public virtual void ExposeBinding(string name, Action<BindingSource> callback)
    {
        this.Page.ExposeBinding(name, callback);
    }
}
