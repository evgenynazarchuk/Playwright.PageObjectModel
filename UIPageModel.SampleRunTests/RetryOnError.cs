using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIPageModel.SampleRunTests
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class RetryOnError : Attribute
    {
        public RetryOnError(int count)
        {
            this.Value = count;
        }

        public readonly int Value;
    }
}
