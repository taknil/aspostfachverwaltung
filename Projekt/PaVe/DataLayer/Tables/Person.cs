using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaVe.DataLayer.Tables
{
    [Serializable]
    public class DeliverPerson
    {
        public string Name;

        public DeliverPerson(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }
}
