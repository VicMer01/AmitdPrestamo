using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmitdPres.Modelos
{
    public class TipoPrestamo
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal taza { get; set; }
    }
}

