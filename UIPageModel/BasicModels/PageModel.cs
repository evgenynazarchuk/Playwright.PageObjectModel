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
        public PageModel(IPage page)
        { 
            this.page = page;
        }

        protected readonly IPage page;
    }
}
