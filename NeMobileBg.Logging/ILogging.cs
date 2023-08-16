namespace NeMobileBg.Logging;

public interface ILogging
{
    void LogDebug(string message);

    void LogWarnig(string message);

    void LogError(string message);
}