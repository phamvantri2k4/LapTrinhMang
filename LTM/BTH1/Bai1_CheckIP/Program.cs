using System;
using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main()
    {
        string choice;

        do
        {
            Console.Write("Nhap dia chi IP: ");
            string input = Console.ReadLine();

            if (IPAddress.TryParse(input, out IPAddress ip))
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    Console.WriteLine("Dia chi IP hop le - Phien ban IPv4");
                }
                else if (ip.AddressFamily == AddressFamily.InterNetworkV6)
                {
                    Console.WriteLine("Dia chi IP hop le - Phien ban IPv6");
                }
            }
            else
            {
                Console.WriteLine("Dia chi IP khong hop le");
            }

            Console.WriteLine();
            Console.Write("Ban co muon kiem tra tiep khong? (y/n): ");
            choice = Console.ReadLine();

            Console.WriteLine();

        } while (choice.ToLower() == "y");

        Console.WriteLine("Ket thuc chuong trinh.");
    }
}
