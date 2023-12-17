using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Web;

namespace _2._2when
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckSteam();
        }
        private void CheckSteam()
        {
            if (GeometryDash.geometryDashVersion != "1511222225")
            {
                version.Text = "Yes";
                version.ForeColor = Color.LightGreen;
                timeRefreshed.Text = DateTime.Now.ToLongTimeString();
            }
            else
            {
                version.Text = "No";
                version.ForeColor = Color.Salmon;
                timeRefreshed.Text = DateTime.Now.ToLongTimeString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tpt_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckSteam();
        }

        private void checkVersion_Click(object sender, EventArgs e)
        {
            CheckSteam();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void githubRepos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Nioro/2.2-when");
        }
    }

    static class GeometryDash
    {
        static string url = "https://api.steamcmd.net/v1/info/322170";

        static HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        static HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        static Stream stream = res.GetResponseStream();
        static StreamReader streamRead = new StreamReader(stream);

        static public string streamReadData = streamRead.ReadToEnd();

        static public dynamic d = JsonConvert.DeserializeObject(streamReadData);
        static public string geometryDashVersion = d.data["322170"].depots.branches["public"].timeupdated.ToString();
    }

}
