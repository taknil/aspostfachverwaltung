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
        public static bool UseSQL = DataSettings.Default.UseSql;
        public static string DatabaseFile = DataSettings.Default.XmlFile;

        private static readonly DataContractSerializer _Serializer;

        public static InMeDatabase Current { get; private set; }
        public HashSet<Person> Personen = new HashSet<Person>();
        public HashSet<Panel> Postfaecher = new HashSet<Panel>();
        public List<Paket> Pakete = new List<Paket>();

        static InMeDatabase()
        {
            _Serializer = new DataContractSerializer(typeof(InMeDatabase));
            //RefreshCurrent();
        }
        private InMeDatabase() { }

        public static void AutoSave()
        {
            Timer _Timer = new Timer((s) => { Current.Save(); }, null, 0, 15000);
        }

        public static void RefreshCurrent()
        {
            if (UseSQL)
                LoadSQL();
            else
                LoadIMDB();
        }

        public void Save()
        {
            if (UseSQL)
                CommitToSql(DataSettings.Default.CustomSqlConnection);
            else
                CommitToIMDB(DatabaseFile);
        }

        #region Imdb
        private static void CommitToIMDB(string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None))
                _Serializer.WriteObject(fs, Current);
        }

        private static void LoadIMDB()
        {
            try
            {
                Current = ReadCurrent(DatabaseFile);
            }
            catch (FileNotFoundException)
            {
                Current = new InMeDatabase();
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(DatabaseFile));
            }
        }

        private static InMeDatabase ReadCurrent(string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                return (InMeDatabase)_Serializer.ReadObject(fs);
        }
        #endregion Imdb

        #region Sql
        private static void LoadSQL()
        {
            try
            {
                SQL.Helper sql = new SQL.Helper(DataSettings.Default.CustomSqlConnection);
                Current = new InMeDatabase();
                Current.Pakete = sql.GetTable<Paket>().ToList();
                Current.Personen = new HashSet<Person>(sql.GetTable<Person>());
                Current.Postfaecher = new HashSet<Panel>(sql.GetTable<Panel>());
            }
            catch (System.Data.SqlClient.SqlException e)
            {
#if DEBUG
                System.Windows.Forms.MessageBox.Show("Fallback zu nicht relationale Datenbank\r\n " + e, "Fehlerhafte Datenbank", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
#endif
                UseSQL = false;
                RefreshCurrent();
            }
        }
        private static void CommitToSql(string connectionString)
        {
            SQL.Helper sql = new SQL.Helper(connectionString);
            if (sql.DatabaseExists())
            {
                sql.UpdateAll<Paket>(IMDB.InMeDatabase.Current.Pakete.DistinctBy(p => p.Id));
                sql.UpdateAll<Person>(IMDB.InMeDatabase.Current.Personen.DistinctBy(p => p.Id));
                sql.UpdateAll<Panel>(IMDB.InMeDatabase.Current.Postfaecher.DistinctBy(p => p.Id));
            }
            else
            {
                sql.AddAll<Paket>(IMDB.InMeDatabase.Current.Pakete.DistinctBy(p => p.Id));
                sql.AddAll<Person>(IMDB.InMeDatabase.Current.Personen.DistinctBy(p => p.Id));
                sql.AddAll<Panel>(IMDB.InMeDatabase.Current.Postfaecher.DistinctBy(p => p.Id));
            }
            sql.Save();
        }
        #endregion Sql
    }
}
