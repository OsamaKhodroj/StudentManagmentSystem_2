
using Pioneersacademy.SMS.Domains.Enums;

namespace Pioneersacademy.SMS.Services;

public class LogFile
{
    private static string _filePath;
     
    public static void WriteLog(LogType logType, string message)
    {
        _filePath = $"e:\\OsamaLogs\\log_{DateTime.Now.ToString()}.txt";
        bool isFileExist = File.Exists(_filePath);
        if (!isFileExist)
        {
            File.Create(_filePath).Dispose();
        }
         

        using var sw = new StreamWriter(_filePath, true);

        var logMessage = $"[{DateTime.Now.ToString()}] [{logType.ToString()}] {message}";

        sw.WriteLine(logMessage);
        sw.Flush();
    }
}
