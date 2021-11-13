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
using System.Collections.Generic;
using Microsoft.Playwright;

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

        var element = this.HtmlBlock.QuerySelectorAsync(selector).GetAwaiter().GetResult();
        if (element is null) throw new ApplicationException(exceptionMessage);
        else return element;
    }

    protected virtual IElementHandle? FindElementOrNull(string selector)
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeFind();

        var element = this.HtmlBlock.QuerySelectorAsync(selector).GetAwaiter().GetResult();
        return element;
    }

    protected virtual IReadOnlyList<IElementHandle> FindElements(string selector)
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeFind();

        var elements = this.HtmlBlock.QuerySelectorAllAsync(selector).GetAwaiter().GetResult();
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

        var elements = this.HtmlBlock.QuerySelectorAllAsync(selector).GetAwaiter().GetResult();
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
            element.ClickAsync(options).GetAwaiter().GetResult();
        }
        else
        {
            this.HtmlBlock.ClickAsync(options).GetAwaiter().GetResult();
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
            element.DblClickAsync(options).GetAwaiter().GetResult();
        }
        else
        {
            this.HtmlBlock.DblClickAsync(options).GetAwaiter().GetResult();
        }

        this.PageModel.Wait();
        this.After();
        this.AfterDbClick();
    }

    protected virtual void Hower(string? selector = null, ElementHandleHoverOptions? options = null)
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeHower();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.HoverAsync(options).GetAwaiter().GetResult();
        }
        else
        {
            this.HtmlBlock.HoverAsync(options).GetAwaiter().GetResult();
        }

        this.PageModel.Wait();
        this.After();
        this.AfterHower();
    }

    protected virtual void Type(string? selector = null, string value = "", ElementHandleTypeOptions? options = null)
    {
        this.PageModel.Wait();
        this.Before();
        this.BeforeType();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.TypeAsync(value, options).GetAwaiter().GetResult();
        }
        else
        {
            this.HtmlBlock.TypeAsync(value, options).GetAwaiter().GetResult();
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
            element.FillAsync(value, options).GetAwaiter().GetResult();
        }
        else
        {
            this.HtmlBlock.FillAsync(value, options).GetAwaiter().GetResult();
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
            element.CheckAsync(options).GetAwaiter().GetResult();
        }
        else
        {
            this.HtmlBlock.CheckAsync(options).GetAwaiter().GetResult();
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
            element.UncheckAsync(options).GetAwaiter().GetResult();
        }
        else
        {
            this.HtmlBlock.UncheckAsync(options).GetAwaiter().GetResult();
        }

        this.PageModel.Wait();
        this.After();
        this.AfterUncheck();
    }

    protected virtual string TextContent()
    {
        return HtmlBlock.TextContentAsync().GetAwaiter().GetResult() ?? "";
    }

    protected virtual string InnerText()
    {
        return HtmlBlock.InnerTextAsync().GetAwaiter().GetResult();
    }

    protected virtual string InnerHTML()
    {
        return HtmlBlock.InnerHTMLAsync().GetAwaiter().GetResult();
    }
}
