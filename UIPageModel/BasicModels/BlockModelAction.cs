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
using UITesting.Page.Sync;
using System.Text.Json;

namespace UIPageModel;

public partial class BlockModel<TPageModel>
    where TPageModel : PageModel
{
    public TPageModel UpToPage()
    {
        return this.PageModel;
    }

    protected virtual IElementHandle FindElement(string selector, string exceptionMessage = "Element not found")
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeFind();

        var element = this.HtmlBlock.QuerySelector(selector);
        if (element is null) throw new ApplicationException(exceptionMessage);
        else return element;
    }

    protected virtual IElementHandle? FindElementOrNull(string selector)
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeFind();

        var element = this.HtmlBlock.QuerySelector(selector);
        return element;
    }

    protected virtual IReadOnlyList<IElementHandle> FindElements(string selector)
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeFind();

        var elements = this.HtmlBlock.QuerySelectorAll(selector);
        return elements;
    }

    protected virtual TBlockModel FindBlock<TBlockModel>(string selector)
        where TBlockModel : class
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeFind();

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
        this.PageModel.Wait();
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

    protected virtual IReadOnlyCollection<TBlockModel> FindBlocks<TBlockModel>(string selector)
        where TBlockModel : class
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeFind();

        var elements = this.HtmlBlock.QuerySelectorAll(selector);
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
        this.PageModel.Wait();
        this.Before();
        this.BeforeClick();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.Click(options);
        }
        else
        {
            this.HtmlBlock.Click(options);
        }

        this.PageModel.Wait();
        this.After();
        this.AfterClick();
    }

    protected virtual TReturnPage Click<TReturnPage>(string? selector = null, ElementHandleClickOptions? options = null)
        where TReturnPage : PageModel
    {
        this.Click(selector, options);

        var ctor = typeof(TReturnPage).GetConstructor(new[] { typeof(IPage) });
        if (ctor is null) throw new ApplicationException("Page Model not found");

        var returnPage = ctor.Invoke(new[] { this.PageModel.Page });
        return (TReturnPage)returnPage;
    }

    protected virtual void DbClick(string? selector = null, ElementHandleDblClickOptions? options = null)
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeDbClick();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.DblClick(options);
        }
        else
        {
            this.HtmlBlock.DblClick(options);
        }

        this.PageModel.Wait();
        this.After();
        this.AfterDbClick();
    }

    protected virtual void Hover(string? selector = null, ElementHandleHoverOptions? options = null)
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeHover();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.Hover(options);
        }
        else
        {
            this.HtmlBlock.Hover(options);
        }

        this.PageModel.Wait();
        this.After();
        this.AfterHover();
    }

    protected virtual void Type(string? selector = null, string value = "", ElementHandleTypeOptions? options = null)
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeType();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.Type(value, options);
        }
        else
        {
            this.HtmlBlock.Type(value, options);
        }

        this.PageModel.Wait();
        this.After();
        this.AfterType();
    }

    protected virtual void Fill(string? selector = null, string value = "", ElementHandleFillOptions? options = null)
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeFill();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.Fill(value, options);
        }
        else
        {
            this.HtmlBlock.Fill(value, options);
        }

        this.PageModel.Wait();
        this.After();
        this.AfterFill();
    }

    protected virtual void Check(string? selector = null, ElementHandleCheckOptions? options = null)
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeCheck();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.Check(options);
        }
        else
        {
            this.HtmlBlock.Check(options);
        }

        this.PageModel.Wait();
        this.After();
        this.AfterCheck();
    }

    protected virtual void Uncheck(string? selector = null, ElementHandleUncheckOptions? options = null)
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeUncheck();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.Uncheck(options);
        }
        else
        {
            this.HtmlBlock.Uncheck(options);
        }

        this.PageModel.Wait();
        this.After();
        this.AfterUncheck();
    }

    protected virtual void SetInputFiles(string files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeSetInputFile();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.SetInputFiles(files, options);
        }
        else
        {
            this.HtmlBlock.SetInputFiles(files, options);
        }

        this.PageModel.Wait();
        this.After();
        this.AfterSetInputFile();
    }

    protected virtual void SetInputFiles(FilePayload files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeSetInputFile();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.SetInputFiles(files, options);
        }
        else
        {
            this.HtmlBlock.SetInputFiles(files, options);
        }

        this.PageModel.Wait();
        this.After();
        this.AfterSetInputFile();
    }

    protected virtual void SetInputFiles(IEnumerable<string> files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeSetInputFile();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.SetInputFiles(files, options);
        }
        else
        {
            this.HtmlBlock.SetInputFiles(files, options);
        }

        this.PageModel.Wait();
        this.After();
        this.AfterSetInputFile();
    }

    protected virtual void SetInputFiles(IEnumerable<FilePayload> files, string? selector = null, ElementHandleSetInputFilesOptions? options = null)
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeSetInputFile();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.SetInputFiles(files, options);
        }
        else
        {
            this.HtmlBlock.SetInputFiles(files, options);
        }

        this.PageModel.Wait();
        this.After();
        this.AfterSetInputFile();
    }

    protected virtual void Screenshot(string? selector = null, ElementHandleScreenshotOptions? options = null)
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeScreenshot();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.Screenshot(options);
        }
        else
        {
            this.HtmlBlock.Screenshot(options);
        }

        this.PageModel.Wait();
        this.After();
        this.AfterScreenshot();
    }

    protected virtual string TextContent(string? selector = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.TextContent() ?? "";
        }
        else
        {
            return this.HtmlBlock.TextContent() ?? "";
        }
    }

    protected virtual string InnerText(string? selector = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.InnerText();
        }
        else
        {
            return this.HtmlBlock.InnerText();
        }
    }

    protected virtual string InnerHTML(string? selector = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.InnerHTML();
        }
        else
        {
            return this.HtmlBlock.InnerHTML();
        }
    }

    protected virtual bool IsChecked(string? selector = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.IsChecked();
        }
        else
        {
            return this.HtmlBlock.IsChecked();
        }
    }

    protected virtual bool IsDisabled(string? selector = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.IsDisabled();
        }
        else
        {
            return this.HtmlBlock.IsDisabled();
        }
    }

    protected virtual bool IsEditable(string? selector = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.IsEditable();
        }
        else
        {
            return this.HtmlBlock.IsEditable();
        }
    }

    protected virtual bool IsEnabled(string? selector = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.IsEnabled();
        }
        else
        {
            return this.HtmlBlock.IsEnabled();
        }
    }

    protected virtual bool IsHidden(string? selector = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.IsHidden();
        }
        else
        {
            return this.HtmlBlock.IsHidden();
        }
    }

    protected virtual bool IsVisible(string? selector = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.IsVisible();
        }
        else
        {
            return this.HtmlBlock.IsVisible();
        }
    }

    protected virtual ElementHandleBoundingBoxResult? BoundingBox(string? selector = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.BoundingBox();
        }
        else
        {
            return this.HtmlBlock.BoundingBox();
        }
    }

    protected virtual IFrame? ContentFrame(string? selector = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.ContentFrame();
        }
        else
        {
            return this.HtmlBlock.ContentFrame();
        }
    }

    protected virtual void Focus(string? selector = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.Focus();
        }
        else
        {
            this.HtmlBlock.Focus();
        }
    }

    protected virtual string InputValue(string? selector = null, ElementHandleInputValueOptions? options = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.InputValue();
        }
        else
        {
            return this.HtmlBlock.InputValue();
        }
    }

    protected virtual IReadOnlyList<string> SelectOption(string values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.SelectOption(values);
        }
        else
        {
            return this.HtmlBlock.SelectOption(values);
        }
    }

    protected virtual IReadOnlyList<string> SelectOption(IElementHandle values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.SelectOption(values);
        }
        else
        {
            return this.HtmlBlock.SelectOption(values);
        }
    }

    protected virtual IReadOnlyList<string> SelectOption(IEnumerable<string> values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.SelectOption(values);
        }
        else
        {
            return this.HtmlBlock.SelectOption(values);
        }
    }

    protected virtual IReadOnlyList<string> SelectOption(SelectOptionValue values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.SelectOption(values);
        }
        else
        {
            return this.HtmlBlock.SelectOption(values);
        }
    }

    protected virtual IReadOnlyList<string> SelectOption(IEnumerable<IElementHandle> values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.SelectOption(values);
        }
        else
        {
            return this.HtmlBlock.SelectOption(values);
        }
    }

    protected virtual IReadOnlyList<string> SelectOption(IEnumerable<SelectOptionValue> values, string? selector = null, ElementHandleSelectOptionOptions? options = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.SelectOption(values);
        }
        else
        {
            return this.HtmlBlock.SelectOption(values);
        }
    }

    protected virtual void DispatchEvent(string type, string? selector = null, object? eventInit = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.DispatchEvent(type);
        }
        else
        {
            this.HtmlBlock.DispatchEvent(type);
        }
    }

    protected virtual T EvalOnSelector<T>(string selector, string expression, object? arg = null)
    {
        this.PageModel.Wait();

        return this.HtmlBlock.EvalOnSelector<T>(selector, expression, arg);
    }

    protected virtual T EvalOnSelectorAll<T>(string selector, string expression, object? arg = null)
    {
        return this.HtmlBlock.EvalOnSelectorAll<T>(selector, expression, arg);
    }

    protected virtual JsonElement? EvalOnSelector(string selector, string expression, object? arg = null)
    {
        return this.HtmlBlock.EvalOnSelector(selector, expression, arg);
    }

    protected string? GetAttributeAsync(string name, string? selector = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.GetAttribute(name);
        }
        else
        {
            return this.HtmlBlock.GetAttribute(name);
        }
    }

    protected virtual void Tap(string? selector = null, ElementHandleTapOptions? options = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.Tap(options);
        }
        else
        {
            this.HtmlBlock.Tap(options);
        }
    }

    protected virtual IFrame? OwnerFrame(string? selector = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.OwnerFrame();
        }
        else
        {
            return this.HtmlBlock.OwnerFrame();
        }
    }

    protected virtual void Press(string key, string? selector = null, ElementHandlePressOptions? options = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.Press(key, options);
        }
        else
        {
            this.HtmlBlock.Press(key, options);
        }
    }

    protected virtual byte[] Screenshot(string? selector = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            return element.Screenshot();
        }
        else
        {
            return this.HtmlBlock.Screenshot();
        }
    }

    protected virtual void SelectText(string? selector = null, ElementHandleSelectTextOptions? options = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.SelectText(options);
        }
        else
        {
            this.HtmlBlock.SelectText(options);
        }
    }

    protected virtual void SetChecked(bool checkedState, string? selector = null, ElementHandleSetCheckedOptions? options = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.SetChecked(checkedState);
        }
        else
        {
            this.HtmlBlock.SetChecked(checkedState);
        }
    }

    protected virtual void WaitForElementState(ElementState state, string? selector = null, ElementHandleWaitForElementStateOptions? options = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.WaitForElementState(state);
        }
        else
        {
            this.HtmlBlock.WaitForElementState(state);
        }
    }

    protected virtual void ScrollIntoViewIfNeeded(string? selector = null, ElementHandleScrollIntoViewIfNeededOptions? options = null)
    {
        this.PageModel.Wait();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.ScrollIntoViewIfNeeded();
        }
        else
        {
            this.HtmlBlock.ScrollIntoViewIfNeeded();
        }
    }

    protected virtual IElementHandle? WaitForSelector(string selector, ElementHandleWaitForSelectorOptions? options = null)
    {
        return HtmlBlock.WaitForSelector(selector, options);
    }
}
