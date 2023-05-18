using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace WindowsFormsApplication1.Models
{
    class TurDbContext : DataContext
    {
        public TurDbContext(string fileOrServerConnection) :
            base(fileOrServerConnection)
        { 
            
        }

        public Table<Tur> Turists { get; set; }

    }
}
