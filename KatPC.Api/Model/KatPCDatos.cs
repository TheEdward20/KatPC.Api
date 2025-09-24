using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
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
        public string Usooficina { get; set; }
        public string Maximaexigencia { get; set; }
        public string Vidautil { get; set; }
        public string Arranque { get; set; }
        public string Videoconfe { get; set; }
        public string Navegacion { get; set; }
        public string Excelprograma { get; set; }
        public string Escrituradocum { get; set; }
        public string Edicionfotoscad { get; set; }
        public string Edicionvideo { get; set; }
        public string Videojuego { get; set; }
        public bool Tecladoilumi { get; set; }
        public bool Windowshello { get; set; }
        public bool Puertosusb { get; set; }
        public bool Salidavideo { get; set; }
        public bool Wifi { get; set; }
        public bool Puertotipoc { get; set; }
        public bool Microfono { get; set; }
        public bool Touchpad { get; set; }
        public bool Bluetooth { get; set; }
        public bool Cd { get; set; }
        public bool Puertoauxiliar { get; set; }
        public bool Bocinas { get; set; }
        public bool Pantallatactil { get; set; }
        public bool Webcam { get; set; }
        public bool Pantallad { get; set; }
        public bool Botones { get; set; }
        public string Grado { get; set; }
        public string Condicionfisica { get; set; }
        public string Interpretacion { get; set; }
        public string Encargado { get; set; }
        public DateTime Fechaprueba { get; set; }


    }
}
