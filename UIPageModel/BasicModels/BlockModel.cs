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
        public BlockModel(TPageModel pageModel, string selector)
        {
            this.Page = pageModel;
            this.CurrentBlock = this.Page.FindElementElseThrow(selector);
        }

        public BlockModel(BlockModel<TPageModel> blockModel, string selector)
        {
            this.Page = blockModel.Page;
            this.CurrentBlock = blockModel.FindElementElseThrow(selector);
        }

        public readonly TPageModel Page;

        protected readonly IElementHandle CurrentBlock;
    }
}
