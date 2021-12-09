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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace TestParallel.PlaywrightAsyncMSTest.Support;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class UITestAttribute : TestMethodAttribute
{
    public UITestAttribute() { }

    public UITestAttribute(string name)
        : base(name) { }

    public override TestResult[] Execute(ITestMethod testMethod)
    {
        TestResult[]? result = null;
        var retryAttribute = testMethod.GetAttributes<RestartOnException>(false).FirstOrDefault();

        if (retryAttribute is null)
        {
            return base.Execute(testMethod);
        }
        else
        {
            for (int i = 0; i < retryAttribute.Value; i++)
            {
                result = base.Execute(testMethod);
                if (result[0].Outcome == UnitTestOutcome.Passed) break;
            }

            return result!;
        }
    }
}
