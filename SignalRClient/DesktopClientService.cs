using System.ServiceProcess;
using NLog;

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
