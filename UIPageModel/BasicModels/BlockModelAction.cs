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

public abstract partial class BlockModel<TPageModel>
    where TPageModel : PageModel
{
    public TPageModel UpToPage()
    {
        return this.CurrentPageModel;
    }

    protected virtual IElementHandle FindElement(string selector, string exceptionMessage = "Element not found")
    {
        this.CurrentPageModel.Wait();
        this.Before();
        this.BeforeFindElement();

        var element = this.CurrentTag.QuerySelectorAsync(selector).GetAwaiter().GetResult();
        if (element is null) throw new ApplicationException(exceptionMessage);
        else return element;
    }

    protected virtual IElementHandle? FindElementOrNull(string selector)
    {
        this.CurrentPageModel.Wait();
        this.Before();
        this.BeforeFindElement();

        var element = this.CurrentTag.QuerySelectorAsync(selector).GetAwaiter().GetResult();
        return element;
    }

    public virtual TBlockModel? FindBlockOrNull<TBlockModel>(string selector)
        where TBlockModel : BlockModel<PageModel>
    {
        var generic = typeof(TBlockModel);
        var genericArgs = new[] { typeof(TPageModel) };
        var genericType = generic.MakeGenericType(genericArgs);

        var ctorArgs = new[] { this.GetType(), typeof(string) };
        var ctor = genericType.GetConstructor(ctorArgs);
        if (ctor is null) throw new ApplicationException("Block Model not found");

        var block = ctor.Invoke(new[] { this, (object)selector });

        return (TBlockModel?)block;
    }

    protected virtual IReadOnlyList<IElementHandle> FindElements(string selector)
    {
        this.CurrentPageModel.Wait();
        this.Before();
        this.BeforeFindElements();

        var elements = this.CurrentTag.QuerySelectorAllAsync(selector).GetAwaiter().GetResult();
        return elements;
    }

    public virtual IReadOnlyCollection<TBlockModel> FindBlocks<TBlockModel>(string selector)
        where TBlockModel : BlockModel<PageModel>
    {
        var elements = this.CurrentTag.QuerySelectorAllAsync(selector).GetAwaiter().GetResult();
        var blocks = new List<TBlockModel>();

        foreach (var element in elements)
        {
            var generic = typeof(TBlockModel);
            var genericArgs = new[] { typeof(TPageModel) };
            var genericType = generic.MakeGenericType(genericArgs);

            var ctorArgs = new[] { this.GetType(), typeof(IElementHandle) };
            var ctor = genericType.GetConstructor(ctorArgs);
            if (ctor is null) throw new ApplicationException("Block Model not found");

            var block = ctor.Invoke(new[] { this, (object)element });

            blocks.Add((TBlockModel)block);
        }

        return blocks;
    }

    protected virtual void Click(string? selector = null, ElementHandleClickOptions? options = null)
    {
        this.CurrentPageModel.Wait();
        this.Before();
        this.BeforeClick();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.ClickAsync(options).GetAwaiter().GetResult();
        }
        else
        {
            this.CurrentTag.ClickAsync(options).GetAwaiter().GetResult();
        }

        this.CurrentPageModel.Wait();
        this.After();
        this.AfterClick();
    }

    protected virtual TReturnPage Click<TReturnPage>(string? selector = null, ElementHandleClickOptions? options = null)
        where TReturnPage : PageModel
    {
        this.Click(selector, options);

        var ctor = typeof(TReturnPage).GetConstructor(new[] { typeof(IPage) });
        if (ctor is null) throw new ApplicationException("Page Model not found");

        var returnPage = ctor.Invoke(new[] { this.CurrentPageModel.SourcePage });
        return (TReturnPage)returnPage;
    }

    protected virtual void DbClick(string? selector = null, ElementHandleDblClickOptions? options = null)
    {
        this.CurrentPageModel.Wait();
        this.Before();
        this.BeforeDbClick();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.DblClickAsync(options).GetAwaiter().GetResult();
        }
        else
        {
            this.CurrentTag.DblClickAsync(options).GetAwaiter().GetResult();
        }

        this.CurrentPageModel.Wait();
        this.After();
        this.AfterDbClick();
    }

    protected virtual void Hower(string? selector = null, ElementHandleHoverOptions? options = null)
    {
        this.CurrentPageModel.Wait();
        this.Before();
        this.BeforeHower();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.HoverAsync(options).GetAwaiter().GetResult();
        }
        else
        {
            this.CurrentTag.HoverAsync(options).GetAwaiter().GetResult();
        }

        this.CurrentPageModel.Wait();
        this.After();
        this.AfterHower();
    }

    protected virtual void Type(string? selector = null, string value = "", ElementHandleTypeOptions? options = null)
    {
        this.CurrentPageModel.Wait();
        this.Before();
        this.BeforeType();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.TypeAsync(value, options).GetAwaiter().GetResult();
        }
        else
        {
            this.CurrentTag.TypeAsync(value, options).GetAwaiter().GetResult();
        }

        this.CurrentPageModel.Wait();
        this.After();
        this.AfterType();
    }

    protected virtual void Fill(string? selector = null, string value = "", ElementHandleFillOptions? options = null)
    {
        this.CurrentPageModel.Wait();
        this.Before();
        this.BeforeFill();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.FillAsync(value, options).GetAwaiter().GetResult();
        }
        else
        {
            this.CurrentTag.FillAsync(value, options).GetAwaiter().GetResult();
        }

        this.CurrentPageModel.Wait();
        this.After();
        this.AfterFill();
    }

    protected virtual void Check(string? selector = null, ElementHandleCheckOptions? options = null)
    {
        this.CurrentPageModel.Wait();
        this.Before();
        this.BeforeCheck();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.CheckAsync(options).GetAwaiter().GetResult();
        }
        else
        {
            this.CurrentTag.CheckAsync(options).GetAwaiter().GetResult();
        }

        this.CurrentPageModel.Wait();
        this.After();
        this.AfterCheck();
    }

    protected virtual void Uncheck(string? selector = null, ElementHandleUncheckOptions? options = null)
    {
        this.CurrentPageModel.Wait();
        this.Before();
        this.BeforeUncheck();

        if (selector is not null)
        {
            var element = this.FindElement(selector);
            element.UncheckAsync(options).GetAwaiter().GetResult();
        }
        else
        {
            this.CurrentTag.UncheckAsync(options).GetAwaiter().GetResult();
        }

        this.CurrentPageModel.Wait();
        this.After();
        this.AfterUncheck();
    }
}
