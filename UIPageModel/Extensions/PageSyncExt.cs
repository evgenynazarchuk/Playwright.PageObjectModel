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

namespace UITesting.Page.Sync;

public static class PageSyncExt
{
    public static void Click(this IPage page, string selector, PageClickOptions? options = null)
    {
        page.ClickAsync(selector, options).GetAwaiter().GetResult();
    }

    public static void DblClick(this IPage page, string selector, PageDblClickOptions? options = null)
    {
        page.DblClickAsync(selector, options).GetAwaiter().GetResult();
    }

    public static void Type(this IPage page, string selector, string value, PageTypeOptions? options = null)
    {
        page.TypeAsync(selector, value, options).GetAwaiter().GetResult();
    }

    public static void SetInputFiles(this IPage page, string selector, string files, PageSetInputFilesOptions? options = null)
    {
        page.SetInputFilesAsync(selector, files, options).GetAwaiter().GetResult();
    }

    public static void SetInputFiles(this IPage page, string selector, FilePayload files, PageSetInputFilesOptions? options = null)
    {
        page.SetInputFilesAsync(selector, files, options).GetAwaiter().GetResult();
    }

    public static void SetInputFiles(this IPage page, string selector, IEnumerable<string> files, PageSetInputFilesOptions? options = null)
    {
        page.SetInputFilesAsync(selector, files, options).GetAwaiter().GetResult();
    }

    public static void SetInputFiles(this IPage page, string selector, IEnumerable<FilePayload> files, PageSetInputFilesOptions? options = null)
    {
        page.SetInputFilesAsync(selector, files, options).GetAwaiter().GetResult();
    }

    public static void AddInitScript(this IPage page, string? script = null, string? scriptPath = null)
    {
        page.AddInitScriptAsync(script, scriptPath).GetAwaiter().GetResult();
    }

    public static void AddScriptTag(this IPage page, PageAddScriptTagOptions? options = null)
    {
        page.AddScriptTagAsync(options).GetAwaiter().GetResult();
    }

    public static void AddStyleTag(this IPage page, PageAddStyleTagOptions? options = null)
    {
        page.AddStyleTagAsync(options).GetAwaiter().GetResult();
    }

    public static void BringToFront(this IPage page)
    {
        page.BringToFrontAsync().GetAwaiter().GetResult();
    }

    public static void BringToFront(this IPage page, string selector, PageCheckOptions? options = null)
    {
        page.CheckAsync(selector, options).GetAwaiter().GetResult();
    }

    public static string Content(this IPage page)
    {
        return page.ContentAsync().GetAwaiter().GetResult();
    }

    public static void DispatchEvent(this IPage page, string selector, string type, object? eventInit = null, PageDispatchEventOptions? options = null)
    {
        page.DispatchEventAsync(selector, type, eventInit, options).GetAwaiter().GetResult();
    }

    public static void DragAndDrop(this IPage page, string source, string target, PageDragAndDropOptions? options = null)
    {
        page.DragAndDropAsync(source, target, options).GetAwaiter().GetResult();
    }

    public static void EmulateMedia(this IPage page, PageEmulateMediaOptions? options = null)
    {
        page.EmulateMediaAsync(options).GetAwaiter().GetResult();
    }

    public static void EvalOnSelectorAll(this IPage page, string selector, string expression, object? arg = null)
    {
        page.EvalOnSelectorAllAsync(selector, expression, arg).GetAwaiter().GetResult();
    }

    public static void EvalOnSelectorAll<T>(this IPage page, string selector, string expression, object? arg = null)
    {
        page.EvalOnSelectorAllAsync<T>(selector, expression, arg).GetAwaiter().GetResult();
    }

    public static void EvalOnSelector(this IPage page, string selector, string expression, object? arg = null)
    {
        page.EvalOnSelectorAsync(selector, expression, arg).GetAwaiter().GetResult();
    }

    public static void EvalOnSelector<T>(this IPage page, string selector, string expression, object? arg = null, PageEvalOnSelectorOptions? options = null)
    {
        page.EvalOnSelectorAsync<T>(selector, expression, arg, options).GetAwaiter().GetResult();
    }

    public static void Evaluate(this IPage page, string expression, object? arg = null)
    {
        page.EvaluateAsync(expression, arg).GetAwaiter().GetResult();
    }

    public static void Evaluate<T>(this IPage page, string expression, object? arg = null)
    {
        page.EvaluateAsync<T>(expression, arg);
    }

