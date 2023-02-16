using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Server_PhepTinhNhan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ipend = new IPEndPoint(IPAddress.Any, 2014);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ipend);
            server.Listen(10);
            Console.WriteLine("Cho ket noi tu client");
            Socket Client = server.Accept();
            Console.WriteLine("Da chap nhan ket noi tu client");
            NetworkStream nstr = new NetworkStream(Client);
            StreamReader sr = new StreamReader(nstr);
            StreamWriter sw = new StreamWriter(nstr);

            string s = "Wellcome to Server";
            sw.WriteLine(s);
            sw.Flush();
            int kq = 0;
            string so1 = sr.ReadLine();
            string so2 = sr.ReadLine();
            int a = int.Parse(so1);
            int b = int.Parse(so2);

            kq = a * b;
            sw.WriteLine(kq);
            sw.Flush();
            sr.Close();
            sw.Close();
            Client.Close();
            server.Close();
            Console.ReadKey();
        }
    }
}
