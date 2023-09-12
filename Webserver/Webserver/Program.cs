
// menu controll
using System.Net;
using System.Net.Sockets;
using System.Text;
using Webserver;

// to create new one:
CodeBehind server = new CodeBehind();

bool exist = true;

do
{

    Console.WriteLine();
    Console.WriteLine("1: to start");
    Console.WriteLine("2: to stop");
    Console.WriteLine("3: to close");
    int input = Convert.ToInt32(Console.ReadLine());


    switch (input)
    {
        case 1:
            // to start it
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            server.start(ipAddress, 8080, 5, "C:\\Users\\zbclshi\\Desktop\\test");
            break;
        case 2:
            // to stop it
            server.stop();
            break;
        case 3:
            exist = false;
            break;
    }

} while (exist);
















