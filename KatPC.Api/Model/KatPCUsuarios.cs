using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KatPC.Api.Model
{
    [Table("KatPCUsuarios")]
    public class KatPCUsuarios
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdUsuario { get; set; }

        public string Nombre { get; set; }
        public string Passwor { get; set; }


    }
}
