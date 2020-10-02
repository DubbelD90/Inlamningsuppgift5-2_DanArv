using System;
using SharedLibrary.Services;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var device = new DeviceClientService("HostName=ec-win20-danarv.azure-devices.net;DeviceId=DeviceApp;SharedAccessKey=oX1T0avW+ikvoo3oy57gXCchScQjN7acAhRBVbwmHn0=");
            Console.ReadKey();
        }
    }
}
