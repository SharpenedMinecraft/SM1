using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using Force.DeepCloner;
using SharpenedMinecraft.Attributes;
using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.NetLib;
using SharpenedMinecraft.Packets;
using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;

namespace SharpenedMinecraft.Entities
{
    //http://wiki.vg/Entity_metadata#Entity
    public abstract class BaseEntity : IEquatable<BaseEntity>, IDisposable, INotifyPropertyChanged
    {
        public enum SpawnMethodes
        {
            Object,
            Mob,
            Spezial
        }
        public abstract SpawnMethodes SpawnMethode { get; }

        public abstract byte SpawnId { get; }
        public abstract string Id { get; }
        public abstract int EntityId { get; set; }
        [EntityMetadata(0, typeof(byte))]
        public EntityEffect Effects { get; set; }
        [EntityMetadata(1, typeof(VarInt))]
        public VarInt Air { get; set; }
        //[EntityMetadata(2, typeof(string))]
        public ChatMessage CustomName { get; set; }
        public Transform Transform;
        public Transform LastTransform;
        [EntityMetadata(3, typeof(bool))]
        public bool IsCustomNameVisible { get; set; }
        [EntityMetadata(4, typeof(bool))]
        public bool NoGravity { get; set; }
        [EntityMetadata(5, typeof(bool))]
        public bool Silent { get; set; }
        public Vector3F Velocity { get; set; }
        public Boolean OnGround { get; set; }
        public virtual Boolean Ticking => true;
        public bool Broadcasted = false;
        public long Age { get; set; }
        public Guid UUID { get; set; }
        private static bool Initialized = false;
        private static Dictionary<string, Type> EntityTypes = new Dictionary<string, Type>();

        public event PropertyChangedEventHandler PropertyChanged;
        public bool IsDirty => DirtyProperties.Count > 0;
        public List<string> DirtyProperties;
        public BaseEntity(World world = null)
        {
            DirtyProperties = new List<string>();
            PropertyChanged = null;
            Age = 0;
            if (world == null)
                world = World.Overworld;
            Effects = EntityEffect.NONE;
            Air = 300;
            Transform = new Transform(world.DimensionID);
            CustomName = new ChatMessage();
            Velocity = new Vector3F(0f, 0f, 0f);
            IsCustomNameVisible = false;
            world.AddEntity(this);
            UUID = new Guid();
            PropertyChanged += this.BaseEntity_PropertyChanged;
        }

        internal BaseEntity OldMe;

        public void MakeDirty()
        {
            if (OldMe == null)
                DirtyProperties = GetType().GetProperties().Select(x => x.Name).ToList();

            else
            {
                var f2 = typeof(MinecraftMetadata).GetMethod("C", BindingFlags.Static | BindingFlags.Public);
                foreach (var v in GetType().GetProperties())
                {
                    var at = v.GetCustomAttributes(typeof(EntityMetadataAttribute), true).Cast<EntityMetadataAttribute>().FirstOrDefault();
                    if (at == null)
                        continue;

                    var oldVal = v.GetValue(OldMe, null);
                    var val = v.GetValue(this, null);
                    var v2 = f2.MakeGenericMethod(at.Type).Invoke(null, new object[] { val });
                    var v3 = f2.MakeGenericMethod(at.Type).Invoke(null, new object[] { oldVal });
                    if (!v3.Equals(v2))
                        DirtyProperties.Add(v.Name);
                }
            }
            OldMe = this.DeepClone();
        }


