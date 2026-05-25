using LogSeriallog;
using Microsoft.Extensions.Logging;

namespace ConLog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var _logger = new LoggerSlog().Create(); 
            _logger.LogWarning("Start Application...");
            Console.ReadKey();
            _logger.LogInformation("Stop Application...");
            //jkljlk
        }
    }
}