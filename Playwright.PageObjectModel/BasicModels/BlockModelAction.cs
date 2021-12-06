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
using System.Text.Json;

namespace Playwright.PageObjectModel;

public partial class BlockModel<TPageModel>
    where TPageModel : PageModel
{
    public virtual void WaitForLoadPage()
    {
        this.PageModel.WaitForLoadPage();
    }

    public TPageModel UpToPage()
    {
        return this.PageModel;
    }

    protected virtual IElementHandle FindElement(string selector)
    {
        this.WaitForLoadPage();
        var element = this.Block.QuerySelector(selector);
        if (element is null) throw new ApplicationException($"Element not found. Selector: {selector}");
        else return element;
    }

    protected virtual IElementHandle? FindElementOrNull(string selector)
    {
        this.WaitForLoadPage();
        var element = this.Block.QuerySelector(selector);
        return element;
    }

    protected virtual IReadOnlyList<IElementHandle> FindElements(string selector)
    {
        this.WaitForLoadPage();
        var elements = this.Block.QuerySelectorAll(selector);
        return elements;
    }

    protected virtual TBlockModel FindBlock<TBlockModel>(string selector)
        where TBlockModel : class
    {
        this.WaitForLoadPage();

        var blockType = typeof(TBlockModel);
        var ctorArgs = new[] { typeof(BlockModel<TPageModel>), typeof(string) };

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

        var elements = this.Block.QuerySelectorAll(selector);
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

    protected virtual void Click(string? selector = null, ElementHandleClickOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.Click(options);
        this.WaitForLoadPage();
    }

    protected virtual TReturnPage Click<TReturnPage>(string? selector = null, ElementHandleClickOptions? options = null)
        where TReturnPage : PageModel
    {
        this.Click(selector, options);
        this.WaitForLoadPage();

        var ctor = typeof(TReturnPage).GetConstructor(new[] { typeof(IPage) });
        if (ctor is null) throw new ApplicationException("Page Model not found");
        var returnPage = ctor.Invoke(new[] { this.PageModel.Page });

        return (TReturnPage)returnPage;
    }

    protected virtual void DbClick(string? selector = null, ElementHandleDblClickOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.DblClick(options);
        this.WaitForLoadPage();
    }

    protected virtual void Hover(string? selector = null, ElementHandleHoverOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.Hover(options);
        this.WaitForLoadPage();
    }

    protected virtual void ClearInput(string? selector = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.Evaluate("(element) => element.value =''", element);
        this.WaitForLoadPage();
    }

    protected virtual void Type(string? selector = null, string value = "", ElementHandleTypeOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.Type(value, options);
        this.WaitForLoadPage();
    }

    protected virtual void Fill(string? selector = null, string value = "", ElementHandleFillOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.Fill(value, options);
        this.WaitForLoadPage();
    }

    protected virtual void Check(string? selector = null, ElementHandleCheckOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.Check(options);
        this.WaitForLoadPage();
    }

    protected virtual void Uncheck(string? selector = null, ElementHandleUncheckOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.Uncheck(options);
        this.WaitForLoadPage();
    }

    protected virtual void Focus(string? selector = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.Focus();
        this.WaitForLoadPage();
    }

    protected virtual void Tap(string? selector = null, ElementHandleTapOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.Tap(options);
        this.WaitForLoadPage();
    }

    protected virtual void Press(string key, string? selector = null, ElementHandlePressOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.Press(key, options);
        this.WaitForLoadPage();
    }

    protected virtual void SelectText(string? selector = null, ElementHandleSelectTextOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.SelectText(options);
    }

    protected virtual void SetChecked(bool checkedState, string? selector = null, ElementHandleSetCheckedOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.SetChecked(checkedState);
        this.WaitForLoadPage();
    }

    protected virtual void SetInputFiles(string files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.SetInputFiles(files, options);
        this.WaitForLoadPage();
    }

    protected virtual void SetInputFiles(FilePayload files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.SetInputFiles(files, options);
        this.WaitForLoadPage();
    }

    protected virtual void SetInputFiles(IEnumerable<string> files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.SetInputFiles(files, options);
        this.WaitForLoadPage();
    }

    protected virtual void SetInputFiles(IEnumerable<FilePayload> files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.SetInputFiles(files, options);
        this.WaitForLoadPage();
    }

    protected virtual IReadOnlyList<string> SelectOption(string values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        var result = element.SelectOption(values, options);
        this.WaitForLoadPage();
        return result;
    }

    protected virtual IReadOnlyList<string> SelectOption(IElementHandle values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        var result = element.SelectOption(values, options);
        this.WaitForLoadPage();
        return result;
    }

    protected virtual IReadOnlyList<string> SelectOption(IEnumerable<string> values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        var result = element.SelectOption(values, options);
        this.WaitForLoadPage();
        return result;
    }

    protected virtual IReadOnlyList<string> SelectOption(SelectOptionValue values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        var result = element.SelectOption(values, options);
        this.WaitForLoadPage();
        return result;
    }

    protected virtual IReadOnlyList<string> SelectOption(IEnumerable<IElementHandle> values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        var result = element.SelectOption(values, options);
        this.WaitForLoadPage();
        return result;
    }

    protected virtual IReadOnlyList<string> SelectOption(IEnumerable<SelectOptionValue> values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        var result = element.SelectOption(values, options);
        this.WaitForLoadPage();
        return result;
    }

    protected virtual void ScrollIntoViewIfNeeded(string? selector = null, ElementHandleScrollIntoViewIfNeededOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.ScrollIntoViewIfNeeded(options);
        this.WaitForLoadPage();
    }

    protected virtual void Screenshot(string? selector = null, ElementHandleScreenshotOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.Screenshot(options);
    }

    protected virtual string TextContent(string? selector = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        return element.TextContent() ?? "";
    }

    protected virtual string InnerText(string? selector = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        return element.InnerText();
    }

    protected virtual string InnerHTML(string? selector = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        return element.InnerHTML();
    }

    protected virtual string InputValue(string? selector = null, ElementHandleInputValueOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        return element.InputValue(options);
    }

    protected virtual bool IsChecked(string? selector = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        return element.IsChecked();
    }

    protected virtual bool IsDisabled(string? selector = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        return element.IsDisabled();
    }

    protected virtual bool IsEditable(string? selector = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        return element.IsEditable();
    }

    protected virtual bool IsEnabled(string? selector = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        return element.IsEnabled();
    }

    protected virtual bool IsHidden(string? selector = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        return element.IsHidden();
    }

    protected virtual bool IsVisible(string? selector = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        return element.IsVisible();
    }

    protected virtual ElementHandleBoundingBoxResult? BoundingBox(string? selector = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        return element.BoundingBox();
    }

    protected virtual IFrame? ContentFrame(string? selector = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        return element.ContentFrame();
    }

    protected virtual void DispatchEvent(string type, string? selector = null, object? eventInit = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.DispatchEvent(type);
    }

    protected virtual T EvalOnSelector<T>(string selector, string expression, object? arg = null)
    {
        this.WaitForLoadPage();
        return this.Block.EvalOnSelector<T>(selector, expression, arg);
    }

    protected virtual T EvalOnSelectorAll<T>(string selector, string expression, object? arg = null)
    {
        this.WaitForLoadPage();
        return this.Block.EvalOnSelectorAll<T>(selector, expression, arg);
    }

    protected virtual JsonElement? EvalOnSelector(string selector, string expression, object? arg = null)
    {
        this.WaitForLoadPage();
        return this.Block.EvalOnSelector(selector, expression, arg);
    }

    protected string? GetAttributeValue(string name, string? selector = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        return element.GetAttribute(name);
    }

    protected virtual IFrame? OwnerFrame(string? selector = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        return element.OwnerFrame();
    }

    protected virtual void WaitForElementState(ElementState state, string? selector = null, ElementHandleWaitForElementStateOptions? options = null)
    {
        this.WaitForLoadPage();
        var element = selector is null ? this.Block : this.FindElement(selector);
        element.WaitForElementState(state);
    }

    protected virtual IElementHandle? WaitForSelector(string selector, ElementHandleWaitForSelectorOptions? options = null)
    {
        return Block.WaitForSelector(selector, options);
    }
}
