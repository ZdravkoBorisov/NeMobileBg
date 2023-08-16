namespace NeMobileBg.Logging;

public class Logging : ILogging
{
    public void LogDebug(string message)
    {
        var path = Path.Combine(LogDebugPath, $"{DateTime.Today:yyyyMMdd}.txt");
        File.WriteAllText(path, message + $" at {DateTime.UtcNow} UTC.");
    }

    public void LogError(string message)
    {
        var path = Path.Combine(LogErrorPath, $"{DateTime.Today:yyyyMMdd}.txt");
        File.WriteAllText(path, message + $" at {DateTime.UtcNow} UTC.");
    }

    public void LogWarnig(string message)
    {
        var path = Path.Combine(LogWarningPath, $"{DateTime.Today:yyyyMMdd}.txt");
        File.WriteAllText(path, message + $" at {DateTime.UtcNow} UTC.");
    }
}
