using System;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main()
    {
        string serverIP = "127.0.0.1";
        int port = 9001;

        TcpClient client = new TcpClient(serverIP, port);
        NetworkStream stream = client.GetStream();

        Console.Write("Nhap so a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap so b: ");
        int b = int.Parse(Console.ReadLine());

        // Gui a va b cho Server (cach nhau boi dau cach)
        string message = a + " " + b;
        byte[] data = Encoding.UTF8.GetBytes(message);
        stream.Write(data, 0, data.Length);

        // Nhan ket qua tu Server
        byte[] buffer = new byte[1024];
        int bytesRead = stream.Read(buffer, 0, buffer.Length);
        string result = Encoding.UTF8.GetString(buffer, 0, bytesRead);

        Console.WriteLine("Tong nhan duoc tu Server: " + result);

        client.Close();
        Console.ReadLine();
    }
}
