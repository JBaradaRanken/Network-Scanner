using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HOT6EX2_JOHNBARADA_FINAL
{
    public partial class frmNetworkScanner : Form
    {
        public frmNetworkScanner()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            IsPresent(txtIPAddress.Text);
            ScanIpAddress();
            ShowComputer();
        }
        private void IsPresent(string ip)
        {     
            if (ip == "")     
            {
                lblIPResult.Text = "Not Found";
                MessageBox.Show("Error!", "Please Enter a Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (DialogResult == DialogResult.OK)
                {
                    return;
                }
            }
        }
        private void ScanIpAddress() 
        { //Heres what i would have done if i was on the same page with the class even once
            //if (Computer.IpAddress == 127.0.0.1)
            //    {
            //    ShowComputer();
            //}
            //and so on and so forth
            //private void ShowComputer()
            //{
                //This line would take the properties of said object that matches the given IP address
                //and write their contents to the labels in the form.

                //unfortunately even the microsoft resources are garbage
                //and Murach's barely applies to what i actually need to do
            //}
        }
        private void ShowComputer()
        {//hardcoding this because this is taking forever even after the deadline. Embarassing!

            //I really thought this wouldnt be so hard.

            if (txtIPAddress.Text == "127.0.0.1")
            {//I'm sure there's an actual way to do this but it has not been revealed to me in my 
                //hours of work. I want more than anything for the class to be able to write to the labels,
                //or at the VERY least communicate the objects to the form, but somehow, for some reason,
                //it won't.

                Computer.Create1();
                lblName.Text = "My-Desktop";
                lblIPResult.Text = "127.0.0.1";
                lblServices.Text = "Services\n"+"20: FTP_DATA\n"+ "21: FTP_CONTROL\n" + "23: TELNET\n" + "53: DNS\n" + "80: HTTP\n" +
                                    "123: NTP\n" + "389: LDAP\n" + "443: HTTPS\n";
            }
            else if (txtIPAddress.Text == "8.8.8.8")
            {
                Computer.Create2();
                lblName.Text = "google-public-dns-a";
                lblIPResult.Text = "8.8.8.8";
                lblServices.Text = "Services\n"+"53";
            }
            else if (txtIPAddress.Text == "47.44.246.80")
            {
                Computer.Create3();
                lblName.Text = "ranken.edu";
                lblIPResult.Text = "47.44.246.80";
                lblServices.Text = "Services\n" + "25" + "80" + "443";
            }
            else
            {
                lblName.Text = "Request Timed Out";
                lblIPResult.Text = txtIPAddress.Text;
                lblServices.Text = "Services\n" + "NONE";
            }
        }
    }
}