    public static void EvaluateHandle(this IPage page, string expression, object? arg = null)
    {
        page.EvaluateHandleAsync(expression, arg).GetAwaiter().GetResult();
    }

    public static void ExposeBinding(this IPage page, string name, Action callback, PageExposeBindingOptions? options = null)
    {
        page.ExposeBindingAsync(name, callback, options).GetAwaiter().GetResult();
    }

    public static void ExposeBinding<T>(this IPage page, string name, Action<BindingSource, T> callback)
    {
        page.ExposeBindingAsync<T>(name, callback).GetAwaiter().GetResult();
    }

    public static void ExposeBinding<TResult>(this IPage page, string name, Func<BindingSource, TResult> callback)
    {
        page.ExposeBindingAsync<TResult>(name, callback).GetAwaiter().GetResult();
    }

    public static void ExposeBinding<TResult>(this IPage page, string name, Func<BindingSource, IJSHandle, TResult> callback)
    {
        page.ExposeBindingAsync<TResult>(name, callback).GetAwaiter().GetResult();
    }

    public static void ExposeBinding<T, TResult>(this IPage page, string name, Func<BindingSource, T, TResult> callback)
    {
        page.ExposeBindingAsync<T, TResult>(name, callback).GetAwaiter().GetResult();
    }

    public static void ExposeBinding<T1, T2, TResult>(this IPage page, string name, Func<BindingSource, T1, T2, TResult> callback)
    {
        page.ExposeBindingAsync<T1, T2, TResult>(name, callback).GetAwaiter().GetResult();
    }

    public static void ExposeBinding<T1, T2, T3, TResult>(this IPage page, string name, Func<BindingSource, T1, T2, T3, TResult> callback)
    {
        page.ExposeBindingAsync<T1, T2, T3, TResult>(name, callback).GetAwaiter().GetResult();
    }

    public static void ExposeBinding<T1, T2, T3, T4, TResult>(this IPage page, string name, Func<BindingSource, T1, T2, T3, T4, TResult> callback)
    {
        page.ExposeBindingAsync<T1, T2, T3, T4, TResult>(name, callback).GetAwaiter().GetResult();
    }

    public static void ExposeFunction(this IPage page, string name, Action callback)
    {
        page.ExposeFunctionAsync(name, callback).GetAwaiter().GetResult();
    }

    public static void ExposeFunction<T>(this IPage page, string name, Action<T> callback)
    {
        page.ExposeFunctionAsync<T>(name, callback);
    }

    public static void ExposeFunction<TResult>(this IPage page, string name, Func<TResult> callback)
    {
        page.ExposeFunctionAsync<TResult>(name, callback);
    }

    public static void ExposeFunction<T, TResult>(this IPage page, string name, Func<T, TResult> callback)
    {
        page.ExposeFunctionAsync<T, TResult>(name, callback);
    }

    public static void ExposeFunction<T1, T2, TResult>(this IPage page, string name, Func<T1, T2, TResult> callback)
    {
        page.ExposeFunctionAsync<T1, T2, TResult>(name, callback);
    }

    public static void ExposeFunction<T1, T2, T3, TResult>(this IPage page, string name, Func<T1, T2, T3, TResult> callback)
    {
        page.ExposeFunctionAsync<T1, T2, T3, TResult>(name, callback);
    }

    public static void ExposeFunction<T1, T2, T3, T4, TResult>(this IPage page, string name, Func<T1, T2, T3, T4, TResult> callback)
    {
        page.ExposeFunctionAsync<T1, T2, T3, T4, TResult>(name, callback);
    }

    public static void Focus(this IPage page, string selector, PageFocusOptions? options = null)
    {
        page.FocusAsync(selector, options).GetAwaiter().GetResult();
    }

    public static IFrame? Frame(this IPage page, string name)
    {
        return page.Frame(name);
    }

    public static IFrame? FrameByUrl(this IPage page, string url)
    {
        return page.FrameByUrl(url);
    }

    public static IFrame? FrameByUrl(this IPage page, Regex url)
    {
        return page.FrameByUrl(url);
    }

    public static IFrame? FrameyUrl(this IPage page, Func<string, bool> url)
    {
        return page.FrameByUrl(url);
    }

    public static void GetAttribute(this IPage page, string selector, string name, PageGetAttributeOptions? options = null)
    {
        page.GetAttributeAsync(selector, name, options).GetAwaiter().GetResult();
    }

    public static void GoBack(this IPage page, PageGoBackOptions? options = null)
    {
        page.GoBackAsync(options).GetAwaiter().GetResult();
    }

