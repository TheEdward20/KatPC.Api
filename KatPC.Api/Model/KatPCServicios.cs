using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KatPC.Api.Model
{
    [Table("KatPCServicios")]
    public class KatPCServicios
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdServicio { get; set; }
        public int Folio { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public DateTime Fechaderecepcion { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public bool Enciende { get; set; }
        public bool Wifi { get; set; }
        public bool Puertosusb { get; set; }
        public bool Bluetooth { get; set; }
        public bool Bocinas { get; set; }
        public bool Teclado { get; set; }
        public bool Pantalla { get; set; }
        public bool Microfono { get; set; }
        public bool Touchpad { get; set; }
        public bool Webcam { get; set; }

        public string Observaciones { get; set; }
        public string Pass { get; set; }

        public string Descripciondiagnostico { get; set; }
        public decimal Costo { get; set; }


    }
}
