using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization;


namespace KatPC.Api.Model
{
    [Table("KatPCDatos")]
    public class KatPCDatos
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int IdEquipo { get; set; }
                
        public string Modelo { get; set; }

        public string Numserie { get; set; }

        public string Procesador { get; set; }

        public string FrecueProc { get; set; }

        public string Ram { get; set; }
        
        public string Tiporam { get; set; }

        public string Almacenamiento { get; set; }

        public string Tipoalmacen { get; set; }

        public string Pantalla { get; set; }

        public string Frecuepantalla { get; set; }

        public string Graficos { get; set; }

        public string Tipograficos { get; set; }

    }
}
