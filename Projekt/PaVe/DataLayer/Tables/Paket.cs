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
    [Table(Name = "Paket")]
    public class Paket
    {
        [Column(IsPrimaryKey = true)]
        public string ID;
        [Column]
        public DeliverPerson Person;
        [Association(Name = "FK_PostPanel", ThisKey = "Panel", IsForeignKey = true)]
        public PostPanel Panel;
        [Column]
        public DateTime PlaceDate;
        [Column]
        public DateTime PostDate;

        public Paket() : base()
        {
            PlaceDate = DateTime.Now;
        }

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3}", ID, Panel, Person, PlaceDate);
        }
    }
}
