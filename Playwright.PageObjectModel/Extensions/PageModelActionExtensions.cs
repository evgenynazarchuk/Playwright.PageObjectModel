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

using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Playwright.Synchronous;
using System.Collections.Generic;

namespace Playwright.PageObjectModel;

public static class PageModelActionExtensions
{
    public static TPageModel Wait<TPageModel>(this TPageModel pageModel)
        where TPageModel : IPageModel
    {
        pageModel.Actions.Wait();
        return pageModel;
    }

    public static TPageModel WaitForLoadState<TPageModel>(this TPageModel pageModel, LoadState loadState, PageWaitForLoadStateOptions? options = null)
        where TPageModel : IPageModel
    {
        pageModel.Actions.WaitForLoadState(pageModel.Page, loadState, options);
        return pageModel;
    }

    public static TPageModel Goto<TPageModel>(this PageModel pageModel, string url, PageGotoOptions? options = null)
        where TPageModel : PageModel
    {
        return pageModel.Actions.Goto<TPageModel>(pageModel.Page, url, options);
    }

    public static TPageModel GoBack<TPageModel>(this PageModel pageModel, IPage page, PageGoBackOptions? options = null)
        where TPageModel : PageModel
    {
        return pageModel.Actions.GoBack<TPageModel>(page, options);
    }

    public static TPageModel GoForward<TPageModel>(this PageModel pageModel, IPage page, PageGoForwardOptions? options = null)
        where TPageModel : PageModel
    {
        return pageModel.Actions.GoForward<TPageModel>(page, options);
    }

    public static TPageModel ReloadToPage<TPageModel>(this PageModel pageModel, IPage page, PageReloadOptions? options = null)
        where TPageModel : PageModel
    {
        return pageModel.Actions.ReloadToPage<TPageModel>(page, options);
    }

    public static TPageModel Click<TPageModel>(this TPageModel pageModel, string selector, PageClickOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Actions.Click(pageModel.Page, selector, options);
        return pageModel;
    }

    public static TReturnPageModel Click<TReturnPageModel>(this PageModel pageModel, string selector, PageClickOptions? options = null)
        where TReturnPageModel : PageModel
    {
        return pageModel.Actions.Click<TReturnPageModel>(pageModel.Page, selector, options); ;
    }

    public static TPageModel DblClick<TPageModel>(this TPageModel pageModel, string selector, PageDblClickOptions? options = null)
        where TPageModel : PageModel
    {
        pageModel.Actions.DblClick(pageModel.Page, selector, options);
        return pageModel;
    }

    public static void Type(IPage page, string selector, string value, PageTypeOptions? options = null)
    {
        page.Type(selector, value, options);
    }

    public static void Check(IPage page, string selector, PageCheckOptions? options = null)
    {
        page.Check(selector, options);
    }

    public static void Uncheck(IPage page, string selector, PageUncheckOptions? options = null)
    {
        page.Uncheck(selector, options);
    }

    public static void SetChecked(IPage page, string selector, bool checkedState, PageSetCheckedOptions? options = null)
    {
        page.SetChecked(selector, checkedState, options);
    }

    public static void Tap(IPage page, string selector, PageTapOptions? options = null)
    {
        page.Tap(selector, options);
    }

    public static void DragAndDrop(IPage page, string source, string target, PageDragAndDropOptions? options = null)
    {
        page.DragAndDrop(source, target, options);
    }

    public static void Focus(IPage page, string selector, PageFocusOptions? options = null)
    {
        page.Focus(selector, options);
    }

    public static void Fill(IPage page, string selector, string value, PageFillOptions? options = null)
    {
        page.Fill(selector, value, options);
    }

    public static void Hover(IPage page, string selector, PageHoverOptions? options = null)
    {
        page.Hover(selector, options);
    }

    public static void Press(IPage page, string selector, string key, PagePressOptions? options = null)
    {
        page.Press(selector, key, options);
    }

