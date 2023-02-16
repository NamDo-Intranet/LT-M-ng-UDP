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
using System.Net.Sockets;
using System.IO;

namespace Client_Truyenfile
{
    public partial class Form1 : Form
    {
        string filename;
        string filepath;
        Socket Client;
        long filesize;

        public Form1()
        {
            InitializeComponent();
            tbketnoi.Text = "Not connect";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReceiveFile(Client);
        }

        private void btduongdan_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = "C:\\Users\\anhxo\\OneDrive\\Tài liệu\\LTMangC#\\Server_PhepTinhNhan\\Server_PhepTinhNhan\\Program.cs";
            fbd.ShowNewFolderButton = true;
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                filepath = fbd.SelectedPath;
                tbduongdan.Text = filepath;
            }
        }
        private void ReceiveFile(Socket Client)
        {
            NetworkStream ns = new NetworkStream(Client);

            byte[] data = new byte[200];
            int recv = ns.Read(data, 0, 200);
            filename = Encoding.ASCII.GetString(data, 0, recv).Trim();
            string fullpathname = tbduongdan.Text + "\\" + filename;

            data = new byte[100];
            recv = ns.Read(data, 0, 100);

            filesize = long.Parse(Encoding.ASCII.GetString(data, 0, recv).Trim());
            FileStream fs = new FileStream(fullpathname, FileMode.OpenOrCreate, FileAccess.Write);
            byte[] buffer;
            long sumcount = 0;
            while(filesize > sumcount)
            {
                buffer = new byte[1024];
                recv = ns.Read(buffer, 0, 1024);
                sumcount += recv;
                fs.Write(buffer, 0, recv);
            }
            fs.Flush();
            fs.Close();
            ns.Close();
            tbketnoi.Text = "Finish!" + sumcount;
        }

        private void btConn_Click(object sender, EventArgs e)
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2014);
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Client.Connect(iep);
            tbketnoi.Text = "Connected: " + Client.RemoteEndPoint.ToString();
            ReceiveFile(Client);
        }
    }
}
