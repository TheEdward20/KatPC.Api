using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KatPC.Api.Model
{
    public class especifiDATA
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [MaxLength(50)]

        public string modelo { get; set; }
        [Required]
        [MaxLength(50)]

        public string numserie { get; set; }
        [Required]
        [MaxLength(50)]

        public string procesador { get; set; }
        [Required]
        [MaxLength(50)]

        public string ram { get; set; }
        [Required]
        [MaxLength(10)]

        public string almacenamiento { get; set; }
        [Required]
        [MaxLength(10)]

        public string pantalla { get; set; }
        [Required]
        [MaxLength(10)]

        public string graficos { get; set; }
        [Required]
        [MaxLength(50)]

        public string frecuencia { get; set; }
        [Required]
        [MaxLength(20)]

        public string tipo { get; set; }
        [Required]
        [MaxLength(20)]

        public string ssd { get; set; }
        [Required]
        [MaxLength(20)]

        public string frecuenciapulgada { get; set; }
       

        public string tarjeta { get; set; }
       

    }
}
