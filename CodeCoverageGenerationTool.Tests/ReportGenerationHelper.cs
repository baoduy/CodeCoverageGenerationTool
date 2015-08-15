using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCoverageGenerationTool.Tests
{
    [TestClass]
    public class ReportGenerationHelper
    {
        [TestMethod]
        public async Task GenerateReport()
        {
            var str = await CodeCoverageGenerationTool.ReportGenerationHelper.GenerateReport(
                @"C:\!Steven\!TFS\HBD\HBD.Framework\HBD.Framework.Test\bin\Debug\HBD.Framework.Test.dll", null);

            Assert.IsNotNull(str);
        }
    }
}