    public static IReadOnlyList<string> SelectOption(IPage page, string selector, string values, PageSelectOptionOptions? options = null)
    {
        var result = page.SelectOption(selector, values, options);
        return result;
    }

    public static IReadOnlyList<string> SelectOption(IPage page, string selector, IElementHandle values, PageSelectOptionOptions? options = null)
    {
        var result = page.SelectOption(selector, values, options);
        return result;
    }

    public static IReadOnlyList<string> SelectOption(IPage page, string selector, IEnumerable<string> values, PageSelectOptionOptions? options = null)
    {
        var result = page.SelectOption(selector, values, options);
        return result;
    }

    public static IReadOnlyList<string> SelectOption(IPage page, string selector, SelectOptionValue values, PageSelectOptionOptions? options = null)
    {
        var result = page.SelectOption(selector, values, options);
        return result;
    }

    public static IReadOnlyList<string> SelectOption(IPage page, string selector, IEnumerable<IElementHandle> values, PageSelectOptionOptions? options = null)
    {
        var result = page.SelectOption(selector, values, options);
        return result;
    }

    public static IReadOnlyList<string> SelectOption(IPage page, string selector, IEnumerable<SelectOptionValue> values, PageSelectOptionOptions? options = null)
    {
        var result = page.SelectOption(selector, values, options);
        return result;
    }

    public static void SetInputFiles(IPage page, string selector, string files, PageSetInputFilesOptions? options = null)
    {
        page.SetInputFiles(selector, files, options);
    }

    public static void SetInputFiles(IPage page, string selector, FilePayload files, PageSetInputFilesOptions? options = null)
    {
        page.SetInputFiles(selector, files, options);
    }

    public static void SetInputFiles(IPage page, string selector, IEnumerable<string> files, PageSetInputFilesOptions? options = null)
    {
        page.SetInputFiles(selector, files, options);
    }

    public static void SetInputFiles(IPage page, string selector, IEnumerable<FilePayload> files, PageSetInputFilesOptions? options = null)
    {
        page.SetInputFiles(selector, files, options);
    }

    public static void AddInitScript(IPage page, string? script = null, string? scriptPath = null)
    {
        page.AddInitScript(script, scriptPath);
    }

    public static void AddScriptTag(IPage page, PageAddScriptTagOptions? options = null)
    {
        page.AddScriptTag(options);
    }

    public static void AddStyleTag(IPage page, PageAddStyleTagOptions? options = null)
    {
        page.AddStyleTag(options);
    }

    public static void BringToFront(IPage page)
    {
        page.BringToFront();
    }

    public static void DispatchEvent(IPage page, string selector, string type, object? eventInit = null, PageDispatchEventOptions? options = null)
    {
        page.DispatchEvent(selector, type, eventInit, options); ;
    }

    public static void EmulateMedia(IPage page, PageEmulateMediaOptions? options = null)
    {
        page.EmulateMedia(options);
    }

    public static void EvalOnSelectorAll(IPage page, string selector, string expression, object? arg = null)
    {
        page.EvalOnSelectorAll(selector, expression, arg);
    }

    public static void EvalOnSelectorAll<T>(IPage page, string selector, string expression, object? arg = null)
    {
        page.EvalOnSelectorAll<T>(selector, expression, arg);
    }

    public static void EvalOnSelector(IPage page, string selector, string expression, object? arg = null)
    {
        page.EvalOnSelector(selector, expression, arg);
    }

    public static void EvalOnSelector<T>(IPage page, string selector, string expression, object? arg = null, PageEvalOnSelectorOptions? options = null)
    {
        page.EvalOnSelector<T>(selector, expression, arg, options);
    }

    public static void Evaluate(IPage page, string expression, object? arg = null)
    {
        page.Evaluate(expression, arg);
    }

    public static void Evaluate<T>(IPage page, string expression, object? arg = null)
    {
        page.Evaluate<T>(expression, arg);
    }

