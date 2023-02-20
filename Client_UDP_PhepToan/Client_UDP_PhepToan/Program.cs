using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace Client_UDP_PhepToan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ipend = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2014);
            Socket skclient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            EndPoint enpt = (EndPoint)ipend;
            string so1, so2, sum;
            byte[] data;
            int recv;
            while (true)
            {
                Console.Write("Nhap so1: ");
                so1 = Console.ReadLine();
                if(so1.Length == 0) break;
                data = new byte[1024];
                data = Encoding.ASCII.GetBytes(so1);
                skclient.SendTo(data, ipend);

                Console.Write("Nhap so2: ");
                so2 = Console.ReadLine();
                data = new byte[1024];
                data = Encoding.ASCII.GetBytes(so2);
                skclient.SendTo(data, ipend);

                data = new byte[1024];
                recv = skclient.ReceiveFrom(data, ref enpt);
                sum = Encoding.ASCII.GetString(data, 0, recv);
                Console.Write("Tong cua (a={0} & b={1}) là: {2}\n", so1, so2, sum);
            }
            skclient.Close();
        }
    }
}
