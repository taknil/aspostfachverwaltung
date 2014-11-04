using PaVe.DataLayer.Tables;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;

namespace PaVe.DataLayer.IMDB
{
    [Serializable]
    sealed class InMeDatabase
    {
        public const string DatabaseFile = "database.xml";
        private static readonly DataContractSerializer _Serializer;

        public static InMeDatabase Current { get; private set; }
        public List<DeliverPerson> User = new List<DeliverPerson>();
        public List<Paket> Packet = new List<Paket>();
        public List<Log> Log = new List<Log>();

        static InMeDatabase()
        {
            _Serializer = new DataContractSerializer(typeof(InMeDatabase));
            RefreshCurrent();
        }
        private InMeDatabase() { }

        public static void AutoSave()
        {
            Timer _Timer = new Timer((s) => { Current.Save(); }, null, 0, 15000);
        }

        public static void SaveCurrent(string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None))
                _Serializer.WriteObject(fs, Current);
        }

        public static void RefreshCurrent()
        {
            try
            {
                Current = ReadCurrent(DatabaseFile);
            }
            catch (FileNotFoundException)
            {
                Current = new InMeDatabase();
            }
        }

        public static InMeDatabase ReadCurrent(string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                return (InMeDatabase)_Serializer.ReadObject(fs);
        }

        public void Save()
        {
            Console.WriteLine("Trying to Save at {0}", DateTime.Now);
            SaveCurrent(DatabaseFile);
        }
    }
}
