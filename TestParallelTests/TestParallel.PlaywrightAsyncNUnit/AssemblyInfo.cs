using NUnit.Framework;
using Microsoft.Playwright.NUnit;

[assembly: Parallelizable(ParallelScope.Self)]
[assembly: LevelOfParallelism(4)]