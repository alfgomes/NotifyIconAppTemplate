using System;
using System.IO;
using System.Diagnostics;
using PSI = System.Diagnostics.ProcessStartInfo;

namespace NotifyIconAppTemplate.Extensions
{
    public static class FileInfoExtension
    {
        public static string GetSingleName(this FileInfo @self) => @self.Name.Replace(@self.Extension, "");

        public static void DeleteFileIfExixts(this FileInfo @self)
        {
            try
            {
                if (@self.Exists)
                    @self.Delete();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Execute(this FileInfo @self, bool onlyInstance, string args = null)
        {
            try
            {
                if (onlyInstance && (Process.GetProcessesByName(@self.Name.Replace(@self.Extension, "")).Length > 0))
                    return;

                if (@self.Exists)
                {
                    PSI info = new PSI(@self.FullName);
                    if (!string.IsNullOrEmpty(args))
                        info.Arguments = args;
                    info.CreateNoWindow = true;
                    info.UseShellExecute = false;
                    info.RedirectStandardError = true;
                    info.RedirectStandardOutput = true;
                    info.RedirectStandardInput = true;
                    info.WindowStyle = ProcessWindowStyle.Maximized;
                    Process whatever = Process.Start(info);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}