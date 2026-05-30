using LogSeriallog;
using Microsoft.Extensions.Logging;

namespace wwwHome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var _logger = new LoggerSlog().Create();
            _logger.LogWarning("Start Application...");
            _logger.LogInformation("Stop Application...");
        }
    }
}
