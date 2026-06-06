using ConsoleApp2.Logger;

namespace ConsoleApp2;

public class LoggerService
{
    private List<Log> Logs { get; set; } = new List<Log>();
    
    public async void AddLogAsync(LogLevel level, string message)
    {
        var log = new Log
        {
            Level = level, 
            Message = message,
            Date = DateTime.Now,
        };
        
        Logs.Add(log);
    }
    
    public async void DeleteLogAsync(Log log)
    {
        var filteredLogs = await GetLogsByLevelAsync(log.Level);
        
        filteredLogs = filteredLogs.Where(x => x.Date != log.Date).ToList();

        if (log.Message != null)
        {
            filteredLogs = Logs.Where(x => x.Message == log.Message).ToList();
        }

        if (filteredLogs.Count == 0)
        {
            return;
        }

        Logs.Remove(filteredLogs.First());
    }
    
    public async void ChangeLogLevelAsync(Log log, LogLevel level)
    {
        
    }
    
    public async Task<List<Log>> GetAllLogsAsync()
    {
        return Logs;
    }

    public async Task<List<Log>> GetLogsByLevelAsync(LogLevel level)
    {
        return Logs.Where(x => x.Level == level).ToList();
    }

    public async Task ReadFromFileAsync(string path)
    {
        
    }
    
    public async Task SaveToFileAsync(string path)
    {
        
    }
}