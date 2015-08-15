using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCoverageGenerationTool
{
    public static class Constants
    {
        public static class AppSettings
        {
            public static string OpenCoverTool => System.Configuration.ConfigurationManager.AppSettings["OpenCoverTool"];

            public static string ReportGeneratorTool
                => System.Configuration.ConfigurationManager.AppSettings["ReportGeneratorTool"];

            public static string DefaultOutputFolder
                => System.Configuration.ConfigurationManager.AppSettings["DefaultOutputFolder"];

            public static string MSTest
            {
                get
                {
                    var path = string.Empty;
                    var key =
                        Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Machine)
                            .Keys.Cast<string>()
                            .LastOrDefault(k => k.EndsWith("COMNTOOLS"));

                    if (key == null) return path;

                    path = Environment.GetEnvironmentVariable(key);
                    path = Path.GetFullPath(path + @"\..\IDE\CommonExtensions\Microsoft\TestWindow\VSTest.Console.exe");
                    if (!System.IO.File.Exists(path)) throw new FileNotFoundException(path);
                    return path;
                }
            }
        }
    }
}
