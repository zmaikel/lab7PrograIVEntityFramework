using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapaDatos.Entidades
{
    public class Prestamo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TGP_ID { get; set; }

        
        public int TGP_PAIS_ID { get; set; }

        
        public int TGP_HABITANTES { get; set; }

        
        public int TGP_IDIOMA_ID { get; set; }

        
        public decimal TGP_PIB { get; set; }

     
        public int TGP_SUPERFICIE { get; set; }


        public char TGP_RIESGO_SEGURIDAD { get; set; }


        public bool TGP_ABLE { get; set; } //Disponible a prestamo


    }
}
