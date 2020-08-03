using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapaDatos.Entidades
{
    public class Idioma
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TDI_ID { get; set; }

        [StringLength(70)]
        public string TDI_DESCRIPCION { get; set; }
    }
}
