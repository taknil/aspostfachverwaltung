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
        public static long NextID 
        { 
            get 
            { 
                return BackendWrapper.GenerateNextPacketID(PaVe.Program.Database.Pakete.LastOrDefault()); 
            } 
        }

        private static long GenerateNextPacketID(Paket packet)
        {
            return packet.Id + 1;
        }

        public static IEnumerable<Paket> CreatePacket(IEnumerable<Paket> packets)
        {
            AddToDatabase(packets);
            return packets;
        }

        public static Paket CreatePacket(long id, string name, string panel)
        {
            Paket packet= new Paket() 
            {
                Id = id,
                Person = new Person(name),
                Panel = new Panel(panel),
            };
            AddToDatabase(packet);
            return packet;
        }

        public static Person CreatePerson(string name)
        {
            Person person = new Person(name);
            AddToDatabase(person);
            return person;
        }
        public static Panel CreatePostfach(string name)
        {
            Panel postfach = new Panel(name);
            AddToDatabase(postfach);
            return postfach;
        }
        public static void DeletePackets(long packetID)
        {
            DeleteFromDatabase(p => p.Id == packetID && p.Panel != null);
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

        private static void AddToDatabase(Person person)
        {
            PaVe.Program.Database.Personen.Add(person);
        }

        private static void AddToDatabase(Panel postfach)
        {
            PaVe.Program.Database.Postfaecher.Add(postfach);
        }

        private static void AddToDatabase(Paket packet)
        {
            PaVe.Program.Database.Personen.Add(packet.Person);
            PaVe.Program.Database.Postfaecher.Add(packet.Panel);
            PaVe.Program.Database.Pakete.Add(packet);
        }

        private static void DeleteFromDatabase(Predicate<Person> elements)
        {
            PaVe.Program.Database.Personen.RemoveWhere(elements);
        }

        private static void DeleteFromDatabase(Predicate<Panel> elements)
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
