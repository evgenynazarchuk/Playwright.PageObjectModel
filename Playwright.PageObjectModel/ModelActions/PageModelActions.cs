using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playwright.PageObjectModel.Interfaces.ModelActions;
using Microsoft.Playwright;
using Playwright.Synchronous;
using System.Text.RegularExpressions;

namespace Playwright.PageObjectModel.ModelActions;

public class PageModelActions : IPageModelActions
{
    public virtual void Wait() { }

    public virtual void WaitForLoadState(IPage page, LoadState loadState, PageWaitForLoadStateOptions? options = null)
    {
        page.WaitForLoadState(loadState, options);
    }

    public TPageModel CreatePageModel<TPageModel>(IPage page)
        where TPageModel : PageModel
    {
        var ctor = typeof(TPageModel).GetConstructor(new[] { typeof(IPage) });
        if (ctor is null) throw new ApplicationException("Page Model not found");
        var pageModel = ctor.Invoke(new[] { page });
        if (pageModel is null) throw new ApplicationException("Page Model not created");
        return (TPageModel)pageModel;
    }

    public TBlockModel CreateBlockModel<TBlockModel>(PageModel pageModel, Type PageModelType, string selector)
        where TBlockModel : class
    {
        var blockType = typeof(TBlockModel);
        var ctorArgs = new[] { PageModelType, typeof(string) };

        var ctor = blockType.GetConstructor(ctorArgs);
        if (ctor is null) throw new ApplicationException("Block Model not found");

        var block = ctor.Invoke(new[] { pageModel, (object)selector });
        if (block is null) throw new ApplicationException("Block Model not created");

        return (TBlockModel)block;
    }

    public TBlockModel CreateBlockModel<TBlockModel>(PageModel pageModel, Type pageModelType, IElementHandle element)
        where TBlockModel : class
    {
        var blockType = typeof(TBlockModel);
        var ctorArgs = new[] { pageModelType, typeof(IElementHandle) };

        var ctor = blockType.GetConstructor(ctorArgs);
        if (ctor is null) throw new ApplicationException("Block Model not found");

        var block = ctor.Invoke(new[] { pageModel, (object)element });
        if (block is null) throw new ApplicationException("Block Model not created");

        return (TBlockModel)block;
    }

    public virtual TPageModel Goto<TPageModel>(IPage page, string url, PageGotoOptions? options = null)
        where TPageModel : PageModel
    {
        page.Goto(url, options);
        var pageModel = this.CreatePageModel<TPageModel>(page);
        return pageModel;
    }

    public virtual TPageModel GoBack<TPageModel>(IPage page, PageGoBackOptions? options = null)
        where TPageModel : PageModel
    {
        page.GoBack(options);
        var pageModel = this.CreatePageModel<TPageModel>(page);
        return pageModel;
    }

    public virtual TPageModel GoForward<TPageModel>(IPage page, PageGoForwardOptions? options = null)
        where TPageModel : PageModel
    {
        page.GoForward(options);
        var pageModel = this.CreatePageModel<TPageModel>(page);
        return pageModel;
    }

    public virtual TPageModel ReloadToPage<TPageModel>(IPage page, PageReloadOptions? options = null)
        where TPageModel : PageModel
    {
        page.ReloadAsync(options).GetAwaiter().GetResult();
        var pageModel = this.CreatePageModel<TPageModel>(page);
        return pageModel;
    }

    public virtual void Close(IPage page, PageCloseOptions? options = null)
    {
        page.ClosePage(options);
    }

    public virtual IElementHandle? QuerySelector(IPage page, string selector, PageQuerySelectorOptions? options = null)
    {
        return page.QuerySelector(selector, options);
    }

    public virtual IReadOnlyList<IElementHandle> QuerySelectorAll(IPage page, string selector)
    {
        return page.QuerySelectorAll(selector);
    }

