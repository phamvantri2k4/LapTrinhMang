using System;
using System.Net;

class Program
{
    static void Main()
    {
        string choice;

        do
        {
            Console.Write("Nhap ten mien: ");
            string domain = Console.ReadLine();

            try
            {
                IPAddress[] ipList = Dns.GetHostAddresses(domain);

                Console.WriteLine("Cac dia chi IP cua ten mien " + domain + ":");

                foreach (IPAddress ip in ipList)
                {
                    Console.WriteLine(ip.ToString());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Khong tim thay ten mien hoac loi DNS.");
            }

            Console.WriteLine();
            Console.Write("Ban co muon tra cuu tiep khong? (y/n): ");
            choice = Console.ReadLine();

            Console.WriteLine();

        } while (choice.ToLower() == "y");

        Console.WriteLine("Ket thuc chuong trinh.");
    }
}