    public static void GoForward(this IPage page, PageGoForwardOptions? options = null)
    {
        page.GoForwardAsync(options).GetAwaiter().GetResult();
    }

    public static void Goto(this IPage page, string url, PageGotoOptions? options = null)
    {
        page.GotoAsync(url, options).GetAwaiter().GetResult();
    }

    public static void Hover(this IPage page, string selector, PageHoverOptions? options = null)
    {
        page.HoverAsync(selector, options).GetAwaiter().GetResult();
    }

    public static void InnerHTML(this IPage page, string selector, PageInnerHTMLOptions? options = null)
    {
        page.InnerHTMLAsync(selector, options).GetAwaiter().GetResult();
    }

    public static void InnerText(this IPage page, string selector, PageInnerTextOptions? options = null)
    {
        page.InnerTextAsync(selector, options).GetAwaiter().GetResult();
    }

    public static void InputValue(this IPage page, string selector, PageInputValueOptions? options = null)
    {
        page.InputValueAsync(selector, options).GetAwaiter().GetResult();
    }

    public static bool IsChecked(this IPage page, string selector, PageIsCheckedOptions? options = null)
    {
        return page.IsCheckedAsync(selector, options).GetAwaiter().GetResult();
    }

    public static bool IsDisabled(this IPage page, string selector, PageIsDisabledOptions? options = null)
    {
        return page.IsDisabledAsync(selector, options).GetAwaiter().GetResult();
    }

    public static bool IsEditable(this IPage page, string selector, PageIsEditableOptions? options = null)
    {
        return page.IsEditableAsync(selector, options).GetAwaiter().GetResult();
    }

    public static bool IsEnabled(this IPage page, string selector, PageIsEnabledOptions? options = null)
    {
        return page.IsEnabledAsync(selector, options).GetAwaiter().GetResult();
    }

    public static bool IsHidden(this IPage page, string selector, PageIsHiddenOptions? options = null)
    {
        return page.IsHiddenAsync(selector, options).GetAwaiter().GetResult();
    }

    public static bool IsVisible(this IPage page, string selector, PageIsVisibleOptions? options = null)
    {
        return page.IsVisibleAsync(selector, options).GetAwaiter().GetResult();
    }

    public static IPage? Opener(this IPage page)
    {
        return page.OpenerAsync().GetAwaiter().GetResult();
    }

    public static void Pause(this IPage page)
    {
        page.PauseAsync().GetAwaiter().GetResult();
    }

    public static byte[] Pdf(this IPage page, PagePdfOptions? options = null)
    {
        return page.PdfAsync(options).GetAwaiter().GetResult();
    }

    public static void Press(this IPage page, string selector, string key, PagePressOptions? options = null)
    {
        page.PressAsync(selector, key, options).GetAwaiter().GetResult();
    }

    public static void Route(this IPage page, string url, Action<IRoute> handler, PageRouteOptions? options = null)
    {
        page.RouteAsync(url, handler, options).GetAwaiter().GetResult();
    }

    public static void Route(this IPage page, Regex url, Action<IRoute> handler, PageRouteOptions? options = null)
    {
        page.RouteAsync(url, handler, options).GetAwaiter().GetResult();
    }

    public static void Route(this IPage page, Func<string, bool> url, Action<IRoute> handler, PageRouteOptions? options = null)
    {
        page.RouteAsync(url, handler, options).GetAwaiter().GetResult();
    }

    public static IConsoleMessage RunAndWaitForConsoleMessage(this IPage page, Func<Task> action, PageRunAndWaitForConsoleMessageOptions? options = null)
    {
        return page.RunAndWaitForConsoleMessageAsync(action, options).GetAwaiter().GetResult();
    }

    public static IDownload RunAndWaitForDownload(this IPage page, Func<Task> action, PageRunAndWaitForDownloadOptions? options = null)
    {
        return page.RunAndWaitForDownloadAsync(action, options).GetAwaiter().GetResult();
    }

    public static IFileChooser RunAndWaitForFileChooser(this IPage page, Func<Task> action, PageRunAndWaitForFileChooserOptions? options = null)
    {
        return page.RunAndWaitForFileChooserAsync(action, options).GetAwaiter().GetResult();
    }

    public static IResponse? RunAndWaitForNavigation(this IPage page, Func<Task> action, PageRunAndWaitForNavigationOptions? options = null)
    {
        return page.RunAndWaitForNavigationAsync(action, options).GetAwaiter().GetResult();
    }

