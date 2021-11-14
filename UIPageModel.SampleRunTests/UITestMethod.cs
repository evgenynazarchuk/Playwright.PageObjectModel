using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UIPageModel.SampleRunTests;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class UITestMethodAttribute : TestMethodAttribute
{
    public UITestMethodAttribute() { }

    public UITestMethodAttribute(string displayName)
        : base(displayName) { }

    public override TestResult[] Execute(ITestMethod testMethod)
    {
        TestResult[]? result = null;
        var retryOnError = testMethod.GetAttributes<RetryOnError>(false).FirstOrDefault();

        if (retryOnError is null)
        {
            return base.Execute(testMethod);
        }
        else
        {
            for (int i = 0; i < retryOnError.Value; i++)
            {
                result = base.Execute(testMethod);
                if (result[0].Outcome != UnitTestOutcome.Passed) continue;
                else return result;
            }

            return result!;
        }
    }
}