    public static void EvaluateHandle(IPage page, string expression, object? arg = null)
    {
        page.EvaluateHandle(expression, arg);
    }

    public static void ExposeBinding(IPage page, string name, Action<BindingSource> callback)
    {
        page.ExposeBinding(name, callback);
    }

    public static void ExposeBinding(IPage page, string name, Action callback, PageExposeBindingOptions? options = null)
    {
        page.ExposeBinding(name, callback, options);
    }

    public static void ExposeBinding<T>(IPage page, string name, Action<BindingSource, T> callback)
    {
        page.ExposeBinding<T>(name, callback);
    }

    public static void ExposeBinding<TResult>(IPage page, string name, Func<BindingSource, TResult> callback)
    {
        page.ExposeBinding<TResult>(name, callback);
    }

    public static void ExposeBinding<TResult>(IPage page, string name, Func<BindingSource, IJSHandle, TResult> callback)
    {
        page.ExposeBinding<TResult>(name, callback);
    }

    public static void ExposeBinding<T, TResult>(IPage page, string name, Func<BindingSource, T, TResult> callback)
    {
        page.ExposeBinding<T, TResult>(name, callback);
    }

    public static void ExposeBinding<T1, T2, TResult>(IPage page, string name, Func<BindingSource, T1, T2, TResult> callback)
    {
        page.ExposeBinding<T1, T2, TResult>(name, callback);
    }

    public static void ExposeBinding<T1, T2, T3, TResult>(IPage page, string name, Func<BindingSource, T1, T2, T3, TResult> callback)
    {
        page.ExposeBinding<T1, T2, T3, TResult>(name, callback);
    }

    public static void ExposeBinding<T1, T2, T3, T4, TResult>(IPage page, string name, Func<BindingSource, T1, T2, T3, T4, TResult> callback)
    {
        page.ExposeBinding<T1, T2, T3, T4, TResult>(name, callback);
    }

    public static void ExposeFunction(IPage page, string name, Action callback)
    {
        page.ExposeFunction(name, callback);
    }

    public static void ExposeFunction<T>(IPage page, string name, Action<T> callback)
    {
        page.ExposeFunction<T>(name, callback);
    }

    public static void ExposeFunction<TResult>(IPage page, string name, Func<TResult> callback)
    {
        page.ExposeFunction<TResult>(name, callback);
    }

    public static void ExposeFunction<T, TResult>(IPage page, string name, Func<T, TResult> callback)
    {
        page.ExposeFunction<T, TResult>(name, callback);
    }

    public static void ExposeFunction<T1, T2, TResult>(IPage page, string name, Func<T1, T2, TResult> callback)
    {
        page.ExposeFunction<T1, T2, TResult>(name, callback);
    }

    public static void ExposeFunction<T1, T2, T3, TResult>(IPage page, string name, Func<T1, T2, T3, TResult> callback)
    {
        page.ExposeFunction<T1, T2, T3, TResult>(name, callback);
    }

    public static void ExposeFunction<T1, T2, T3, T4, TResult>(IPage page, string name, Func<T1, T2, T3, T4, TResult> callback)
    {
        page.ExposeFunction<T1, T2, T3, T4, TResult>(name, callback);
    }

    public static void Route(IPage page, string url, Action<IRoute> handler, PageRouteOptions? options = null)
    {
        page.Route(url, handler, options);
    }

    public static void Route(IPage page, Regex url, Action<IRoute> handler, PageRouteOptions? options = null)
    {
        page.Route(url, handler, options);
    }

    public static void Route(IPage page, Func<string, bool> url, Action<IRoute> handler, PageRouteOptions? options = null)
    {
        page.Route(url, handler, options);
    }

    public static void Unroute(IPage page, string url, Action<IRoute>? handler = null)
    {
        page.Unroute(url, handler);
    }

    public static void Unroute(IPage page, Regex url, Action<IRoute>? handler = null)
    {
        page.Unroute(url, handler);
    }

