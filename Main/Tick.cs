using SharpenedMinecraft.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Linq;
using SharpenedMinecraft.Packets;
using SharpenedMinecraft.Entities;
using SharpenedMinecraft.NetLib;
using static SharpenedMinecraft.Entities.BaseEntity;

namespace SharpenedMinecraft
{
    public static class Tick
    {
        public const double TicksPerSecond = 20;
        public static event Action OnTick;
        private static Timer Timer { get; set; }
        private static bool TickLocked = false;
        public static void StartTick()
        {
            Timer = new Timer();
            Timer.Interval = TimeSpan.FromSeconds(1 / TicksPerSecond).TotalMilliseconds;
            Timer.Elapsed += Timer_Elapsed;

            //OnTick += PlayerVisibility;
            OnTick += EntityMovement;

            Timer.Start();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (!TickLocked)
            {
                //TickLocked = true;
                OnTick();
                TickLocked = false;
            }
        }

        static void PlayerVisibility()
        {
            lock(World.Entities)
            World.Players.ForEach(x =>
            {
                if (x.LastTransform != null)
                World.Players.ForEach(x2 =>
                {
                    if (x2.LastTransform != null
                        && x != x2)
                    {
                        if ((x.Transform.Position.LengthSqr - x2.Transform.Position.LengthSqr <= x.ViewDistance
                        && x.LastTransform.Position.LengthSqr - x2.LastTransform.Position.LengthSqr > Math.Sqrt(x.ViewDistance))
                        || x.Age == TicksPerSecond)
                        {
                            x.Client.Send(new SpawnPlayerPacket(x.Client)
                            {
                                player = x2
                            });
                        }
                    }
                });
            });
        }

        static void EntityMovement()
        {
            foreach(var entity in World.Entities.ToArray())
            {
                entity.PreTick();
                ProcessEntity(entity);
                entity.PostTick();
            }
        }

        private static void ProcessEntity(BaseEntity entity)
        {
            if (World.Players.Where(x => x.Client?.state == Types.Enums.State.Play).ToList().Count <= 0) //TODO: Offline Ticks
                return;
            var server = World.Players[0].Client.Server;
            if (server == null)
                return;

            if (!entity.Ticking)
                return;
            Predicate<NetUser> pr = x =>
            {
                var v = (MinecraftClient)x;
                return v.Player != entity && v.state == Types.Enums.State.Play;
            };
            var Isplayer = entity is Player;
            if (World.Players.Count == 0)
                return;
            if (entity.Age < 5)
                return;
            if (entity.LastTransform == null)
                return;
            if (Isplayer && entity.Age <= TicksPerSecond + 1)
                return;
            if (!entity.Broadcasted)
            {
                BaseEntity.SummonPacket(entity, server, pr);
                entity.Broadcasted = true;
                return;
            }
            if (entity.SpawnMethode != SpawnMethodes.Spezial)
            {
                if (entity.IsDirty)
                {
                    server.SendToAll(new UpdateEntityMetadataPacket(null)
                    {
                        entity = entity
                    }, x => pr(x));
                }
            }

            //First find out what has been done.
            entity.Transform.Position += entity.Velocity;
            bool HasRotated = entity.LastTransform.Rotation != entity.Transform.Rotation;
            bool HasMoved = entity.LastTransform.Position != entity.Transform.Position;
            bool HasTeleported = false;
            if (HasRotated)
            {
                server.SendToAll(new EntityHeadLookPacket(null)
                {
                    Entity = entity
                }, x => pr(x));
            }
            if (HasMoved)
            {
                var dis = entity.LastTransform.Position.Length - entity.Transform.Position.Length;
                if (dis < -8 || 8 > dis)
                {
                    HasMoved = false;
                    HasTeleported = true;
                }
            }

            if (HasRotated && HasMoved)
            {
                //Send Entity Position & Rotation
                server.SendToAll(new EntityRelativeMoveAndRotationPacket(null)
                {
                    Entity = entity
                }, x => pr(x));
            }
            else
            {
                if (HasRotated)
                {
                    //Send Entity Rotation
                    server.SendToAll(new EntityLookPacket(null)
                    {
                        Entity = entity
                    }, x => pr(x));
                }
                else if (HasMoved)
                {
                    //Send Entity Position
                    server.SendToAll(new EntityRelativeMovePacket(null)
                    {
                        Entity = entity
                    }, x => pr(x));
                }
                else
                {
                    server.SendToAll(new EntityPresentPacket(null)
                    {
                        Entity = entity
                    }, x => pr(x));
                }
            }

            if (HasTeleported)
            {
                //Send TP Packet
                server.SendToAll(new EntityTeleportPacket(null)
                {
                    Entity = entity
                }, x => pr(x));
            }
        }
    }
}
