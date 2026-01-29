using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main()
    {
        int port = 9001;
        TcpListener server = new TcpListener(IPAddress.Any, port);
        server.Start();
        Console.WriteLine("Server dang cho ket noi tai cong " + port + "...");

        TcpClient client = server.AcceptTcpClient();
        Console.WriteLine("Client da ket noi.");

        NetworkStream stream = client.GetStream();

        byte[] buffer = new byte[1024];
        int bytesRead = stream.Read(buffer, 0, buffer.Length);
        string received = Encoding.UTF8.GetString(buffer, 0, bytesRead);
        Console.WriteLine("Du lieu nhan duoc: " + received);
        string[] parts = received.Split(' ');
        int a = int.Parse(parts[0]);
        int b = int.Parse(parts[1]);

        int sum = a + b;
        Console.WriteLine("Tong a + b = " + sum);
        byte[] sendData = Encoding.UTF8.GetBytes(sum.ToString());
        stream.Write(sendData, 0, sendData.Length);

        client.Close();
        server.Stop();
        Console.WriteLine("Server da dong.");
        Console.ReadLine();
    }
}
