using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server_UDP_PhepToan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ipend = new IPEndPoint(IPAddress.Any, 2014);
            Socket skserver = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            skserver.Bind(ipend);
            EndPoint enpt = (EndPoint)ipend;

            byte[] data;
            string so1, so2, kq;
            int recv;
            while (true)
            {
                Console.Write("Waiting a: ");
                data = new byte[1024];
                recv = skserver.ReceiveFrom(data, ref enpt);

                if (recv == 0) break;
                so1 = Encoding.ASCII.GetString(data, 0, recv);

                Console.Write("Waiting b: ");
                data = new byte[1024];
                recv = skserver.ReceiveFrom(data, ref enpt);

                so2 = Encoding.ASCII.GetString(data, 0, recv);
                Console.Write("Tong a={0}, b={1}", so1, so2);

                kq = (Int32.Parse(so1)+Int32.Parse(so2)).ToString();

                data = new byte[1024];
                data = Encoding.ASCII.GetBytes(kq);
                skserver.SendTo(data, enpt);

            }
            skserver.Close();
        }
    }
}
