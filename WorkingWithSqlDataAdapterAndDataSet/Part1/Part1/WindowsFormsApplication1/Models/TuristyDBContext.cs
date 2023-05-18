using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace WindowsFormsApplication1.Models
{
    class TuristyDBContext: DataContext
    {
        public TuristyDBContext(string fileOrServerConnection):
            base(fileOrServerConnection)
        { 
            
        }

        public Table<Turist> Turists { get; set; }


    }
}
