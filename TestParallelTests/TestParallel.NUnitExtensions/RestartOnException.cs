using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;
using System;

namespace TestParallel.NUnitExtensions;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
public class RestartOnException : PropertyAttribute, IWrapSetUpTearDown
{
    private int _count;

    public RestartOnException(int count) : base(count)
    {
        _count = count;
    }

    public TestCommand Wrap(TestCommand command)
    {
        return new CustomRetryCommand(command, _count);
    }

    public class CustomRetryCommand : DelegatingTestCommand
    {
        private int _tryRetry;

        public CustomRetryCommand(TestCommand innerCommand, int retryCount)
        : base(innerCommand)
        {
            _tryRetry = retryCount;
        }

        public override TestResult Execute(TestExecutionContext context)
        {
            int count = _tryRetry;

            while (count-- > 0)
            {
                try
                {
                    context.CurrentResult = innerCommand.Execute(context);
                }
                catch (Exception ex)
                {
                    if (context.CurrentResult == null)
                    {
                        context.CurrentResult = context.CurrentTest.MakeTestResult();
                    }

                    context.CurrentResult.RecordException(ex);
                }

                if (context.CurrentResult.ResultState == ResultState.Success)
                {
                    break;
                }

                if (count > 0)
                {
                    context.CurrentResult = context.CurrentTest.MakeTestResult();
                    context.CurrentRepeatCount++;
                }
            }

            return context.CurrentResult;
        }
    }
}