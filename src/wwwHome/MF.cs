using LogSeriallog;
using Microsoft.Extensions.Logging;

namespace wwwHome
{
    public partial class MF : Form
    {
        public const string Ver = "[2026.05.30]"; //Номер версии

        public MF()
        {
            InitializeComponent();
            var _logger = new LoggerSlog().Create();
            _logger.LogWarning("Start Application...");
            _logger.LogInformation("Stop Application...");
        }
    }
}
