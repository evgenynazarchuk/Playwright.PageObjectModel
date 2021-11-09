using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIBlockModel
{
    public abstract partial class BlockModel<TBlockModel>
        where TBlockModel : BlockModel<TBlockModel>
    {
        protected virtual void Before() { }

        protected virtual void After() { }

        protected virtual void BeforeFindElement() { }

        protected virtual void BeforeFindElements() { }

        protected virtual void BeforeClick() { }

        protected virtual void AfterClick() { }

        protected virtual void BeforeType() { }

        protected virtual void AfterType() { }

        protected virtual void BeforeFill() { }

        protected virtual void AfterFill() { }

        protected virtual void BeforeDbClick() { }

        protected virtual void AfterDbClick() { }

        protected virtual void BeforeHower() { }

        protected virtual void AfterHower() { }

        protected virtual void BeforeCheck() { }

        protected virtual void AfterCheck() { }

        protected virtual void BeforeUncheck() { }

        protected virtual void AfterUncheck() { }
    }
}
