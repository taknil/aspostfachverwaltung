using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaVe.DataLayer.Tables
{
    [Serializable]
    [Table(Name = "Person")]
    public class DeliverPerson
    {
        [Column]
        public string FullName;

        public DeliverPerson(string name)
        {
            FullName = name;
        }

        public override string ToString()
        {
            return string.Format("{0}", FullName);
        }
    }
}
