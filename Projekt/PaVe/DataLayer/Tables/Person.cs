using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaVe.DataLayer.Tables
{
    [Serializable]
    [Table(Name = "dbo.Person")]
    public class Person : PaVe.Utils.ClassIdentify
    {
        [Column(Name = "Id", IsPrimaryKey = true, DbType = "BigInt NOT NULL")]
        public long Id;
        [Column(Name = "FullName", DbType = "NVarChar(MAX)")]
        public string FullName;

        public Person(string name)
        {
            FullName = name;
            Id = DateTime.Now.Ticks;
        }

        public Person() { }

        public override string ToString()
        {
            return string.Format("{0}", FullName);
        }
    }
}