    public static IPage RunAndWaitForPopup(this IPage page, Func<Task> action, PageRunAndWaitForPopupOptions? options = null)
    {
        return page.RunAndWaitForPopupAsync(action, options).GetAwaiter().GetResult();
    }

    public static IRequest RunAndWaitForRequest(this IPage page, Func<Task> action, string urlOrPredicate, PageRunAndWaitForRequestOptions? options = null)
    {
        return page.RunAndWaitForRequestAsync(action, urlOrPredicate, options).GetAwaiter().GetResult();
    }

    public static IRequest RunAndWaitForRequest(this IPage page, Func<Task> action, Regex urlOrPredicate, PageRunAndWaitForRequestOptions? options = null)
    {
        return page.RunAndWaitForRequestAsync(action, urlOrPredicate, options).GetAwaiter().GetResult();
    }

    public static IRequest RunAndWaitForRequest(this IPage page, Func<Task> action, Func<IRequest, bool> urlOrPredicate, PageRunAndWaitForRequestOptions? options = null)
    {
        return page.RunAndWaitForRequestAsync(action, urlOrPredicate, options).GetAwaiter().GetResult();
    }

    public static IRequest RunAndWaitForRequestFinished(this IPage page, Func<Task> action, PageRunAndWaitForRequestFinishedOptions? options = null)
    {
        return page.RunAndWaitForRequestFinishedAsync(action, options).GetAwaiter().GetResult();
    }

    public static IResponse RunAndWaitForResponse(this IPage page, Func<Task> action, string urlOrPredicate, PageRunAndWaitForResponseOptions? options = null)
    {
        return page.RunAndWaitForResponseAsync(action, urlOrPredicate, options).GetAwaiter().GetResult();
    }

    public static IResponse RunAndWaitForResponse(this IPage page, Func<Task> action, Regex urlOrPredicate, PageRunAndWaitForResponseOptions? options = null)
    {
        return page.RunAndWaitForResponseAsync(action, urlOrPredicate, options).GetAwaiter().GetResult();
    }

    public static IResponse RunAndWaitForResponse(this IPage page, Func<Task> action, Func<IResponse, bool> urlOrPredicate, PageRunAndWaitForResponseOptions? options = null)
    {
        return page.RunAndWaitForResponseAsync(action, urlOrPredicate, options).GetAwaiter().GetResult();
    }

    public static IWebSocket RunAndWaitForWebSocket(this IPage page, Func<Task> action, PageRunAndWaitForWebSocketOptions? options = null)
    {
        return page.RunAndWaitForWebSocketAsync(action, options).GetAwaiter().GetResult();
    }

    public static void RunAndWaitForWorker(this IPage page, Func<Task> action, PageRunAndWaitForWorkerOptions? options = null)
    {
        page.RunAndWaitForWorkerAsync(action, options).GetAwaiter().GetResult();
    }

    public static IReadOnlyList<string> SelectOption(this IPage page, string selector, string values, PageSelectOptionOptions? options = null)
    {
        return page.SelectOptionAsync(selector, values, options).GetAwaiter().GetResult();
    }

    public static IReadOnlyList<string> SelectOption(this IPage page, string selector, IElementHandle values, PageSelectOptionOptions? options = null)
    {
        return page.SelectOptionAsync(selector, values, options).GetAwaiter().GetResult();
    }

    public static IReadOnlyList<string> SelectOption(this IPage page, string selector, IEnumerable<string> values, PageSelectOptionOptions? options = null)
    {
        return page.SelectOptionAsync(selector, values, options).GetAwaiter().GetResult();
    }

    public static IReadOnlyList<string> SelectOption(this IPage page, string selector, SelectOptionValue values, PageSelectOptionOptions? options = null)
    {
        return page.SelectOptionAsync(selector, values, options).GetAwaiter().GetResult();
    }

    public static IReadOnlyList<string> SelectOption(this IPage page, string selector, IEnumerable<IElementHandle> values, PageSelectOptionOptions? options = null)
    {
        return page.SelectOptionAsync(selector, values, options).GetAwaiter().GetResult();
    }

    public static IReadOnlyList<string> SelectOption(this IPage page, string selector, IEnumerable<SelectOptionValue> values, PageSelectOptionOptions? options = null)
    {
        return page.SelectOptionAsync(selector, values, options).GetAwaiter().GetResult();
    }

    public static void SetChecked(this IPage page, string selector, bool checkedState, PageSetCheckedOptions? options = null)
    {
        page.SetCheckedAsync(selector, checkedState, options).GetAwaiter().GetResult();
    }
}
