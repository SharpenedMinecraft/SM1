using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Packets;
using System.Threading.Tasks;
using SharpenedMinecraft.Attributes;
using SharpenedMinecraft.DataTypes;
using fNbt.Tags;

namespace SharpenedMinecraft
{
    public class Player : LivingEntity
    {
        private string _Name;
        public string Name { get { return _Name; } set { _Name = value; this.CustomName = new ChatMessage() { Text = value }; } }

        public override SpawnMethodes SpawnMethode => SpawnMethodes.Spezial;
        public override byte SpawnId => 0;
        public override String Id => "Spezial:Player";
        public override int EntityId { get; set; }
        public GameMode GameMode { get; set; }
        public Vector3 SpawnPosition { get; set; }
        public PlayerAbilities Abilities { get; set; }
        public Transform NextTransform;
        //TODO: Locale Enum?
        public string Locale { get; set; }
        public int ViewDistance { get; set; }
        public ChatMode ChatMode { get; set; }
        public bool ChatColors { get; set; }
        [EntityMetadata(13, typeof(byte))]
        public DisplayedSkinParts DisplayedSkinParts { get; set; }
        [EntityMetadata(14, typeof(byte))]
        public MainHand MainHand { get; set; }
        public Inventory Inventory;
        [EntityMetadata(11, typeof(float))]
        public float AdditionalHearts { get; set; }
        [EntityMetadata(12, typeof(VarInt))]
        public VarInt Score { get; set; }
        public string UsedServerIP { get; set; }
        //TODO: Parrots
        /*[EntityMetadata(15, typeof(NbtTag))]
        public NbtTag LeftShoulder { get; set; }
        [EntityMetadata(16, typeof(NbtTag))]
        public NbtTag RightShoulder { get; set; }*/

        public double HeadY => Transform.Position.Y + 1.62;
        public MinecraftClient Client { get; }

        //Sets Entity Id
        /// <summary>
        /// Do never, *never* create a Player.
        /// </summary>
        public Player(MinecraftClient client) : base()
        {
            this.Client = client;
            NextTransform = Transform;
            Inventory = new Inventory(this);
            GameMode = GameMode.Creative;
            SpawnPosition = new Vector3(0, 0, 0);
            Abilities = new PlayerAbilities();
            OnGround = true;
            World.Entities.Remove(this); //Re-Add Later on
        }

        public Player() : base() { }

        public Dictionary<int, Window> OpenWindows = new Dictionary<int, Window>();

        public void RightClick(Hand usedHand)
        {
            Console.WriteLine($"{Name} has used {Inventory.Selected.ToString()} (R-Click)");
        }

        public override void PreTick()
        {
            this.LastTransform = this.Transform;
            this.Transform = this.NextTransform;
            base.PreTick();
        }

        public override void PostTick()
        {
            if (Age == long.MaxValue)
            {
                Age = long.MinValue;
                Console.WriteLine("WTF, THE AGE JUST HIT THE MAX NUM");
            }
            Age++;
        }

        public void CloseWindow(int windowId)
        {
            if (windowId == 0)
                //This is The Inventory
                return;
            if (OpenWindows.ContainsKey(windowId))
                OpenWindows.Remove(windowId);
            else
                Client.EndConnection("Wrong Window id");
        }

        public void OpenWindow(byte windowId, Window window)
        {
            Client.Send(new OpenWindowPacket(Client)
            {
                window = window,
                WindowID = windowId
            });
            OpenWindows.Add(windowId, window);
        }

        public bool Equals(Player other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return this.UUID.Equals(other.UUID);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Player)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return UUID.GetHashCode();
            }
        }

        public static bool operator ==(Player left, Player right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Player left, Player right)
        {
            return !left.Equals(right);
        }
    }
}