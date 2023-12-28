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
            string url = "https://api.steamcmd.net/v1/info/322170";

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            Stream stream = res.GetResponseStream();
            StreamReader streamRead = new StreamReader(stream);

            string streamReadData = streamRead.ReadToEnd();

            dynamic d = JsonConvert.DeserializeObject(streamReadData);
            string geometryDashVersion = d.data["322170"].depots.branches["public"].timeupdated.ToString();

            if (geometryDashVersion != "1703035638")
            {
                version.Text = "Yes";
                version.ForeColor = Color.LightGreen;
                timeRefreshed.Text = DateTime.Now.ToLongTimeString();
                if (checkBox.Checked)
                {
                    while (true)
                    {
                        Console.Beep();
                    }
                }
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
            
        }

        private void timeRefreshedLabel_Click(object sender, EventArgs e)
        {
            
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkNioro_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Nioro/2.2-when");
        }

        private void linkStrainxx_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/strainxx/is2.2out");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
