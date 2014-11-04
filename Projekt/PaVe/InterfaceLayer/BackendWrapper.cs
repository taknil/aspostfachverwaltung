using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PaVe.InterfaceLayer.GUI;
using PaVe.InterfaceLayer.CLI;
using PaVe.DataLayer.Tables;

namespace PaVe.InterfaceLayer
{
    static class BackendWrapper
    {
        public static string GenerateNextPacketID(Paket packet)
        {
            UInt64 newid;
            try
            {
                UInt64 id = UInt64.Parse(packet.ID);
                newid = id + 1;
            }
            catch
            {
                newid = 1;
            }
            return newid.ToString();
        }

        public static IEnumerable<Paket> CreatePacket(IEnumerable<Paket> packets)
        {
            UpdateDatabase(packets);
            return packets;
        }

        public static Paket CreatePacket(string id, string name, string panel)
        {
            Paket packet= new Paket() 
            {
                ID = id,
                Person = new DeliverPerson(name),
                Panel = new PostPanel(panel),
            };
            UpdateDatabase(packet);
            return packet;
        }

        private static void UpdateDatabase(IEnumerable<Paket> packet)
        {
            PaVe.Program.Database.Packet.AddRange(packet);
        }

        private static void UpdateDatabase(Paket packet)
        {
            PaVe.Program.Database.Packet.Add(packet);
        }
    }

    static class GUIBackend
    {
        public static void AddPanel(PostPanel panel)
        {
        }
    }

    static class CLIBackend
    {
        public static void AddPanel(PostPanel panel)
        {
        }
    }
}
