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
                return BackendWrapper.GenerateNextPacketID(PaVe.Program.Database.Pakete.LastOrDefault()); 
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

        public static DeliverPerson CreatePerson(string name)
        {
            DeliverPerson person = new DeliverPerson(name);
            AddToDatabase(person);
            return person;
        }
        public static PostPanel CreatePostfach(string name)
        {
            PostPanel postfach = new PostPanel(name);
            AddToDatabase(postfach);
            return postfach;
        }
        public static void DeletePackets(string packetID)
        {
            DeleteFromDatabase(p => p.ID == packetID);
        }

        public static void DeletePerson(string personName)
        {
            DeleteFromDatabase(u => u.FullName == personName);
        }
        public static void DeletePostfach(string postfachName)
        {
            DeleteFromDatabase(u => u.Name == postfachName);
        }
        public static void DeletePanels(string panelName)
        {
            DeleteFromDatabase(p => p.Panel.Name == panelName); //Delete zu Panels die Packets auch
        }

        #region Database
        private static void AddToDatabase(IEnumerable<Paket> packet)
        {
            PaVe.Program.Database.Pakete.AddRange(packet);
        }

        private static void AddToDatabase(DeliverPerson person)
        {
            PaVe.Program.Database.Personen.Add(person);
        }

        private static void AddToDatabase(PostPanel postfach)
        {
            PaVe.Program.Database.Postfaecher.Add(postfach);
        }

        private static void AddToDatabase(Paket packet)
        {
            PaVe.Program.Database.Personen.Add(packet.Person);
            PaVe.Program.Database.Postfaecher.Add(packet.Panel);
            PaVe.Program.Database.Pakete.Add(packet);
        }

        private static void DeleteFromDatabase(Predicate<DeliverPerson> elements)
        {
            PaVe.Program.Database.Personen.RemoveWhere(elements);
        }

        private static void DeleteFromDatabase(Predicate<PostPanel> elements)
        {
            PaVe.Program.Database.Postfaecher.RemoveWhere(elements);
        }

        private static void DeleteFromDatabase(Predicate<Paket> elements)
        {
            PaVe.Program.Database.Pakete.RemoveAll(elements);
        }
        #endregion Database
    }
}
