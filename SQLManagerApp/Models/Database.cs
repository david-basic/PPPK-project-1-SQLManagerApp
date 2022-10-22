using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLManagerApp.Models
{
    internal class Database
    {
        public string Name { get; set; }

        public override string ToString() => Name;
    }
}
