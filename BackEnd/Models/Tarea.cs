using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Tarea
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "Varchar(100)")]
        public string Nombre { get; set; }
        public bool Finalizada { get; set; }
    }
}
