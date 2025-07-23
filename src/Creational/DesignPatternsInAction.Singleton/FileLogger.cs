namespace DesignPatternsInAction.Singleton;

public sealed class FileLogger : IFileLogger
{
    private static readonly Lazy<FileLogger> _instance = new(() => new FileLogger());
    private static readonly object _lock = new();

    private readonly string _logFilePath;

    public static FileLogger Instance => _instance.Value;

    private FileLogger()
    {
        var options = new FileLoggerOptions();
        _logFilePath = options.LogFilePath;

        var directory = Path.GetDirectoryName(_logFilePath);
        if (!Directory.Exists(directory))
            Directory.CreateDirectory(directory!);

        LogInternal("Logger initialized");
    }

    public void LogInfo(string message) => LogInternal("[INFO] " + message);
    public void LogError(string message) => LogInternal("[ERROR] " + message);
    public void LogWarning(string message) => LogInternal("[WARN] " + message);

    private void LogInternal(string message)
    {
        var logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
        lock (_lock)
        {
            File.AppendAllText(_logFilePath, logEntry + Environment.NewLine);
        }
    }
}