    public static void Unroute(IPage page, Func<string, bool> url, Action<IRoute>? handler = null)
    {
        page.Unroute(url, handler);
    }

    public static IConsoleMessage RunAndWaitForConsoleMessage(IPage page, Func<Task> action, PageRunAndWaitForConsoleMessageOptions? options = null)
    {
        return page.RunAndWaitForConsoleMessage(action, options);
    }

    public static IDownload RunAndWaitForDownload(IPage page, Func<Task> action, PageRunAndWaitForDownloadOptions? options = null)
    {
        return page.RunAndWaitForDownload(action, options);
    }

    public static IFileChooser RunAndWaitForFileChooser(IPage page, Func<Task> action, PageRunAndWaitForFileChooserOptions? options = null)
    {
        return page.RunAndWaitForFileChooser(action, options);
    }

    public static IResponse? RunAndWaitForNavigation(IPage page, Func<Task> action, PageRunAndWaitForNavigationOptions? options = null)
    {
        return page.RunAndWaitForNavigation(action, options);
    }

    public static IPage RunAndWaitForPopup(IPage page, Func<Task> action, PageRunAndWaitForPopupOptions? options = null)
    {
        return page.RunAndWaitForPopup(action, options);
    }

    public static IRequest RunAndWaitForRequest(IPage page, Func<Task> action, string urlOrPredicate, PageRunAndWaitForRequestOptions? options = null)
    {
        return page.RunAndWaitForRequest(action, urlOrPredicate, options);
    }

    public static IRequest RunAndWaitForRequest(IPage page, Func<Task> action, Regex urlOrPredicate, PageRunAndWaitForRequestOptions? options = null)
    {
        return page.RunAndWaitForRequest(action, urlOrPredicate, options);
    }

    public static IRequest RunAndWaitForRequest(IPage page, Func<Task> action, Func<IRequest, bool> urlOrPredicate, PageRunAndWaitForRequestOptions? options = null)
    {
        return page.RunAndWaitForRequest(action, urlOrPredicate, options);
    }

    public static IRequest RunAndWaitForRequestFinished(IPage page, Func<Task> action, PageRunAndWaitForRequestFinishedOptions? options = null)
    {
        return page.RunAndWaitForRequestFinished(action, options);
    }

    public static IResponse RunAndWaitForResponse(IPage page, Func<Task> action, string urlOrPredicate, PageRunAndWaitForResponseOptions? options = null)
    {
        return page.RunAndWaitForResponse(action, urlOrPredicate, options);
    }

    public static IResponse RunAndWaitForResponse(IPage page, Func<Task> action, Regex urlOrPredicate, PageRunAndWaitForResponseOptions? options = null)
    {
        return page.RunAndWaitForResponse(action, urlOrPredicate, options);
    }

    public static IWebSocket RunAndWaitForWebSocket(IPage page, Func<Task> action, PageRunAndWaitForWebSocketOptions? options = null)
    {
        return page.RunAndWaitForWebSocket(action, options);
    }

    public static void RunAndWaitForWorker(IPage page, Func<Task> action, PageRunAndWaitForWorkerOptions? options = null)
    {
        page.RunAndWaitForWorker(action, options);
    }

    public static void Screenshot(IPage page, PageScreenshotOptions? options = null)
    {
        page.Screenshot(options);
    }

    public static byte[] Pdf(IPage page, PagePdfOptions? options = null)
    {
        return page.Pdf(options);
    }

    public static void SetContent(IPage page, string html, PageSetContentOptions? options = null)
    {
        page.SetContent(html, options);
    }

    public static void SetExtraHTTPHeaders(IPage page, IEnumerable<KeyValuePair<string, string>> headers)
    {
        page.SetExtraHTTPHeaders(headers);
    }

    public static void SetViewportSize(IPage page, int width, int height)
    {
        page.SetViewportSize(width, height);
    }

