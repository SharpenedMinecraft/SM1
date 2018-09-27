using SharpenedMinecraft.Entities;
using SharpenedMinecraft.NetLib;
using SharpenedMinecraft.Plugins;
using SharpenedMinecraft.Types;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
namespace SharpenedMinecraft
{
    public class MinecraftServer : NetServer<MinecraftClient>
    {
        public MinecraftServer(MinecraftConfig config) : base()
        {
            // Configure the server
            this.Configuration.Host = IPAddress.Any;
            this.Configuration.Port = config.Port;
            this.Configuration.MaximumNumberOfConnections = config.MaxPlayers;
            //Configuration.OnlineMode = false;
        }

        public override void SendToAll(INetPacket packet, Func<NetUser, bool> predicate)
        {
            base.SendToAll(packet, x => predicate(x) && ((MinecraftClient)x).state == ((MinecraftPacket)packet).State);
        }

        // Initialize server resources. (Data loading, database, etc...)
        public override void Initialize(){
            Console.WriteLine("Waiting for Clean Enviroment....");
            var v = GC.WaitForFullGCApproach();
            //Later this may cause a) Lag, b) Problems, with ticking
            Console.WriteLine("Loading Blocks");
            Block.Initialize();
            Console.WriteLine("Loading Items");
            ItemStack.Initialize();
            Console.WriteLine("Loading Entities");
            BaseEntity.Initialize();
            Console.WriteLine("Loading Resources");
            ResourceManager.Load();
            Console.WriteLine("Loading Plugins");
            PluginManager.LoadPlugins(Path.GetFullPath("./Plugins"));
            Console.WriteLine("Building Resource Pack!");
            ResourceManager.Build();
            Console.WriteLine("Starting Tick");
            Tick.StartTick();
            if (v != GCNotificationStatus.Succeeded)
            {
                Console.WriteLine("Coundt Start in Clean Enviroment, Waiting for Cleaning....");
                GC.WaitForFullGCComplete(10000);
            }
            Console.WriteLine("READY!");
            Console.WriteLine("Waiting for Connections....");
        }

        // Action to do when a client is connected
        public override void OnClientConnected(MinecraftClient connection){ }

        // Action to do when a client has disconnected
        public override void OnClientDisconnected(MinecraftClient connection) { World.RemovePlayer(connection.Player); }

        // Action to do when an error occurs.
        public override void OnError(Exception exception) { Console.WriteLine(exception); }
    }
}
