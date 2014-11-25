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
        public static string NextID 
        { 
            get 
            { 
                return BackendWrapper.GenerateNextPacketID(PaVe.Program.Database.Packet.LastOrDefault()); 
            } 
        }

        private static string GenerateNextPacketID(Paket packet)
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
            AddToDatabase(packets);
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
            AddToDatabase(packet);
            return packet;
        }

        public static void DeletePackets(string packetID)
        {
            DeleteFromDatabase(p => p.ID == packetID);
        }

        public static void DeletePanels(string panelName)
        {
            DeleteFromDatabase(p => p.Panel.Name == panelName); //Delete Packets=>Panels too
        }

        #region Database
        private static void AddToDatabase(IEnumerable<Paket> packet)
        {
            PaVe.Program.Database.Packet.AddRange(packet);
        }

        private static void AddToDatabase(Paket packet)
        {
            PaVe.Program.Database.Packet.Add(packet);
        }
        private static void DeleteFromDatabase(Predicate<Paket> elements)
        {
            PaVe.Program.Database.Packet.RemoveAll(elements);
        }
        #endregion Database
    }
}
