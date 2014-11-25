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


namespace PaVe.DataLayer.SQL
{
    class Helper : DataContext
    {
        public static string DatabaseFile = @"DataLayer\SQL\Database.mdf";

#pragma warning disable 649 //Dem Feld "..." wird nie etwas zugewiesen, und es hat immer seinen Standardwert von "null".
        public Table<DeliverPerson> Persons;
        public Table<Paket> Packets;
#pragma warning restore 649 //Dem Feld "..." wird nie etwas zugewiesen, und es hat immer seinen Standardwert von "null".

        //private static IDbConnection MakeConnection(string file)
        //{
        //    return new OleDbConnection(string.Format(ConnectionString, file));
        //}
        //private static IDbConnection MakeConnection(string file)

        public Helper(string file)
            : base(file)
        {
        }
    } 
}
