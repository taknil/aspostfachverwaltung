using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaVe.DataLayer.Tables
{
    [Serializable]
    [Table(Name = "dbo.Paket")]
    public class Paket
    {
        [Column(Name = "Id", IsPrimaryKey = true, DbType = "BigInt NOT NULL")]
        public long Id;
        //[Association(Name = "FK_DeliverPerson", ThisKey = "ID", IsForeignKey = true)]

        private EntityRef<Person> _Person;
        [Association(Storage = "_Person", ThisKey = "Id", IsForeignKey = true)]
        public Person Person
        {
            get { return _Person.Entity; }
            set
            {
                _Person.Entity = value;
                Id = value.Id;
            }
        }

        //[Column(Name = "Person", DbType = "sql_variant", CanBeNull = false)]
        //public Person Person;

        //[Association(Name = "FK_PostPanel", ThisKey = "ID", IsForeignKey = true)]
        private EntityRef<Panel> _Panel;
        [Association(Storage = "_Panel", ThisKey = "Id", IsForeignKey = true)]
        public Panel Panel
        {
            get { return _Panel.Entity; }
            set
            {
                _Panel.Entity = value;
                Id = value.Id;
            }
        }
        //[Column(Name = "Panel", DbType = "sql_variant", CanBeNull = true)]
        //public Panel Panel;
        [Column(Name = "PlaceDate", DbType = "DateTime")]
        public DateTime PlaceDate;
        [Column(Name = "PostDate", DbType = "Datetime")]
        public DateTime PostDate;

        public Paket()
        {
            PlaceDate = DateTime.Now;
            PostDate = DateTime.MaxValue;
        }

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3}", Id, Panel, Person, PlaceDate);
        }
    }
}
