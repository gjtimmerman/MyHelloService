using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MyWindowsServiceHost
{
    public partial class Service1 : ServiceBase
    {
        ServiceHost myHost;
        public Service1()
        {
            InitializeComponent();
            myHost = new ServiceHost(typeof(MyHelloService.HelloImpl));
        }

        protected override void OnStart(string[] args)
        {
            myHost.Open();
        }

        protected override void OnStop()
        {
            myHost.Close();
        }
    }
}
