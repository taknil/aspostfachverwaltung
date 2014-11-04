using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaVe.DataLayer.Tables
{
    [Serializable]
    public class PostPanel
    {
        public string Name;
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
