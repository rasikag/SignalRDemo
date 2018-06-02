using System.ServiceProcess;
using NLog;
using System.Timers;

namespace SignalRClient
{
    public partial class DesktopClientService : ServiceBase
    {
        public DesktopClientService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

        }

        protected override void OnStop()
        {
        }
    }
}
