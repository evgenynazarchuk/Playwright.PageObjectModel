/*
 * MIT License
 *
 * Copyright (c) Evgeny Naazarchuk.
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;
using System.Text.RegularExpressions;

namespace Playwright.PageObjectModel.Interfaces.ModelActions;

public interface IPageModelActions
{
    void Wait();

    void WaitForLoadState(IPage page, LoadState loadState, PageWaitForLoadStateOptions? options = null);

    TPageModel CreatePageModel<TPageModel>(IPage page)
        where TPageModel : PageModel;

    TBlockModel CreateBlockModel<TBlockModel>(PageModel pageModel, Type PageModelType, string selector)
        where TBlockModel : class;

    TBlockModel CreateBlockModel<TBlockModel>(PageModel pageModel, Type pageModelType, IElementHandle element)
        where TBlockModel : class;

    TPageModel Goto<TPageModel>(IPage page, string url, PageGotoOptions? options = null)
        where TPageModel : PageModel;

    TPageModel GoBack<TPageModel>(IPage page, PageGoBackOptions? options = null)
        where TPageModel : PageModel;

    TPageModel GoForward<TPageModel>(IPage page, PageGoForwardOptions? options = null)
        where TPageModel : PageModel;

    TPageModel ReloadToPage<TPageModel>(IPage page, PageReloadOptions? options = null)
        where TPageModel : PageModel;

    void Close(IPage page, PageCloseOptions? options = null);

    IElementHandle? QuerySelector(IPage page, string selector, PageQuerySelectorOptions? options = null);

    IReadOnlyList<IElementHandle> QuerySelectorAll(IPage page, string selector);

    IElementHandle GetElement(
        IPage page,
        string selector,
        PageWaitForSelectorOptions? waitOptions = null,
        PageQuerySelectorOptions? queryOptions = null);

    IReadOnlyCollection<IElementHandle> GetElements(IPage page, string selector, PageWaitForSelectorOptions? waitOptions = null);

    TBlockModel GetBlockModel<TBlockModel>(
        PageModel pageModel,
        Type pageModelType,
        string selector,
        PageWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : class;

    IReadOnlyCollection<TBlockModel> GetBlockModels<TBlockModel>(
        PageModel pageModel,
        Type pageModelType,
        string selector,
        PageWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : class;

    IElementHandle? GetElementOrNull(
        IPage page,
        string selector,
        PageWaitForSelectorOptions? waitOptions = null,
        PageQuerySelectorOptions? queryOptions = null);

    TBlockModel? GetBlockModelOrNull<TBlockModel>(PageModel pageModel, Type pageModelType, string selector)
        where TBlockModel : class;

    void Click(IPage page, string selector, PageClickOptions? options = null);

    TReturnPage Click<TReturnPage>(IPage page, string selector, PageClickOptions? options = null)
        where TReturnPage : PageModel;

    void DblClick(IPage page, string selector, PageDblClickOptions? options = null);

    void Type(IPage page, string selector, string value, PageTypeOptions? options = null);

    void Check(IPage page, string selector, PageCheckOptions? options = null);

    void Uncheck(IPage page, string selector, PageUncheckOptions? options = null);

    void SetChecked(IPage page, string selector, bool checkedState, PageSetCheckedOptions? options = null);

    void Tap(IPage page, string selector, PageTapOptions? options = null);

    void DragAndDrop(IPage page, string source, string target, PageDragAndDropOptions? options = null);

    void Focus(IPage page, string selector, PageFocusOptions? options = null);

    void Fill(IPage page, string selector, string value, PageFillOptions? options = null);

    void Hover(IPage page, string selector, PageHoverOptions? options = null);

    void Press(IPage page, string selector, string key, PagePressOptions? options = null);

    IReadOnlyList<string> SelectOption(IPage page, string selector, string values, PageSelectOptionOptions? options = null);

    IReadOnlyList<string> SelectOption(IPage page, string selector, IElementHandle values, PageSelectOptionOptions? options = null);

    IReadOnlyList<string> SelectOption(IPage page, string selector, IEnumerable<string> values, PageSelectOptionOptions? options = null);

    IReadOnlyList<string> SelectOption(IPage page, string selector, SelectOptionValue values, PageSelectOptionOptions? options = null);

    IReadOnlyList<string> SelectOption(IPage page, string selector, IEnumerable<IElementHandle> values, PageSelectOptionOptions? options = null);

    IReadOnlyList<string> SelectOption(IPage page, string selector, IEnumerable<SelectOptionValue> values, PageSelectOptionOptions? options = null);

    void SetInputFiles(IPage page, string selector, string files, PageSetInputFilesOptions? options = null);

    void SetInputFiles(IPage page, string selector, FilePayload files, PageSetInputFilesOptions? options = null);

    void SetInputFiles(IPage page, string selector, IEnumerable<string> files, PageSetInputFilesOptions? options = null);

    void SetInputFiles(IPage page, string selector, IEnumerable<FilePayload> files, PageSetInputFilesOptions? options = null);

    void AddInitScript(IPage page, string? script = null, string? scriptPath = null);

    void AddScriptTag(IPage page, PageAddScriptTagOptions? options = null);

    void AddStyleTag(IPage page, PageAddStyleTagOptions? options = null);

    void BringToFront(IPage page);

    string Content(IPage page);

    void DispatchEvent(IPage page, string selector, string type, object? eventInit = null, PageDispatchEventOptions? options = null);

    void EmulateMedia(IPage page, PageEmulateMediaOptions? options = null);

    void EvalOnSelectorAll(IPage page, string selector, string expression, object? arg = null);

    void EvalOnSelectorAll<T>(IPage page, string selector, string expression, object? arg = null);

    void EvalOnSelector(IPage page, string selector, string expression, object? arg = null);

    void EvalOnSelector<T>(IPage page, string selector, string expression, object? arg = null, PageEvalOnSelectorOptions? options = null);

    void Evaluate(IPage page, string expression, object? arg = null);

    void Evaluate<T>(IPage page, string expression, object? arg = null);

    void EvaluateHandle(IPage page, string expression, object? arg = null);

    void ExposeBinding(IPage page, string name, Action<BindingSource> callback);

    void ExposeBinding(IPage page, string name, Action callback, PageExposeBindingOptions? options = null);

    void ExposeBinding<T>(IPage page, string name, Action<BindingSource, T> callback);

    void ExposeBinding<TResult>(IPage page, string name, Func<BindingSource, TResult> callback);

    void ExposeBinding<TResult>(IPage page, string name, Func<BindingSource, IJSHandle, TResult> callback);

    void ExposeBinding<T, TResult>(IPage page, string name, Func<BindingSource, T, TResult> callback);

    void ExposeBinding<T1, T2, TResult>(IPage page, string name, Func<BindingSource, T1, T2, TResult> callback);

    void ExposeBinding<T1, T2, T3, TResult>(IPage page, string name, Func<BindingSource, T1, T2, T3, TResult> callback);

    void ExposeBinding<T1, T2, T3, T4, TResult>(IPage page, string name, Func<BindingSource, T1, T2, T3, T4, TResult> callback);

    void ExposeFunction(IPage page, string name, Action callback);

    void ExposeFunction<T>(IPage page, string name, Action<T> callback);

    void ExposeFunction<TResult>(IPage page, string name, Func<TResult> callback);

    void ExposeFunction<T, TResult>(IPage page, string name, Func<T, TResult> callback);

    void ExposeFunction<T1, T2, TResult>(IPage page, string name, Func<T1, T2, TResult> callback);

    void ExposeFunction<T1, T2, T3, TResult>(IPage page, string name, Func<T1, T2, T3, TResult> callback);

    void ExposeFunction<T1, T2, T3, T4, TResult>(IPage page, string name, Func<T1, T2, T3, T4, TResult> callback);

    string? GetAttribute(IPage page, string selector, string name, PageWaitForSelectorOptions? waitOptions = null, PageGetAttributeOptions? queryOptions = null);

    string InnerHTML(IPage page, string selector, PageWaitForSelectorOptions? waitOptions = null, PageInnerHTMLOptions? queryOptions = null);

    string InnerText(IPage page, string selector, PageInnerTextOptions? queryOptions = null);

    string InputValue(IPage page, string selector, PageInputValueOptions? queryOptions = null);

    bool IsChecked(IPage page, string selector, PageIsCheckedOptions? queryOptions = null);

    bool IsDisabled(IPage page, string selector, PageIsDisabledOptions? options = null);

    bool IsEditable(IPage page, string selector, PageIsEditableOptions? options = null);

    bool IsEnabled(IPage page, string selector, PageIsEnabledOptions? options = null);

    bool IsHidden(IPage page, string selector, PageIsHiddenOptions? options = null);

    bool IsVisible(IPage page, string selector, PageIsVisibleOptions? options = null);

    ILocator IsVisible(IPage page, string selector);

    void Route(IPage page, string url, Action<IRoute> handler, PageRouteOptions? options = null);

    void Route(IPage page, Regex url, Action<IRoute> handler, PageRouteOptions? options = null);

    void Route(IPage page, Func<string, bool> url, Action<IRoute> handler, PageRouteOptions? options = null);

    void Unroute(IPage page, string url, Action<IRoute>? handler = null);

    void Unroute(IPage page, Regex url, Action<IRoute>? handler = null);

    void Unroute(IPage page, Func<string, bool> url, Action<IRoute>? handler = null);

    IFrame? Frame(IPage page, string name);

    IFrame? FrameByUrl(IPage page, string url);

    IFrame? FrameByUrl(IPage page, Regex url);

    IFrame? FrameyUrl(IPage page, Func<string, bool> url);

    IConsoleMessage RunAndWaitForConsoleMessage(IPage page, Func<Task> action, PageRunAndWaitForConsoleMessageOptions? options = null);

    IDownload RunAndWaitForDownload(IPage page, Func<Task> action, PageRunAndWaitForDownloadOptions? options = null);

    IFileChooser RunAndWaitForFileChooser(IPage page, Func<Task> action, PageRunAndWaitForFileChooserOptions? options = null);

    IResponse? RunAndWaitForNavigation(IPage page, Func<Task> action, PageRunAndWaitForNavigationOptions? options = null);

    IPage RunAndWaitForPopup(IPage page, Func<Task> action, PageRunAndWaitForPopupOptions? options = null);

    IRequest RunAndWaitForRequest(IPage page, Func<Task> action, string urlOrPredicate, PageRunAndWaitForRequestOptions? options = null);

    IRequest RunAndWaitForRequest(IPage page, Func<Task> action, Regex urlOrPredicate, PageRunAndWaitForRequestOptions? options = null);

    IRequest RunAndWaitForRequest(IPage page, Func<Task> action, Func<IRequest, bool> urlOrPredicate, PageRunAndWaitForRequestOptions? options = null);

    IRequest RunAndWaitForRequestFinished(IPage page, Func<Task> action, PageRunAndWaitForRequestFinishedOptions? options = null);

    IResponse RunAndWaitForResponse(IPage page, Func<Task> action, string urlOrPredicate, PageRunAndWaitForResponseOptions? options = null);

    IResponse RunAndWaitForResponse(IPage page, Func<Task> action, Regex urlOrPredicate, PageRunAndWaitForResponseOptions? options = null);

    IWebSocket RunAndWaitForWebSocket(IPage page, Func<Task> action, PageRunAndWaitForWebSocketOptions? options = null);

    void RunAndWaitForWorker(IPage page, Func<Task> action, PageRunAndWaitForWorkerOptions? options = null);

    void Screenshot(IPage page, PageScreenshotOptions? options = null);

    byte[] Pdf(IPage page, PagePdfOptions? options = null);

    void SetContent(IPage page, string html, PageSetContentOptions? options = null);

    void SetExtraHTTPHeaders(IPage page, IEnumerable<KeyValuePair<string, string>> headers);

    void SetViewportSize(IPage page, int width, int height);

    string? TextContent(IPage page, string selector, PageTextContentOptions? options = null);

    string Title(IPage page);

    IConsoleMessage WaitForConsoleMessage(IPage page, PageWaitForConsoleMessageOptions? options = null);

    IDownload WaitForDownload(IPage page, PageWaitForDownloadOptions? options = null);

    IFileChooser WaitForFileChooser(IPage page, PageWaitForFileChooserOptions? options = null);

    IJSHandle WaitForFunction(IPage page, string expression, object? arg = null, PageWaitForFunctionOptions? options = null);

    void WaitForLoadState(IPage page, LoadState? state = null, PageWaitForLoadStateOptions? options = null);

    IResponse? WaitForNavigation(IPage page, PageWaitForNavigationOptions? options = null);

    IPage WaitForPopup(IPage page, PageWaitForPopupOptions? options = null);

    IRequest WaitForRequest(IPage page, string urlOrPredicate, PageWaitForRequestOptions? options = null);

    IRequest WaitForRequest(IPage page, Regex urlOrPredicate, PageWaitForRequestOptions? options = null);

    IRequest WaitForRequest(IPage page, Func<IRequest, bool> urlOrPredicate, PageWaitForRequestOptions? options = null);

    IRequest WaitForRequestFinished(IPage page, PageWaitForRequestFinishedOptions? options = null);

    IResponse WaitForResponse(IPage page, string urlOrPredicate, PageWaitForResponseOptions? options = null);

    IResponse WaitForResponse(IPage page, Regex urlOrPredicate, PageWaitForResponseOptions? options = null);

    IResponse WaitForResponse(IPage page, Func<IResponse, bool> urlOrPredicate, PageWaitForResponseOptions? options = null);

    IResponse RunAndWaitForResponse(IPage page, Func<Task> action, Func<IResponse, bool> urlOrPredicate, PageRunAndWaitForResponseOptions? options = null);

    IElementHandle? WaitForSelector(IPage page, string selector, PageWaitForSelectorOptions? options = null);

    void WaitForTimeout(IPage page, float timeout);

    void WaitForURL(IPage page, Regex url, PageWaitForURLOptions? options = null);

    void WaitForURL(IPage page, Func<string, bool> url, PageWaitForURLOptions? options = null);

    IWebSocket WaitForWebSocket(IPage page, PageWaitForWebSocketOptions? options = null);

    IWorker WaitForWorker(IPage page, PageWaitForWorkerOptions? options = null);

    IPage? Opener(IPage page);

    void Pause(IPage page);

    string GetComputedStyle(
        IPage page,
        string selector,
        string styleName,
        PageWaitForSelectorOptions? waitOptions = null,
        PageQuerySelectorOptions? queryOptions = null);
}
