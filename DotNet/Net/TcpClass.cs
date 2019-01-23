using System;
using System.Net;
using System.Net.Sockets;

namespace DotNet.Net
{
    public class TcpClass
    {
        public static void RunTcpListener()
        {
            Console.WriteLine("Server is running……");

            while (true)
            {
                TcpListener listener = new TcpListener(IPAddress.Parse("127, 0, 0, 1"), 8500);
                listener.Start();
                Console.WriteLine("Start Listener……");

                TcpClient remoteClient = listener.AcceptTcpClient();

                Console.WriteLine("Client connect!Local:{0}<--{1}", remoteClient.Client.LocalEndPoint, remoteClient.Client.RemoteEndPoint);

            }
        }

        public static void RunTcpClient()
        {
            Console.WriteLine("Client is running……");

            //多个客户端发送信息
            TcpClient client;
            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    client = new TcpClient();
                    client.Connect(IPAddress.Parse("127, 0, 0, 1"), 8500);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
               
                Console.WriteLine("Client connect!Local:{0}<--{1}", client.Client.LocalEndPoint, client.Client.RemoteEndPoint);

            }
        }
    }
}