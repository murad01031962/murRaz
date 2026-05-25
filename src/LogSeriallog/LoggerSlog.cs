using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace LogSeriallog;

public class LoggerSlog
{
    private ILoggerFactory? _loggerFactory = null; //Для логирования
    public Microsoft.Extensions.Logging.ILogger Create()
    {
        Microsoft.Extensions.Logging.ILogger _logger;
        var _log = new LoggerConfiguration();
        //_log.ReadFrom.Configuration(configuration);
        _log.MinimumLevel.Verbose();
        _log.WriteTo.Logger(l => l.Filter.ByIncludingOnly(e =>
                 (e.Level == LogEventLevel.Information || e.Level == LogEventLevel.Warning))
                    .WriteTo.Map(le => le.Timestamp.Date, (date, lc) => lc
                         //.File($"{_pathLogRoot}/logs/{date:yyyyMMdd}/log-Info-{date:yyyyMMdd}.txt")));
                         .File($"logs/{date:yyyy-MM-dd}/log-Info-{date:yyyyMMdd}.txt")));
        _log.WriteTo.Logger(l => l.Filter.ByIncludingOnly(e =>
                    (e.Level == LogEventLevel.Information || e.Level == LogEventLevel.Warning
                    || e.Level == LogEventLevel.Error || e.Level == LogEventLevel.Debug))
                        .WriteTo.ColoredConsole());  // выводим данные на консоль
        Log.Logger = _log.CreateLogger();
        _loggerFactory = new LoggerFactory().AddSerilog();
        _logger = _loggerFactory.CreateLogger<Serilog.Core.Logger>();
        return _logger;
    }
}