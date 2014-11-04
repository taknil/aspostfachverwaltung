using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaVe.DataLayer.Tables
{
    [Serializable]
    public class Paket
    {
        public string ID;
        public DeliverPerson Person;
        public PostPanel Panel;
        public DateTime PlaceDate;
        public DateTime PostDate;

        public Paket()
        {
            PlaceDate = DateTime.Now;
        }

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3}", ID, Panel, Person, PlaceDate);
        }
    }
}