    public static IConsoleMessage WaitForConsoleMessage(IPage page, PageWaitForConsoleMessageOptions? options = null)
    {
        return page.WaitForConsoleMessage(options);
    }

    public static IDownload WaitForDownload(IPage page, PageWaitForDownloadOptions? options = null)
    {
        return page.WaitForDownload(options);
    }

    public static IFileChooser WaitForFileChooser(IPage page, PageWaitForFileChooserOptions? options = null)
    {
        return page.WaitForFileChooser(options);
    }

    public static IJSHandle WaitForFunction(IPage page, string expression, object? arg = null, PageWaitForFunctionOptions? options = null)
    {
        return page.WaitForFunction(expression, arg, options);
    }

    public static void WaitForLoadState(IPage page, LoadState? state = null, PageWaitForLoadStateOptions? options = null)
    {
        page.WaitForLoadState(state, options);
    }

    public static IResponse? WaitForNavigation(IPage page, PageWaitForNavigationOptions? options = null)
    {
        return page.WaitForNavigation(options);
    }

    public static IPage WaitForPopup(IPage page, PageWaitForPopupOptions? options = null)
    {
        return page.WaitForPopup(options);
    }

    public static IRequest WaitForRequest(IPage page, string urlOrPredicate, PageWaitForRequestOptions? options = null)
    {
        return page.WaitForRequest(urlOrPredicate, options);
    }

    public static IRequest WaitForRequest(IPage page, Regex urlOrPredicate, PageWaitForRequestOptions? options = null)
    {
        return page.WaitForRequest(urlOrPredicate, options);
    }

    public static IRequest WaitForRequest(IPage page, Func<IRequest, bool> urlOrPredicate, PageWaitForRequestOptions? options = null)
    {
        return page.WaitForRequest(urlOrPredicate, options);
    }

    public static IRequest WaitForRequestFinished(IPage page, PageWaitForRequestFinishedOptions? options = null)
    {
        return page.WaitForRequestFinished(options);
    }

    public static IResponse WaitForResponse(IPage page, string urlOrPredicate, PageWaitForResponseOptions? options = null)
    {
        return page.WaitForResponse(urlOrPredicate, options);
    }

    public static IResponse WaitForResponse(IPage page, Regex urlOrPredicate, PageWaitForResponseOptions? options = null)
    {
        return page.WaitForResponse(urlOrPredicate, options);
    }

    public static IResponse WaitForResponse(IPage page, Func<IResponse, bool> urlOrPredicate, PageWaitForResponseOptions? options = null)
    {
        return page.WaitForResponse(urlOrPredicate, options);
    }

    public static IResponse RunAndWaitForResponse(IPage page, Func<Task> action, Func<IResponse, bool> urlOrPredicate, PageRunAndWaitForResponseOptions? options = null)
    {
        return page.RunAndWaitForResponse(action, urlOrPredicate, options);
    }

    public static IElementHandle? WaitForSelector(IPage page, string selector, PageWaitForSelectorOptions? options = null)
    {
        return page.WaitForSelector(selector, options);
    }

    public static void WaitForTimeout(IPage page, float timeout)
    {
        page.WaitForTimeout(timeout);
    }

    public static void WaitForURL(IPage page, Regex url, PageWaitForURLOptions? options = null)
    {
        page.WaitForURL(url, options);
    }

    public static void WaitForURL(IPage page, Func<string, bool> url, PageWaitForURLOptions? options = null)
    {
        page.WaitForURL(url, options);
    }

    public static IWebSocket WaitForWebSocket(IPage page, PageWaitForWebSocketOptions? options = null)
    {
        return page.WaitForWebSocket(options);
    }

    public static IWorker WaitForWorker(IPage page, PageWaitForWorkerOptions? options = null)
    {
        return page.WaitForWorker(options);
    }

    public static void Pause(IPage page)
    {
        page.Pause();
    }
}
