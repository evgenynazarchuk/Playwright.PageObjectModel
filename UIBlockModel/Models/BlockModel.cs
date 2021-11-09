using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace UIBlockModel
{
    public abstract partial class BlockModel<TBlockModel>
        where TBlockModel : BlockModel<TBlockModel>
    {
        public BlockModel(IPage page)
        {
            this.Page = page;

            var element = this.Page.QuerySelectorAsync("//html").GetAwaiter().GetResult();
            if (element is null) throw new ApplicationException("Block not found");
            else this.CurrentBlock = element;
        }

        public BlockModel(TBlockModel parentBlockModel, string selector)
        {
            this.Page = parentBlockModel.Page;
            this.CurrentBlock = parentBlockModel.FindElementElseThrow(selector, "Block not found");

        }

        public readonly IPage Page;

        public readonly IElementHandle CurrentBlock;
    }
}
