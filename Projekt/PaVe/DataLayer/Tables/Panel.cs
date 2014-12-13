using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaVe.DataLayer.Tables
{
    [Serializable]
    [Table(Name = "dbo.Panel")]
    public class Panel
    {
        [Column(Name = "Id", IsPrimaryKey = true, DbType = "BigInt NOT NULL")]
        public long Id;
        [Column(Name = "Name", DbType = "NVarChar(MAX)")]
        public string Name;
        [Column(Name = "IsEmpty", DbType = "bit")]
        public bool IsEmpty;

        public Panel() { }

        public Panel(string name)
        {
            Name = name;
            Id = DateTime.Now.Ticks;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
