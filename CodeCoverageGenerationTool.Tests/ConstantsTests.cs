using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCoverageGenerationTool.Tests
{
    [TestClass]
    public class ConstantsTests
    {
        [TestMethod]
        public void Can_Load_MSTestTool()
        {
            Assert.IsNotNull(Constants.AppSettings.MSTest);
        }
    }
}
