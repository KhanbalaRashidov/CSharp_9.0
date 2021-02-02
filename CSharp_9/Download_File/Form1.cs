using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Download_File
{
    public partial class Form1 : Form
    {
        string url;
        WebClient client;
        public Form1()
        {
            InitializeComponent();
            client = new WebClient() { Encoding = Encoding.UTF8 };
            url = @"https://algs4.cs.princeton.edu/14analysis/1Mints.txt";
        }

        private void btnDownloadAsync_Click(object sender, EventArgs e)
        {
            DownloadFiledAsync();
        }

        void DownloadFile()
        {
            client.DownloadFile(url, "test.txt");
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
             DownloadFile();
        }
        async void DownloadFiledAsync()
        {
            await client.DownloadFileTaskAsync(new Uri(url), "testAsync.txt");
        }
    }
}
