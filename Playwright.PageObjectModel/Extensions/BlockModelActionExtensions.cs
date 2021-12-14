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

public static class BlockModelActionExtensions
{
    public static TBlockModel Click<TBlockModel>(
        this TBlockModel blockModel, 
        string? selector = null, 
        ElementHandleClickOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.Click(options);
        return blockModel;
    }

    public static TBlockModel DbClick<TBlockModel>(
        this TBlockModel blockModel, 
        string? selector = null, 
        ElementHandleDblClickOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.DblClick(options);
        return blockModel;
    }

    public static TBlockModel Hover<TBlockModel>(
        this TBlockModel blockModel, 
        string? selector = null, 
        ElementHandleHoverOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.Hover(options);
        return blockModel;
    }

    public static TBlockModel ClearInput<TBlockModel>(this TBlockModel blockModel, string? selector = null, ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.Evaluate("(element) => element.value =''", element);
        return blockModel;
    }

    public static TBlockModel Type<TBlockModel>(
        this TBlockModel blockModel, 
        string? selector = null, 
        string value = "", 
        ElementHandleTypeOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.Type(value, options);
        return blockModel;
    }

    public static TBlockModel Fill<TBlockModel>(
        this TBlockModel blockModel, 
        string? selector = null, 
        string value = "", 
        ElementHandleFillOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.Fill(value, options);
        return blockModel;
    }

    public static TBlockModel Check<TBlockModel>(
        this TBlockModel blockModel, 
        string? selector = null, 
        ElementHandleCheckOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.Check(options);
        return blockModel;
    }

    public static TBlockModel Uncheck<TBlockModel>(
        this TBlockModel blockModel, 
        string? selector = null, 
        ElementHandleUncheckOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.Uncheck(options);
        return blockModel;
    }

    public static TBlockModel Focus<TBlockModel>(
        this TBlockModel blockModel, 
        string? selector = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.Focus();
        return blockModel;
    }

    public static TBlockModel Tap<TBlockModel>(
        this TBlockModel blockModel, 
        string? selector = null, 
        ElementHandleTapOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.Tap(options);
        return blockModel;
    }

    public static TBlockModel Press<TBlockModel>(
        this TBlockModel blockModel, 
        string key, 
        string? selector = null, 
        ElementHandlePressOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.Press(key, options);
        return blockModel;
    }

    public static TBlockModel SelectText<TBlockModel>(
        this TBlockModel blockModel, 
        string? selector = null, 
        ElementHandleSelectTextOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.SelectText(options);
        return blockModel;
    }

    public static TBlockModel SetChecked<TBlockModel>(
        this TBlockModel blockModel, 
        bool checkedState, 
        string? selector = null, 
        ElementHandleSetCheckedOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.SetChecked(checkedState, options);
        return blockModel;
    }

    public static TBlockModel SetInputFiles<TBlockModel>(
        this TBlockModel blockModel, 
        string files, 
        string? selector = null, 
        ElementHandleSetInputFilesOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.SetInputFiles(files, options);
        return blockModel;
    }

    public static TBlockModel SetInputFiles<TBlockModel>(
        this TBlockModel blockModel, 
        FilePayload files, 
        string? selector = null, 
        ElementHandleSetInputFilesOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.SetInputFiles(files, options);
        return blockModel;
    }

    public static TBlockModel SetInputFiles<TBlockModel>(
        this TBlockModel blockModel, 
        IEnumerable<string> files, 
        string? selector = null, 
        ElementHandleSetInputFilesOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.SetInputFiles(files, options);
        return blockModel;
    }

    public static TBlockModel SetInputFiles<TBlockModel>(
        this TBlockModel blockModel, 
        IEnumerable<FilePayload> files, 
        string? selector = null, 
        ElementHandleSetInputFilesOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.SetInputFiles(files, options);
        return blockModel;
    }

    public static TBlockModel SelectOption<TBlockModel>(
        this TBlockModel blockModel, 
        string values, 
        string? selector = null, 
        ElementHandleSelectOptionOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.SelectOption(values, options);
        return blockModel;
    }

    public static TBlockModel SelectOption<TBlockModel>(
        this TBlockModel blockModel, 
        IElementHandle values, 
        string? selector = null, 
        ElementHandleSelectOptionOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.SelectOption(values, options);
        return blockModel;
    }

    public static TBlockModel SelectOption<TBlockModel>(
        this TBlockModel blockModel, 
        IEnumerable<string> values, 
        string? selector = null, 
        ElementHandleSelectOptionOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.SelectOption(values, options);
        return blockModel;
    }

    public static TBlockModel SelectOption<TBlockModel>(
        this TBlockModel blockModel, 
        SelectOptionValue values, 
        string? selector = null, 
        ElementHandleSelectOptionOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.SelectOption(values, options);
        return blockModel;
    }

    public static TBlockModel SelectOption<TBlockModel>(
        this TBlockModel blockModel, 
        IEnumerable<IElementHandle> values, 
        string? selector = null, 
        ElementHandleSelectOptionOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.SelectOption(values, options);
        return blockModel;
    }

    public static TBlockModel SelectOption<TBlockModel>(
        this TBlockModel blockModel, 
        IEnumerable<SelectOptionValue> values, 
        string? selector = null, 
        ElementHandleSelectOptionOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.SelectOption(values, options);
        return blockModel;
    }

    public static TBlockModel ScrollIntoViewIfNeeded<TBlockModel>(
        this TBlockModel blockModel, 
        string? selector = null, 
        ElementHandleScrollIntoViewIfNeededOptions? options = null,
        ElementHandleWaitForSelectorOptions? waitOptions = null)
        where TBlockModel : IBlockModel, IWait
    {
        blockModel.Wait();

        if (selector is not null) blockModel.Block.WaitForSelector(selector, waitOptions);
        var element = selector is null ? blockModel.Block : blockModel.Block.QuerySelector(selector)!;

        element.ScrollIntoViewIfNeeded(options);
        return blockModel;
    }
}
