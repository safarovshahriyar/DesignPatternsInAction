namespace DesignPatternsInAction.Singleton;

public interface IFileLogger
{
    void LogInfo(string message);
    void LogError(string message);
    void LogWarning(string message);
}
