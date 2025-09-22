using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
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

        public string Usooficina   { get; set; }

        public string Maximaexigencia { get; set; }

        public string Vidautil { get; set; }

        public string Arranque { get; set; }

        public string Videoconfe {  get; set; }

        public string Navegacion { get; set; }

        public string Excelpprograma { get; set; }

        public string Escrituradocum { get; set; }

        public string Edicionfotoscad { get; set; }

        public string Edicionvideo { get; set; }

        public string videojuego { get; set; }

        public string Tecladoilumi { get; set; }

        public string Windowshello { get; set; }

        public string Puertosusb { get; set; }

        public string Salidavideo { get; set; }

        public string Wifi { get; set; }

        public string Touchpad { get; set; }

        public string Bluetooth { get; set; }

        public string Cd { get; set; }

        public string Puertoauxiliar { get; set; }

        public string Bocinas { get; set; }

        public string Pantllatactil { get; set; }  

        public string Webcam { get; set; }

        public string Pantallad { get; set; }

        public string Botones { get; set; }

        public string Grado { get; set; }

        public string Condicionfisica { get; set; }

        public string Interpretacion { get; set; }

        public string Encargado { get; set; }

        public string Fechaprueba { get; set; }

    }
}
