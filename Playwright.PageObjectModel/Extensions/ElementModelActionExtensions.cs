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

public static class ElementModelActionExtensions
{
    public static TElementModel Click<TElementModel>(
        this TElementModel elementModel, 
        string? selector = null, 
        ElementHandleClickOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.Click(options);

        return elementModel;
    }

    public static TElementModel DbClick<TElementModel>(
        this TElementModel elementModel, 
        string? selector = null, 
        ElementHandleDblClickOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.DblClick(options);

        return elementModel;
    }

    public static TElementModel Hover<TElementModel>(
        this TElementModel elementModel, 
        string? selector = null, 
        ElementHandleHoverOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.Hover(options);

        return elementModel;
    }

    public static TElementModel ClearInput<TElementModel>(this TElementModel elementModel, string? selector = null, ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.Evaluate("(element) => element.value =''", element);

        return elementModel;
    }

    public static TElementModel Type<TElementModel>(
        this TElementModel elementModel, 
        string? selector = null, 
        string value = "", 
        ElementHandleTypeOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.Type(value, options);

        return elementModel;
    }

    public static TElementModel Fill<TElementModel>(
        this TElementModel elementModel, 
        string? selector = null, 
        string value = "", 
        ElementHandleFillOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.Fill(value, options);

        return elementModel;
    }

    public static TElementModel Check<TElementModel>(
        this TElementModel elementModel, 
        string? selector = null, 
        ElementHandleCheckOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.Check(options);

        return elementModel;
    }

    public static TElementModel Uncheck<TElementModel>(
        this TElementModel elementModel, 
        string? selector = null, 
        ElementHandleUncheckOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.Uncheck(options);

        return elementModel;
    }

    public static TElementModel Focus<TElementModel>(
        this TElementModel elementModel, 
        string? selector = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.Focus();

        return elementModel;
    }

    public static TElementModel Tap<TElementModel>(
        this TElementModel elementModel, 
        string? selector = null, 
        ElementHandleTapOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.Tap(options);

        return elementModel;
    }

    public static TElementModel Press<TElementModel>(
        this TElementModel elementModel, 
        string key, 
        string? selector = null, 
        ElementHandlePressOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.Press(key, options);

        return elementModel;
    }

    public static TElementModel SelectText<TElementModel>(
        this TElementModel elementModel, 
        string? selector = null, 
        ElementHandleSelectTextOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.SelectText(options);

        return elementModel;
    }

    public static TElementModel SetChecked<TElementModel>(
        this TElementModel elementModel, 
        bool checkedState, 
        string? selector = null, 
        ElementHandleSetCheckedOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.SetChecked(checkedState, options);

        return elementModel;
    }

    public static TElementModel SetInputFiles<TElementModel>(
        this TElementModel elementModel, 
        string files, 
        string? selector = null, 
        ElementHandleSetInputFilesOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.SetInputFiles(files, options);

        return elementModel;
    }

    public static TElementModel SetInputFiles<TElementModel>(
        this TElementModel elementModel, 
        FilePayload files, 
        string? selector = null, 
        ElementHandleSetInputFilesOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.SetInputFiles(files, options);

        return elementModel;
    }

    public static TElementModel SetInputFiles<TElementModel>(
        this TElementModel elementModel, 
        IEnumerable<string> files, 
        string? selector = null, 
        ElementHandleSetInputFilesOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.SetInputFiles(files, options);

        return elementModel;
    }

    public static TElementModel SetInputFiles<TElementModel>(
        this TElementModel elementModel, 
        IEnumerable<FilePayload> files, 
        string? selector = null, 
        ElementHandleSetInputFilesOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.SetInputFiles(files, options);

        return elementModel;
    }

    public static TElementModel SelectOption<TElementModel>(
        this TElementModel elementModel, 
        string values, 
        string? selector = null, 
        ElementHandleSelectOptionOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.SelectOption(values, options);

        return elementModel;
    }

    public static TElementModel SelectOption<TElementModel>(
        this TElementModel elementModel, 
        IElementHandle values, 
        string? selector = null, 
        ElementHandleSelectOptionOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.SelectOption(values, options);

        return elementModel;
    }

    public static TElementModel SelectOption<TElementModel>(
        this TElementModel elementModel, 
        IEnumerable<string> values, 
        string? selector = null, 
        ElementHandleSelectOptionOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.SelectOption(values, options);

        return elementModel;
    }

    public static TElementModel SelectOption<TElementModel>(
        this TElementModel elementModel, 
        SelectOptionValue values, 
        string? selector = null, 
        ElementHandleSelectOptionOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.SelectOption(values, options);

        return elementModel;
    }

    public static TElementModel SelectOption<TElementModel>(
        this TElementModel elementModel, 
        IEnumerable<IElementHandle> values, 
        string? selector = null, 
        ElementHandleSelectOptionOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.SelectOption(values, options);

        return elementModel;
    }

    public static TElementModel SelectOption<TElementModel>(
        this TElementModel elementModel, 
        IEnumerable<SelectOptionValue> values, 
        string? selector = null, 
        ElementHandleSelectOptionOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.SelectOption(values, options);

        return elementModel;
    }

    public static TElementModel ScrollIntoViewIfNeeded<TElementModel>(
        this TElementModel elementModel, 
        string? selector = null, 
        ElementHandleScrollIntoViewIfNeededOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TElementModel : IElementModel
    {
        if (selector is not null) elementModel.Element.WaitForSelector(selector, waitOptions);
        var element = selector is null ? elementModel.Element : elementModel.Element.QuerySelector(selector)!;
        element.ScrollIntoViewIfNeeded(options);

        return elementModel;
    }

    public static TElementModel WaitPage<TElementModel>(this TElementModel elementModel, PageWaitForLoadStateOptions? options = null)
        where TElementModel : IElementModel, ITypedElementModel<PageModel>
    {
        elementModel.PageModel.WaitPage(options);
        return elementModel;
    }

    public static TElementModel WaitForLoad<TElementModel>(this TElementModel elementModel, PageWaitForLoadStateOptions? options = null)
        where TElementModel : IElementModel
    {
        elementModel.Page.WaitForLoadState(LoadState.Load, options);
        return elementModel;
    }

    public static TElementModel WaitForDOM<TElementModel>(this TElementModel elementModel, PageWaitForLoadStateOptions? options = null)
        where TElementModel : IElementModel
    {
        elementModel.Page.WaitForLoadState(LoadState.DOMContentLoaded, options);
        return elementModel;
    }

    public static TElementModel WaitForNetworkIdle<TElementModel>(this TElementModel elementModel, PageWaitForLoadStateOptions? options = null)
        where TElementModel : IElementModel
    {
        elementModel.Page.WaitForLoadState(LoadState.NetworkIdle, options);
        return elementModel;
    }
}
