using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CodeCoverageGenerationTool
{
    public static class ReportGenerationHelper
    {
        public static async Task<string> GenerateReport(string unitTestDllPath, string outputFolder)
        {
            return await GenerateReport(unitTestDllPath, string.Empty, outputFolder);
        }

        public static async Task<string> GenerateReport(string unitTestDllPath, string filter, string outputFolder)
        {
            return await Task.Run(() =>
             {
                 if (string.IsNullOrEmpty(unitTestDllPath)) throw new ArgumentNullException(nameof(unitTestDllPath));
                 if (!unitTestDllPath.EndsWith("dll")) throw new ArgumentException("unitTestDllPath must be a dll.");
                 if (!File.Exists(unitTestDllPath)) throw new FileNotFoundException();

                 var stringBuild = new StringBuilder();

                 var fileName = Path.GetFileNameWithoutExtension(unitTestDllPath);
                 var outFolder = Path.GetFullPath(Path.Combine(outputFolder, fileName));
                 var outPutXmlFile = $"{outFolder}\\{fileName}.Results.xml";

                 if (string.IsNullOrEmpty(filter))
                 {
                     filter = fileName.Contains(".") ? fileName.Substring(0, fileName.LastIndexOf(".")) : fileName;
                 }

                 stringBuild.Append($"1. Verify ouput folder.{Environment.NewLine}");
                //Create output folder
                if (!System.IO.Directory.Exists(outFolder))
                     Directory.CreateDirectory(outFolder);
                //Delete All files in Folders

                stringBuild.Append($"2. Clear output folder.{Environment.NewLine}");
                 new DirectoryInfo(outFolder).Clear();

                 stringBuild.Append($"3. Generate Test Result.{Environment.NewLine}");
                 var startInfo = new ProcessStartInfo(Constants.AppSettings.OpenCoverTool)
                 {
                     WindowStyle = ProcessWindowStyle.Hidden,
                     CreateNoWindow = true,
                     Arguments = $"-register:user -target:\"{Constants.AppSettings.MSTest}\" -targetargs:\"{unitTestDllPath}\" -output:{outPutXmlFile} -filter:\"+[{filter}*]* -[{fileName}*]*\"",
                     WorkingDirectory = Environment.CurrentDirectory,
                     RedirectStandardOutput = true,
                     UseShellExecute = false
                 };

                 using (var process = Process.Start(startInfo))
                 {
                     var str = process.StandardOutput.ReadToEnd();
                     //process.WaitForExit();
                     process.Close();

                     stringBuild.Append(str);
                     stringBuild.Append($"{Environment.NewLine}{Environment.NewLine}");
                 }

                 if (File.Exists(outPutXmlFile))
                 {
                     stringBuild.Append($"4. Generate Report.{Environment.NewLine}");

                    //Generate HTML.
                    startInfo = new ProcessStartInfo(Constants.AppSettings.ReportGeneratorTool)
                     {
                         WindowStyle = ProcessWindowStyle.Hidden,
                         CreateNoWindow = true,
                         Arguments = $"-reports:\"{outPutXmlFile}\" -targetdir:\"{outFolder}\"",
                         WorkingDirectory = Environment.CurrentDirectory,
                         RedirectStandardOutput = true,
                         UseShellExecute = false
                     };

                     using (var process = Process.Start(startInfo))
                     {
                         var str = process.StandardOutput.ReadToEnd();
                         //process.WaitForExit();
                         process.Close();

                         stringBuild.Append(str);
                         stringBuild.Append($"{Environment.NewLine}{Environment.NewLine}");
                     }

                     var htmFile = $"{outFolder}\\index.htm";
                     if (System.IO.File.Exists(htmFile))
                     {
                         stringBuild.Append($"5. Run report.{Environment.NewLine}");
                         Process.Start(htmFile);
                     }
                 }
                 return stringBuild.ToString();
             });
        }

        private static void Clear(this DirectoryInfo @this)
        {
            foreach (var file in @this.GetFiles()) file.Delete();
            foreach (var subDirectory in @this.GetDirectories()) subDirectory.Delete(true);
        }
    }
}
