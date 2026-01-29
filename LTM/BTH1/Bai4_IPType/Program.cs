using System;
using System.Net;

class Program
{
    static void Main()
    {
        string choice;

        do
        {
            Console.Write("Nhap dia chi IPv4: ");
            string input = Console.ReadLine();

            if (!IPAddress.TryParse(input, out IPAddress ip))
            {
                Console.WriteLine("Dia chi IP khong hop le.");
            }
            else
            {
                // Lay 4 byte cua IPv4
                byte[] bytes = ip.GetAddressBytes();

                if (IPAddress.IsLoopback(ip))
                {
                    Console.WriteLine("Loai dia chi: Loopback");
                }
                else if (input == "255.255.255.255")
                {
                    Console.WriteLine("Loai dia chi: Broadcast");
                }
                else if (bytes[0] >= 224 && bytes[0] <= 239)
                {
                    Console.WriteLine("Loai dia chi: Multicast");
                }
                else
                {
                    Console.WriteLine("Loai dia chi: Unicast");
                }
            }

            Console.WriteLine();
            Console.Write("Ban co muon kiem tra tiep khong? (y/n): ");
            choice = Console.ReadLine();

            Console.WriteLine();

        } while (choice.ToLower() == "y");

        Console.WriteLine("Ket thuc chuong trinh.");
    }
}
