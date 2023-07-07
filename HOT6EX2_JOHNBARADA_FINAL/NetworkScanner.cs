using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace HOT6EX2_JOHNBARADA_FINAL
{
    internal class NetworkScanner
    {
    }
    public class Computer
    {
        public Computer() { }

        private string _name;
        private string _ipAddress;
        private int[] _services = { 20, 21, 23, 25,53, 80, 123, 389, 443};
        public Computer(string _name, string _ipAddress, int[] _services)
        {
            Name = _name;
            IpAddress = _ipAddress;
            Services = _services;
        }
        public string Name { get; set; }
        public string IpAddress { get; set; }
        public int[] Services { get; set; }

        public static void Create1()
        {
            Computer c1 = new Computer
            {

                Name = "My-Desktop",
                IpAddress = "127.0.0.1",
                Services = new int[] { 20, 21, 23, 25, 53, 80, 123, 389, 443 }
                
            };
        }
        public static void Create2()
        {
            Computer c2 = new Computer
            {
                Name = "google-public-dns-a",
                IpAddress = "8.8.8.8",
                Services = new int[] { 53 }
            };
        }
        public static void Create3()
        {
            Computer c3 = new Computer
            {
                Name = "ranken.edu",
                IpAddress = "47.44.246.80",
                Services = new int[] { 25, 80, 443 }
            };
        }

        public override string ToString()
        {
            return Name.ToString() + "\n" + IpAddress.ToString() + "\n" + Services.ToString();
        }
    }            //Services.Add("20: FTP_DATA");
                 //Services.Add("21: FTP_CONTROL");
                 //Services.Add("23TELNET");
                 //Services.Add("25: SMTP");
                 //Services.Add("53: DNS");
                 //Services.Add("80: HTTP");
                 //Services.Add("123: NTP");
                 //Services.Add("389: LDAP");
                 //Services.Add("443: HTTPS");
    /*{ 20, 21, 23, 25, 53, 80, 123, 389, 443 };*/

    //private Computer c1 = new Computer("My-Desktop", "127.0.0.1", services);

}