    public virtual IElementHandle GetElement(
        IPage page,
        string selector,
        PageWaitForSelectorOptions? waitOptions = null,
        PageQuerySelectorOptions? queryOptions = null)
    {
        page.WaitForSelector(selector, waitOptions);
        var element = page.QuerySelector(selector, queryOptions);
        return element!;
    }

    public virtual IReadOnlyCollection<IElementHandle> GetElements(IPage page, string selector, PageWaitForSelectorOptions? waitOptions = null)
    {
        page.WaitForSelector(selector, waitOptions);
        var elements = page.QuerySelectorAll(selector);
        return elements;
    }

    public virtual TBlockModel GetBlockModel<TBlockModel>(
        PageModel pageModel, 
        Type pageModelType, 
        string selector, 
        PageWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : class
    {
        var elementModel = this.CreateBlockModel<TBlockModel>(pageModel, pageModelType, selector);
        return elementModel;
    }

    public virtual IReadOnlyCollection<TBlockModel> GetBlockModels<TBlockModel>(
        PageModel pageModel,
        Type pageModelType,
        string selector, 
        PageWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : class
    {
        var elements = pageModel.Page.QuerySelectorAll(selector);
        var blocks = new List<TBlockModel>();

        foreach (var element in elements)
        {
            var block = this.CreateBlockModel<TBlockModel>(pageModel, pageModelType, element);
            blocks.Add(block);
        }

        return blocks;
    }

    public virtual IElementHandle? GetElementOrNull(
        IPage page,
        string selector,
        PageWaitForSelectorOptions? waitOptions = null,
        PageQuerySelectorOptions? queryOptions = null)
    {
        page.WaitForSelector(selector, waitOptions);
        var element = page.QuerySelector(selector, queryOptions);
        return element;
    }

    public virtual TBlockModel? GetBlockModelOrNull<TBlockModel>(PageModel pageModel, Type pageModelType, string selector)
        where TBlockModel : class
    {
        var blockType = typeof(TBlockModel);
        var ctorArgs = new[] { pageModelType, typeof(string) };

        var ctor = blockType.GetConstructor(ctorArgs);
        if (ctor is null) throw new ApplicationException("Block Model not found");

        object? block = null;
        try
        {
            block = ctor.Invoke(new[] { pageModel, (object)selector });
        }
        catch { }

        return (TBlockModel?)block;
    }

    public virtual void Click(IPage page, string selector, PageClickOptions? options = null)
    {
        page.Click(selector, options);
    }

    public virtual TReturnPage Click<TReturnPage>(IPage page, string selector, PageClickOptions? options = null)
        where TReturnPage : PageModel
    {
        this.Click(page, selector, options);
        var pageModel = this.CreatePageModel<TReturnPage>(page);
        return pageModel;
    }

    public virtual void DblClick(IPage page, string selector, PageDblClickOptions? options = null)
    {
        page.DblClick(selector, options);
    }

    public virtual void Type(IPage page, string selector, string value, PageTypeOptions? options = null)
    {
        page.Type(selector, value, options);
    }

    public virtual void Check(IPage page, string selector, PageCheckOptions? options = null)
    {
        page.Check(selector, options);
    }

    public virtual void Uncheck(IPage page, string selector, PageUncheckOptions? options = null)
    {
        page.Uncheck(selector, options);
    }

    public virtual void SetChecked(IPage page, string selector, bool checkedState, PageSetCheckedOptions? options = null)
    {
        page.SetChecked(selector, checkedState, options);
    }

    public virtual void Tap(IPage page, string selector, PageTapOptions? options = null)
    {
        page.Tap(selector, options);
    }

    public virtual void DragAndDrop(IPage page, string source, string target, PageDragAndDropOptions? options = null)
    {
        page.DragAndDrop(source, target, options);
    }

    public virtual void Focus(IPage page, string selector, PageFocusOptions? options = null)
    {
        page.Focus(selector, options);
    }

    public virtual void Fill(IPage page, string selector, string value, PageFillOptions? options = null)
    {
        page.Fill(selector, value, options);
    }

    public virtual void Hover(IPage page, string selector, PageHoverOptions? options = null)
    {
        page.Hover(selector, options);
    }

    public virtual void Press(IPage page, string selector, string key, PagePressOptions? options = null)
    {
        page.Press(selector, key, options);
    }

    public virtual IReadOnlyList<string> SelectOption(IPage page, string selector, string values, PageSelectOptionOptions? options = null)
    {
        var result = page.SelectOption(selector, values, options);
        return result;
    }

    public virtual IReadOnlyList<string> SelectOption(IPage page, string selector, IElementHandle values, PageSelectOptionOptions? options = null)
    {
        var result = page.SelectOption(selector, values, options);
        return result;
    }

    public virtual IReadOnlyList<string> SelectOption(IPage page, string selector, IEnumerable<string> values, PageSelectOptionOptions? options = null)
    {
        var result = page.SelectOption(selector, values, options);
        return result;
    }

    public virtual IReadOnlyList<string> SelectOption(IPage page, string selector, SelectOptionValue values, PageSelectOptionOptions? options = null)
    {
        var result = page.SelectOption(selector, values, options);
        return result;
    }

    public virtual IReadOnlyList<string> SelectOption(IPage page, string selector, IEnumerable<IElementHandle> values, PageSelectOptionOptions? options = null)
    {
        var result = page.SelectOption(selector, values, options);
        return result;
    }

    public virtual IReadOnlyList<string> SelectOption(IPage page, string selector, IEnumerable<SelectOptionValue> values, PageSelectOptionOptions? options = null)
    {
        var result = page.SelectOption(selector, values, options);
        return result;
    }

    public virtual void SetInputFiles(IPage page, string selector, string files, PageSetInputFilesOptions? options = null)
    {
        page.SetInputFiles(selector, files, options);
    }

    public virtual void SetInputFiles(IPage page, string selector, FilePayload files, PageSetInputFilesOptions? options = null)
    {
        page.SetInputFiles(selector, files, options);
    }

    public virtual void SetInputFiles(IPage page, string selector, IEnumerable<string> files, PageSetInputFilesOptions? options = null)
    {
        page.SetInputFiles(selector, files, options);
    }

    public virtual void SetInputFiles(IPage page, string selector, IEnumerable<FilePayload> files, PageSetInputFilesOptions? options = null)
    {
        page.SetInputFiles(selector, files, options);
    }

    public virtual void AddInitScript(IPage page, string? script = null, string? scriptPath = null)
    {
        page.AddInitScript(script, scriptPath);
    }

    public virtual void AddScriptTag(IPage page, PageAddScriptTagOptions? options = null)
    {
        page.AddScriptTag(options);
    }

    public virtual void AddStyleTag(IPage page, PageAddStyleTagOptions? options = null)
    {
        page.AddStyleTag(options);
    }

    public virtual void BringToFront(IPage page)
    {
        page.BringToFront();
    }

    public virtual string Content(IPage page)
    {
        var content = page.Content();
        return content;
    }

    public virtual void DispatchEvent(IPage page, string selector, string type, object? eventInit = null, PageDispatchEventOptions? options = null)
    {
        page.DispatchEvent(selector, type, eventInit, options); ;
    }

    public virtual void EmulateMedia(IPage page, PageEmulateMediaOptions? options = null)
    {
        page.EmulateMedia(options);
    }

    public virtual void EvalOnSelectorAll(IPage page, string selector, string expression, object? arg = null)
    {
        page.EvalOnSelectorAll(selector, expression, arg);
    }

    public virtual void EvalOnSelectorAll<T>(IPage page, string selector, string expression, object? arg = null)
    {
        page.EvalOnSelectorAll<T>(selector, expression, arg);
    }

    public virtual void EvalOnSelector(IPage page, string selector, string expression, object? arg = null)
    {
        page.EvalOnSelector(selector, expression, arg);
    }

    public virtual void EvalOnSelector<T>(IPage page, string selector, string expression, object? arg = null, PageEvalOnSelectorOptions? options = null)
    {
        page.EvalOnSelector<T>(selector, expression, arg, options);
    }

    public virtual void Evaluate(IPage page, string expression, object? arg = null)
    {
        page.Evaluate(expression, arg);
    }

    public virtual void Evaluate<T>(IPage page, string expression, object? arg = null)
    {
        page.Evaluate<T>(expression, arg);
    }

    public virtual void EvaluateHandle(IPage page, string expression, object? arg = null)
    {
        page.EvaluateHandle(expression, arg);
    }

    public virtual void ExposeBinding(IPage page, string name, Action<BindingSource> callback)
    {
        page.ExposeBinding(name, callback);
    }

    public virtual void ExposeBinding(IPage page, string name, Action callback, PageExposeBindingOptions? options = null)
    {
        page.ExposeBinding(name, callback, options);
    }

    public virtual void ExposeBinding<T>(IPage page, string name, Action<BindingSource, T> callback)
    {
        page.ExposeBinding<T>(name, callback);
    }

    public virtual void ExposeBinding<TResult>(IPage page, string name, Func<BindingSource, TResult> callback)
    {
        page.ExposeBinding<TResult>(name, callback);
    }

    public virtual void ExposeBinding<TResult>(IPage page, string name, Func<BindingSource, IJSHandle, TResult> callback)
    {
        page.ExposeBinding<TResult>(name, callback);
    }

    public virtual void ExposeBinding<T, TResult>(IPage page, string name, Func<BindingSource, T, TResult> callback)
    {
        page.ExposeBinding<T, TResult>(name, callback);
    }

    public virtual void ExposeBinding<T1, T2, TResult>(IPage page, string name, Func<BindingSource, T1, T2, TResult> callback)
    {
        page.ExposeBinding<T1, T2, TResult>(name, callback);
    }

    public virtual void ExposeBinding<T1, T2, T3, TResult>(IPage page, string name, Func<BindingSource, T1, T2, T3, TResult> callback)
    {
        page.ExposeBinding<T1, T2, T3, TResult>(name, callback);
    }

    public virtual void ExposeBinding<T1, T2, T3, T4, TResult>(IPage page, string name, Func<BindingSource, T1, T2, T3, T4, TResult> callback)
    {
        page.ExposeBinding<T1, T2, T3, T4, TResult>(name, callback);
    }

    public virtual void ExposeFunction(IPage page, string name, Action callback)
    {
        page.ExposeFunction(name, callback);
    }

    public virtual void ExposeFunction<T>(IPage page, string name, Action<T> callback)
    {
        page.ExposeFunction<T>(name, callback);
    }

    public virtual void ExposeFunction<TResult>(IPage page, string name, Func<TResult> callback)
    {
        page.ExposeFunction<TResult>(name, callback);
    }

    public virtual void ExposeFunction<T, TResult>(IPage page, string name, Func<T, TResult> callback)
    {
        page.ExposeFunction<T, TResult>(name, callback);
    }

    public virtual void ExposeFunction<T1, T2, TResult>(IPage page, string name, Func<T1, T2, TResult> callback)
    {
        page.ExposeFunction<T1, T2, TResult>(name, callback);
    }

    public virtual void ExposeFunction<T1, T2, T3, TResult>(IPage page, string name, Func<T1, T2, T3, TResult> callback)
    {
        page.ExposeFunction<T1, T2, T3, TResult>(name, callback);
    }

    public virtual void ExposeFunction<T1, T2, T3, T4, TResult>(IPage page, string name, Func<T1, T2, T3, T4, TResult> callback)
    {
        page.ExposeFunction<T1, T2, T3, T4, TResult>(name, callback);
    }

    public virtual string? GetAttribute(IPage page, string selector, string name, PageWaitForSelectorOptions? waitOptions = null, PageGetAttributeOptions? queryOptions = null)
    {
        return page.GetAttribute(selector, name, queryOptions);
    }

    public virtual string InnerHTML(IPage page, string selector, PageWaitForSelectorOptions? waitOptions = null, PageInnerHTMLOptions? queryOptions = null)
    {
        return page.InnerHTML(selector, queryOptions);
    }

    public virtual string InnerText(IPage page, string selector, PageInnerTextOptions? queryOptions = null)
    {
        return page.InnerText(selector, queryOptions);
    }

    public virtual string InputValue(IPage page, string selector, PageInputValueOptions? queryOptions = null)
    {
        return page.InputValue(selector, queryOptions);
    }

    public virtual bool IsChecked(IPage page, string selector, PageIsCheckedOptions? queryOptions = null)
    {
        return page.IsChecked(selector, queryOptions);
    }

    public virtual bool IsDisabled(IPage page, string selector, PageIsDisabledOptions? options = null)
    {
        return page.IsDisabled(selector, options);
    }

    public virtual bool IsEditable(IPage page, string selector, PageIsEditableOptions? options = null)
    {
        return page.IsEditable(selector, options);
    }

    public virtual bool IsEnabled(IPage page, string selector, PageIsEnabledOptions? options = null)
    {
        return page.IsEnabled(selector, options);
    }

    public virtual bool IsHidden(IPage page, string selector, PageIsHiddenOptions? options = null)
    {
        return page.IsHidden(selector, options);
    }

    public virtual bool IsVisible(IPage page, string selector, PageIsVisibleOptions? options = null)
    {
        return page.IsVisible(selector, options);
    }

    public virtual ILocator IsVisible(IPage page, string selector)
    {
        return page.Locator(selector);
    }

    public virtual void Route(IPage page, string url, Action<IRoute> handler, PageRouteOptions? options = null)
    {
        page.Route(url, handler, options);
    }

    public virtual void Route(IPage page, Regex url, Action<IRoute> handler, PageRouteOptions? options = null)
    {
        page.Route(url, handler, options);
    }

    public virtual void Route(IPage page, Func<string, bool> url, Action<IRoute> handler, PageRouteOptions? options = null)
    {
        page.Route(url, handler, options);
    }

    public virtual void Unroute(IPage page, string url, Action<IRoute>? handler = null)
    {
        page.Unroute(url, handler);
    }

    public virtual void Unroute(IPage page, Regex url, Action<IRoute>? handler = null)
    {
        page.Unroute(url, handler);
    }

    public virtual void Unroute(IPage page, Func<string, bool> url, Action<IRoute>? handler = null)
    {
        page.Unroute(url, handler);
    }

    public virtual IFrame? Frame(IPage page, string name)
    {
        return page.Frame(name);
    }

    public virtual IFrame? FrameByUrl(IPage page, string url)
    {
        return page.FrameByUrl(url);
    }

    public virtual IFrame? FrameByUrl(IPage page, Regex url)
    {
        return page.FrameByUrl(url);
    }

    public virtual IFrame? FrameyUrl(IPage page, Func<string, bool> url)
    {
        return page.FrameByUrl(url);
    }

    public virtual IConsoleMessage RunAndWaitForConsoleMessage(IPage page, Func<Task> action, PageRunAndWaitForConsoleMessageOptions? options = null)
    {
        return page.RunAndWaitForConsoleMessage(action, options);
    }

    public virtual IDownload RunAndWaitForDownload(IPage page, Func<Task> action, PageRunAndWaitForDownloadOptions? options = null)
    {
        return page.RunAndWaitForDownload(action, options);
    }

    public virtual IFileChooser RunAndWaitForFileChooser(IPage page, Func<Task> action, PageRunAndWaitForFileChooserOptions? options = null)
    {
        return page.RunAndWaitForFileChooser(action, options);
    }

    public virtual IResponse? RunAndWaitForNavigation(IPage page, Func<Task> action, PageRunAndWaitForNavigationOptions? options = null)
    {
        return page.RunAndWaitForNavigation(action, options);
    }

    public virtual IPage RunAndWaitForPopup(IPage page, Func<Task> action, PageRunAndWaitForPopupOptions? options = null)
    {
        return page.RunAndWaitForPopup(action, options);
    }

    public virtual IRequest RunAndWaitForRequest(IPage page, Func<Task> action, string urlOrPredicate, PageRunAndWaitForRequestOptions? options = null)
    {
        return page.RunAndWaitForRequest(action, urlOrPredicate, options);
    }

    public virtual IRequest RunAndWaitForRequest(IPage page, Func<Task> action, Regex urlOrPredicate, PageRunAndWaitForRequestOptions? options = null)
    {
        return page.RunAndWaitForRequest(action, urlOrPredicate, options);
    }

    public virtual IRequest RunAndWaitForRequest(IPage page, Func<Task> action, Func<IRequest, bool> urlOrPredicate, PageRunAndWaitForRequestOptions? options = null)
    {
        return page.RunAndWaitForRequest(action, urlOrPredicate, options);
    }

    public virtual IRequest RunAndWaitForRequestFinished(IPage page, Func<Task> action, PageRunAndWaitForRequestFinishedOptions? options = null)
    {
        return page.RunAndWaitForRequestFinished(action, options);
    }

    public virtual IResponse RunAndWaitForResponse(IPage page, Func<Task> action, string urlOrPredicate, PageRunAndWaitForResponseOptions? options = null)
    {
        return page.RunAndWaitForResponse(action, urlOrPredicate, options);
    }

    public virtual IResponse RunAndWaitForResponse(IPage page, Func<Task> action, Regex urlOrPredicate, PageRunAndWaitForResponseOptions? options = null)
    {
        return page.RunAndWaitForResponse(action, urlOrPredicate, options);
    }

    public virtual IWebSocket RunAndWaitForWebSocket(IPage page, Func<Task> action, PageRunAndWaitForWebSocketOptions? options = null)
    {
        return page.RunAndWaitForWebSocket(action, options);
    }

    public virtual void RunAndWaitForWorker(IPage page, Func<Task> action, PageRunAndWaitForWorkerOptions? options = null)
    {
        page.RunAndWaitForWorker(action, options);
    }

    public virtual void Screenshot(IPage page, PageScreenshotOptions? options = null)
    {
        page.Screenshot(options);
    }

    public virtual byte[] Pdf(IPage page, PagePdfOptions? options = null)
    {
        return page.Pdf(options);
    }

    public virtual void SetContent(IPage page, string html, PageSetContentOptions? options = null)
    {
        page.SetContent(html, options);
    }

    public virtual void SetExtraHTTPHeaders(IPage page, IEnumerable<KeyValuePair<string, string>> headers)
    {
        page.SetExtraHTTPHeaders(headers);
    }

    public virtual void SetViewportSize(IPage page, int width, int height)
    {
        page.SetViewportSize(width, height);
    }

    public virtual string? TextContent(IPage page, string selector, PageTextContentOptions? options = null)
    {
        return page.TextContent(selector, options);
    }

    public virtual string Title(IPage page)
    {
        return page.Title();
    }

    public virtual IConsoleMessage WaitForConsoleMessage(IPage page, PageWaitForConsoleMessageOptions? options = null)
    {
        return page.WaitForConsoleMessage(options);
    }

    public virtual IDownload WaitForDownload(IPage page, PageWaitForDownloadOptions? options = null)
    {
        return page.WaitForDownload(options);
    }

    public virtual IFileChooser WaitForFileChooser(IPage page, PageWaitForFileChooserOptions? options = null)
    {
        return page.WaitForFileChooser(options);
    }

    public virtual IJSHandle WaitForFunction(IPage page, string expression, object? arg = null, PageWaitForFunctionOptions? options = null)
    {
        return page.WaitForFunction(expression, arg, options);
    }

    public virtual void WaitForLoadState(IPage page, LoadState? state = null, PageWaitForLoadStateOptions? options = null)
    {
        page.WaitForLoadState(state, options);
    }

    public virtual IResponse? WaitForNavigation(IPage page, PageWaitForNavigationOptions? options = null)
    {
        return page.WaitForNavigation(options);
    }

    public virtual IPage WaitForPopup(IPage page, PageWaitForPopupOptions? options = null)
    {
        return page.WaitForPopup(options);
    }

    public virtual IRequest WaitForRequest(IPage page, string urlOrPredicate, PageWaitForRequestOptions? options = null)
    {
        return page.WaitForRequest(urlOrPredicate, options);
    }

    public virtual IRequest WaitForRequest(IPage page, Regex urlOrPredicate, PageWaitForRequestOptions? options = null)
    {
        return page.WaitForRequest(urlOrPredicate, options);
    }

    public virtual IRequest WaitForRequest(IPage page, Func<IRequest, bool> urlOrPredicate, PageWaitForRequestOptions? options = null)
    {
        return page.WaitForRequest(urlOrPredicate, options);
    }

    public virtual IRequest WaitForRequestFinished(IPage page, PageWaitForRequestFinishedOptions? options = null)
    {
        return page.WaitForRequestFinished(options);
    }

    public virtual IResponse WaitForResponse(IPage page, string urlOrPredicate, PageWaitForResponseOptions? options = null)
    {
        return page.WaitForResponse(urlOrPredicate, options);
    }

    public virtual IResponse WaitForResponse(IPage page, Regex urlOrPredicate, PageWaitForResponseOptions? options = null)
    {
        return page.WaitForResponse(urlOrPredicate, options);
    }

    public virtual IResponse WaitForResponse(IPage page, Func<IResponse, bool> urlOrPredicate, PageWaitForResponseOptions? options = null)
    {
        return page.WaitForResponse(urlOrPredicate, options);
    }

    public virtual IResponse RunAndWaitForResponse(IPage page, Func<Task> action, Func<IResponse, bool> urlOrPredicate, PageRunAndWaitForResponseOptions? options = null)
    {
        return page.RunAndWaitForResponse(action, urlOrPredicate, options);
    }

    public virtual IElementHandle? WaitForSelector(IPage page, string selector, PageWaitForSelectorOptions? options = null)
    {
        return page.WaitForSelector(selector, options);
    }

    public virtual void WaitForTimeout(IPage page, float timeout)
    {
        page.WaitForTimeout(timeout);
    }

    public virtual void WaitForURL(IPage page, Regex url, PageWaitForURLOptions? options = null)
    {
        page.WaitForURL(url, options);
    }

    public virtual void WaitForURL(IPage page, Func<string, bool> url, PageWaitForURLOptions? options = null)
    {
        page.WaitForURL(url, options);
    }

    public virtual IWebSocket WaitForWebSocket(IPage page, PageWaitForWebSocketOptions? options = null)
    {
        return page.WaitForWebSocket(options);
    }

    public virtual IWorker WaitForWorker(IPage page, PageWaitForWorkerOptions? options = null)
    {
        return page.WaitForWorker(options);
    }

    public virtual IPage? Opener(IPage page)
    {
        return page.Opener();
    }

    public virtual void Pause(IPage page)
    {
        page.Pause();
    }

    public string GetComputedStyle(
        IPage page,
        string selector,
        string styleName,
        PageWaitForSelectorOptions? waitOptions = null,
        PageQuerySelectorOptions? queryOptions = null)
    {
        var element = this.GetElement(page, selector, waitOptions, queryOptions);
        var styleValue = page.Evaluate<string>($"e => getComputedStyle(e).{styleName}", element);
        return styleValue;
    }
}
