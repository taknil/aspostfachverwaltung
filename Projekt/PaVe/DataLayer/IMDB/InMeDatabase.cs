using PaVe.DataLayer.Tables;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using PaVe.Utils;

namespace PaVe.DataLayer.IMDB
{
    [Serializable]
    [Database]
    sealed class InMeDatabase
    {
        public static bool UseSQL = false;

        public const string DatabaseFile = @"DataLayer\IMDB\Database.xml";
        private static readonly DataContractSerializer _Serializer;

        public static InMeDatabase Current { get; private set; }
        public HashSet<DeliverPerson> Personen = new HashSet<DeliverPerson>();
        public HashSet<PostPanel> Postfaecher = new HashSet<PostPanel>();
        public List<Paket> Pakete = new List<Paket>();

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
            catch(DirectoryNotFoundException)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(DatabaseFile));
            }
        }

        public static InMeDatabase ReadCurrent(string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                return (InMeDatabase)_Serializer.ReadObject(fs);
        }

        public void Save()
        {
            if(UseSQL)
            {
                SQL.Helper sql = new SQL.Helper(SQL.Helper.DatabaseFile);
                sql.SubmitChanges();
            }
            else
            {
                Console.WriteLine("Trying to Save at {0}", DateTime.Now);
                SaveCurrent(DatabaseFile);
            }
        }
    }
}
