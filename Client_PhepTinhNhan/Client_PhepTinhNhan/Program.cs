using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Client_PhepTinhNhan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ipend = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2014);
            Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Client.Connect(ipend);
            Console.WriteLine("Da ket noi");

            NetworkStream ns = new NetworkStream(Client);
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true;
            string s = sr.ReadLine();
            Console.WriteLine("From server: {0}", s);

            string so1, so2;
            Console.Write("Nhap so1: ");
            so1 = Console.ReadLine();
            sw.WriteLine(so1);
            Console.Write("Nhap so2: ");
            so2 = Console.ReadLine();
            sw.WriteLine(so2);
            sw.Flush();

            s = sr.ReadLine();
            Console.WriteLine("From Server: Tich = {0}", s);

            sr.Close();
            sw.Close();
            Client.Close();
            Console.ReadKey();
        }
    }
}
