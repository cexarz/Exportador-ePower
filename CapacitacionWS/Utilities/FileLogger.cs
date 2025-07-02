using System;
using System.IO;

namespace CapacitacionWS.Utilities
{
    public static class FileLogger
    {
        private static readonly string LogPath = @"C:\LogAplicacion\errors.log";

        public static void LogError(Exception ex)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(LogPath));
                File.AppendAllText(LogPath, $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {ex.GetType().Name}: {ex.Message}\n");
            }
            catch { /* No fallar si no puede escribir el log */ }
        }
    }
}