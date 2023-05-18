using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.OleDb;

namespace WindowsFormsApplication1.Models
{
    [Table(Name = "Туры")]
    class Tur
    {
        [Column(Name = "Код", IsPrimaryKey = true, IsDbGenerated = true)]

        public int Id { get; set; }

        [Column(Name = "Название")]
        public string Title { get; set; }

        [Column(Name = "Цена")]
        public string Zena { get; set; }

        [Column(Name = "Информация")]
        public string Info { get; set; }
    }
}
