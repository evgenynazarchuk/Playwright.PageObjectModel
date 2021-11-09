using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace UIPageModel
{
    public abstract partial class PageModel
    {
        public virtual void Wait() { }

        public virtual IElementHandle FindElementElseThrow(
            string selector, 
            string exceptionMessage = "Element not found", 
            PageQuerySelectorOptions? options = null)
        {
            var element = this.page.QuerySelectorAsync(selector, options).GetAwaiter().GetResult();
            if(element is null) throw new ApplicationException(exceptionMessage);
            else return element;
        }

        public virtual IElementHandle? FindElement(string selector, PageQuerySelectorOptions? options = null)
        {
            var element = this.page.QuerySelectorAsync(selector, options).GetAwaiter().GetResult();
            return element;
        }

        public virtual IReadOnlyCollection<IElementHandle> FindElements(string selector)
        {
            var elements = this.page.QuerySelectorAllAsync(selector).GetAwaiter().GetResult();
            return elements;
        }

        public virtual void Click(string selector, PageClickOptions? options = null)
        {
            this.page.ClickAsync(selector, options).GetAwaiter().GetResult();
        }

        public virtual void Type(string selector, string value, PageTypeOptions? options = null)
        {
            this.page.TypeAsync(selector, value, options).GetAwaiter().GetResult();
        }
    }
}
