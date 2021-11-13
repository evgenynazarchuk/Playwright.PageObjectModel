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
using System.Linq;

namespace UIPageModel;

public abstract partial class PageModel
{
    public virtual void Wait() { }

    public virtual IElementHandle FindElement(
        string selector,
        PageQuerySelectorOptions? options = null,
        string exceptionMessage = "Element not found")
    {
        var element = this.Page.QuerySelectorAsync(selector, options).GetAwaiter().GetResult();
        if (element is null) throw new ApplicationException(exceptionMessage);
        else return element;
    }

    public virtual IElementHandle? FindElementOrNull(string selector, PageQuerySelectorOptions? options = null)
    {
        var element = this.Page.QuerySelectorAsync(selector, options).GetAwaiter().GetResult();
        return element;
    }

    public virtual TBlockModel? FindBlockOrNull<TBlockModel>(string selector)
        where TBlockModel : BlockModel<PageModel>
    {
        var generic = typeof(TBlockModel);
        var genericArgs = new[] { this.GetType() };
        var genericType = generic.MakeGenericType(genericArgs);

        var ctorArgs = new[] { this.GetType(), typeof(string) };
        var ctor = genericType.GetConstructor(ctorArgs);
        if (ctor is null) throw new ApplicationException("Block Model not found");

        var block = ctor.Invoke(new[] { this, (object)selector });

        return (TBlockModel?)block;
    }

    public virtual IReadOnlyCollection<IElementHandle> FindElements(string selector)
    {
        var elements = this.Page.QuerySelectorAllAsync(selector).GetAwaiter().GetResult();
        return elements;
    }

    public virtual IReadOnlyCollection<TBlockModel> FindBlocks<TBlockModel>(string selector)
        where TBlockModel : BlockModel<PageModel>
    {
        var elements = this.Page.QuerySelectorAllAsync(selector).GetAwaiter().GetResult();
        var blocks = new List<TBlockModel>();

        foreach (var element in elements)
        {
            var generic = typeof(TBlockModel);
            var genericArgs = new[] { this.GetType() };
            var genericType = generic.MakeGenericType(genericArgs);

            var ctorArgs = new[] { this.GetType(), typeof(IElementHandle) };
            var ctor = genericType.GetConstructor(ctorArgs);
            if (ctor is null) throw new ApplicationException("Block Model not found");

            var block = ctor.Invoke(new[] { this, (object)element });

            blocks.Add((TBlockModel)block);
        }

        return blocks;
    }

    public virtual void Click(string selector, PageClickOptions? options = null)
    {
        this.Wait();

        this.Page.ClickAsync(selector, options).GetAwaiter().GetResult();

        this.Wait();
    }

    public virtual void Type(string selector, string value, PageTypeOptions? options = null)
    {
        this.Wait();

        this.Page.TypeAsync(selector, value, options).GetAwaiter().GetResult();

        this.Wait();
    }

    public virtual TPageModel ReloadPage<TPageModel>(PageReloadOptions? options = null)
        where TPageModel : PageModel
    {
        this.Wait();

        this.Page.ReloadAsync(options).GetAwaiter().GetResult();

        this.Wait();

        return (TPageModel)this;
    }

    public virtual PageModel ReloadPage(PageReloadOptions? options = null)
    {
        this.Wait();

        this.Page.ReloadAsync(options).GetAwaiter().GetResult();

        this.Wait();

        return this;
    }
}
