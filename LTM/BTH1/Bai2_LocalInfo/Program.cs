using System;
using System.Net;

class Program
{
    static void Main()
    {

        string hostName = Dns.GetHostName();
        Console.WriteLine("Ten may tinh: " + hostName);

        IPAddress[] ipList = Dns.GetHostAddresses(hostName);

        Console.WriteLine("Danh sach dia chi IP:");

        foreach (IPAddress ip in ipList)
        {
            Console.WriteLine(ip.ToString());
        }

        Console.ReadLine();
    }
}
