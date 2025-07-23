using DesignPatternsInAction.Singleton;

var logger = FileLogger.Instance;

logger.LogInfo("Application started.");
logger.LogWarning("Low memory warning.");
logger.LogError("Unhandled exception occurred.");

Console.WriteLine("Log written to: logs/app.log");