        public Metadata GetMetaData(bool all = false)
        {
            Dictionary<int, Metadata.MetadataInfo> v2 = new Dictionary<int, Metadata.MetadataInfo>();
            var t = GetType();
            var t2 = typeof(EntityMetadataAttribute);
            List<string> array;
            if (!all)
                array = DirtyProperties;
            else
                array = GetType().GetProperties().Select(x => x.Name).ToList();
            foreach (var v in array.ToArray())
            {
                try
                {
                    var prop = t.GetProperty(v);
                    //is this really needed?
                    var t3 = prop.GetCustomAttributes(typeof(EntityMetadataAttribute), true).Cast<EntityMetadataAttribute>().FirstOrDefault();
                    if (t3 == null)
                        continue;
                    var val = prop.GetValue(this, null);
                    v2.Add((int)t3.Index, new Metadata.MetadataInfo()
                    {
                        Type = t3.Type,
                        value = val
                    });
                }
                catch { /* Ignore */ }
            }
            DirtyProperties = new List<string>();
            return new Metadata() { Infos = v2 };
        }

        private void BaseEntity_PropertyChanged(Object sender, PropertyChangedEventArgs e)
        {
            DirtyProperties.Add(e.PropertyName);
        }

        public override string ToString()
        {
            return $"{Id} ({EntityId})";
        }

        public static void SummonPacket(BaseEntity entity, MinecraftServer server, Predicate<NetUser> pr)
        {
            switch (entity.SpawnMethode)
            {
                case SpawnMethodes.Mob:
                    break;
                case SpawnMethodes.Object:
                    server.SendToAll(new SpawnObjectPacket(null)
                    {
                        entity = entity
                    }, x => pr(x));
                    server.SendToAll(new UpdateEntityMetadataPacket(null)
                    {
                        entity = entity
                    }, x => pr(x));
                    break;
                case SpawnMethodes.Spezial:
                    break;
            }
            Console.WriteLine("Summoned " + entity.ToString());
        }

        public static void SummonPacket(BaseEntity entity, MinecraftClient client)
        {
            switch (entity.SpawnMethode)
            {
                case SpawnMethodes.Mob:
                    break;
                case SpawnMethodes.Object:
                    client.Send(new SpawnObjectPacket(client)
                    {
                        entity = entity
                    });
                    /*server.SendToAll(new UpdateEntityMetadataPacket(null)
                    {
                        entity = entity
                    }, x => pr(x));*/
                    break;
                case SpawnMethodes.Spezial:
                    break;
            }
        }

        public bool Equals(BaseEntity other)
        {
            return this.EntityId == other.EntityId;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            var other = obj as BaseEntity;
            return other != null && Equals(other);
        }

        public override int GetHashCode()
        {
            return EntityId.GetHashCode();
        }

        public static bool operator ==(BaseEntity left, BaseEntity right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BaseEntity left, BaseEntity right)
        {
            return !Equals(left, right);
        }

        public virtual void PreTick()
        {
        }
        public virtual void PostTick()
        {
            this.LastTransform = this.Transform;
            if (Age == long.MaxValue)
            {
                Age = long.MinValue;
                Console.WriteLine("WTF, THE AGE JUST HIT THE MAX NUM");
            }
            Age++;

            MakeDirty();
        }

        public static BaseEntity Summon(String id, Vector3D position)
        {
            Initialize();

            var v = EntityTypes[id];
            var v2 = (BaseEntity)Activator.CreateInstance(v);
            v2.Transform.Position = position;
            return v2;
        }

        static BaseEntity()
        {
            Initialize();
        }
        public static void Initialize()
        {
            //TODO: Aaah, the performance
            if (Initialized) return;
            Initialized = true;
            var t = typeof(BaseEntity);                       //These are quite some
            var t2 = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsSubclassOf(t));
            foreach (var v in t2.Where(v => !v.IsAbstract))
            {
                var t3 = (BaseEntity)Activator.CreateInstance(v);
                RegisterEntityType(t3);
            }
        }

        public static void RegisterEntityType(BaseEntity t3)
        {
            EntityTypes.Add(t3.Id, t3.GetType()); // Cool, Coool
            t3.Dispose();
        }

        public virtual void Dispose()
        {
            World.Entities.Remove(this);
            Console.WriteLine($"Destroyed {this.ToString()}");
        }
    }
}