using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaVe.DataLayer.Tables
{
    [Serializable]
    [Table(Name = "PostPanel")]
    public class PostPanel
    {
        [Column(IsPrimaryKey=true)]
        public string Name;
        [Column]
        public bool IsEmpty;

        public PostPanel(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
