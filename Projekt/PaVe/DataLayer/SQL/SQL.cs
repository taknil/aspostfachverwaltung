using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using PaVe.DataLayer.IMDB;
using System.Data;
using System.Data.OleDb;
using PaVe.DataLayer.Tables;
using System.IO;


namespace PaVe.DataLayer.SQL
{
    class Helper : DataContext
    {
        public static string ConnectionString 
        {
            get
            {
                if(string.IsNullOrEmpty(DataSettings.Default.CustomSqlConnection))
                    return BuildDefaultConnection(DataSettings.Default.Connection, DataSettings.Default.MdfFile);

                if (DataSettings.Default.CustomSqlConnection.Contains("{0}"))
                    return BuildDefaultConnection(DataSettings.Default.CustomSqlConnection, DataSettings.Default.MdfFile);
                else
                    return DataSettings.Default.CustomSqlConnection;
            }
            set
            {
                DataSettings.Default.CustomSqlConnection = value;
            }
        }

#pragma warning disable 649 //Dem Feld "..." wird nie etwas zugewiesen, und es hat immer seinen Standardwert von "null".
        public Table<Person> Person;
        public Table<Paket> Paket;
        public Table<Panel> Panel;
#pragma warning restore 649 //Dem Feld "..." wird nie etwas zugewiesen, und es hat immer seinen Standardwert von "null".

        public Helper(string connectionString)
            : base(ConnectionString)
        {
            if (string.IsNullOrEmpty(connectionString) == false)
                ConnectionString = BuildDefaultConnection(connectionString, DataSettings.Default.MdfFile);
        }

        private static string BuildDefaultConnection(string connection, string file)
        {
            string assembly = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = Directory.GetParent(assembly).ToString();
            string mdfPath = Path.Combine(directory, file);
            return string.Format(connection, mdfPath);
        }

        public void Add<T>(T record) where T : class
        {
            Table<T> tableData = this.GetTable<T>();
            tableData.InsertOnSubmit(record);
        }
        internal void AddAll<T>(IEnumerable<T> records) where T : class
        {
            Table<T> tableData = this.GetTable<T>();
            tableData.InsertAllOnSubmit(records);
        }

        public void Update<T>(T record) where T : class
        {
            Table<T> tableData = this.GetTable<T>();
            tableData.Attach(record);
        }

        public void UpdateAll<T>(IEnumerable<T> records) where T : class
        {
            Table<T> tableData = this.GetTable<T>();
            tableData.AttachAll(records);
        }

        public void Remove<T>(T record) where T : class
        {
            Table<T> tableData = this.GetTable<T>();
            var deleteRecord = tableData.SingleOrDefault(r => r == record);
            if (deleteRecord != null)
                tableData.DeleteOnSubmit(deleteRecord);
        }

        public void RemoveAll<T>(IEnumerable<T> records) where T : class
        {
            Table<T> tableData = this.GetTable<T>();
            var deleteRecords = tableData.Where(r => r == records);
            if (deleteRecords != null)
                tableData.DeleteAllOnSubmit(deleteRecords);
        }

        public void Save()
        {
            this.SubmitChanges();
        }
    } 
}
