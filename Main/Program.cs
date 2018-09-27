using SharpenedMinecraft.DataTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SharpenedMinecraft
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Starting Minecraft!");
            var EndianMode = "";
            if (BitConverter.IsLittleEndian)
                EndianMode = "Little Endian";
            else
                EndianMode = "Big Endian";
            Console.WriteLine($"Endianess: {EndianMode}");
            var server = new MinecraftServer(new MinecraftConfig()
            {
                MaxPlayers = 50,
                Port = 25565
            });
            server.Start();
            bool Run = true;
            while (Run)
            {
                var s = Console.ReadLine();
                switch (s)
                {
                    case "Exit":
                        Run = false;
                        break;
                }
            }
            server.Stop();
        }
    }
}
