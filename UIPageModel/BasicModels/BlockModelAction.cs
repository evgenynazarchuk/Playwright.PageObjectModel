using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace UIPageModel
{
    public abstract partial class BlockModel<TPageModel>
        where TPageModel : PageModel
    {
        public TPageModel UpToPage()
        {
            return this.Page;
        }

        protected virtual IElementHandle FindElementElseThrow(string selector, string exceptionMessage = "Element not found")
        {
            this.Page.Wait();
            this.Before();
            this.BeforeFindElement();

            var element = this.CurrentBlock.QuerySelectorAsync(selector).GetAwaiter().GetResult();
            if (element is null) throw new ApplicationException(exceptionMessage);
            else return element;
        }

        protected virtual IElementHandle? FindElement(string selector)
        {
            this.Page.Wait();
            this.Before();
            this.BeforeFindElement();

            var element = this.CurrentBlock.QuerySelectorAsync(selector).GetAwaiter().GetResult();
            return element;
        }

        protected virtual IReadOnlyList<IElementHandle> FindElements(string selector)
        {
            this.Page.Wait();
            this.Before();
            this.BeforeFindElements();

            var elements = this.CurrentBlock.QuerySelectorAllAsync(selector).GetAwaiter().GetResult();
            return elements;
        }

        protected virtual void Click(string selector, ElementHandleClickOptions? options = null)
        {
            this.Page.Wait();
            this.Before();
            this.BeforeClick();

            var element = this.FindElementElseThrow(selector);
            element.ClickAsync(options).GetAwaiter().GetResult();

            this.Page.Wait();
            this.After();
            this.AfterClick();
        }

        protected virtual void DbClick(string selector, ElementHandleDblClickOptions? options = null)
        {
            this.Page.Wait();
            this.Before();
            this.BeforeDbClick();

            var element = this.FindElementElseThrow(selector);
            element.DblClickAsync(options).GetAwaiter().GetResult();

            this.Page.Wait();
            this.After();
            this.AfterDbClick();
        }

        protected virtual void Hower(string selector, ElementHandleHoverOptions? options = null)
        {
            this.Page.Wait();
            this.Before();
            this.BeforeHower();

            var element = this.FindElementElseThrow(selector);
            element.HoverAsync(options).GetAwaiter().GetResult();

            this.Page.Wait();
            this.After();
            this.AfterHower();
        }

        protected virtual void Type(string selector, string value, ElementHandleTypeOptions? options = null)
        {
            this.Page.Wait();
            this.Before();
            this.BeforeType();

            var element = this.FindElementElseThrow(selector);
            element.TypeAsync(value, options).GetAwaiter().GetResult();

            this.Page.Wait();
            this.After();
            this.AfterType();
        }

        protected virtual void Fill(string selector, string value, ElementHandleFillOptions? options = null)
        {
            this.Page.Wait();
            this.Before();
            this.BeforeFill();

            var element = this.FindElementElseThrow(selector);
            element.FillAsync(value, options).GetAwaiter().GetResult();

            this.Page.Wait();
            this.After();
            this.AfterFill();
        }

        protected virtual void Check(string selector, ElementHandleCheckOptions? options = null)
        {
            this.Page.Wait();
            this.Before();
            this.BeforeCheck();

            var element = this.FindElementElseThrow(selector);
            element.CheckAsync(options).GetAwaiter().GetResult();

            this.Page.Wait();
            this.After();
            this.AfterCheck();
        }

        protected virtual void Uncheck(string selector, ElementHandleUncheckOptions? options = null)
        {
            this.Page.Wait();
            this.Before();
            this.BeforeUncheck();

            var element = this.FindElementElseThrow(selector);
            element.UncheckAsync(options).GetAwaiter().GetResult();

            this.Page.Wait();
            this.After();
            this.AfterUncheck();
        }
    }
}
