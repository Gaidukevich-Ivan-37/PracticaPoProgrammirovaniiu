using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.OleDb;

namespace WindowsFormsApplication1.Models
{
    [Table(Name="Туристы")]
    class Turist
    {
        [Column(Name = "Код", IsPrimaryKey = true, IsDbGenerated = true)]

        public int Id { get; set; }

        [Column(Name = "Имя")]
        public string FirstName { get; set; }

        [Column(Name = "Отчество")]
        public string MidleName { get; set; }

        [Column(Name = "Фамилия")]
        public string LastName { get; set; }

    }
}
