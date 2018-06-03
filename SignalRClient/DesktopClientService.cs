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
            Timer timer = new Timer();
            timer.Interval = 60000; // 60 seconds  
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        protected override void OnStop()
        {
        }

        public void OnTimer(object sender, System.Timers.ElapsedEventArgs args)
        {

        }
    }
}
