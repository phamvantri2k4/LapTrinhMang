using System;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main()
    {
        string serverIP = "127.0.0.1";
        int port = 9000;

        TcpClient client = new TcpClient(serverIP, port);
        NetworkStream stream = client.GetStream();

        Console.Write("Nhap chuoi can gui len Server: ");
        string message = Console.ReadLine();

        byte[] data = Encoding.UTF8.GetBytes(message);
        stream.Write(data, 0, data.Length);

        byte[] buffer = new byte[1024];
        int bytesRead = stream.Read(buffer, 0, buffer.Length);
        string result = Encoding.UTF8.GetString(buffer, 0, bytesRead);

        Console.WriteLine("Ket qua nhan tu Server: " + result);
        client.Close();
        Console.ReadLine();
    }
}
