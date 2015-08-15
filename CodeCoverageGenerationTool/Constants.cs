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

            public static string ReportIssueUrl
                => System.Configuration.ConfigurationManager.AppSettings["ReportIssueUrl"];

            public static string MSTest
            {
                get
                {
                    var path = string.Empty;
                    var keys =
                        Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Machine)
                            .Keys.Cast<string>()
                            .Where(k => k.EndsWith("COMNTOOLS"));

                    foreach (var key in keys)
                    {
                        path = Environment.GetEnvironmentVariable(key);
                        path = Path.GetFullPath(path + @"\..\IDE\CommonExtensions\Microsoft\TestWindow\VSTest.Console.exe");
                        if (File.Exists(path))break;
                    }
                    
                    if (!File.Exists(path)) throw new FileNotFoundException(path);
                    return path;
                }
            }
        }
    }
}
