using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Discovery;

namespace MyAnnouncementProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            AnnouncementService myAnnouncement = new AnnouncementService();
            myAnnouncement.OnlineAnnouncementReceived += (object sender, AnnouncementEventArgs anargs) => Console.WriteLine($"Hello message received: {anargs.EndpointDiscoveryMetadata.Address}");
            myAnnouncement.OfflineAnnouncementReceived += (object sender, AnnouncementEventArgs anargs) => Console.WriteLine($"Bye message received: {anargs.EndpointDiscoveryMetadata.Address}");
            ServiceHost myHost = new ServiceHost(myAnnouncement);
            myHost.AddServiceEndpoint(new UdpAnnouncementEndpoint());
            myHost.Open();
            Console.WriteLine("Waiting for service to register");
            Console.ReadLine();
            myHost.Close();
        }
    }
}
