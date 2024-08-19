using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmitdPres.Modelos
{
    public class Pagos
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Id))]
        public int IdPrestamo { get; set; }
        [ForeignKey(nameof(Id))]
        public int IdCliente { get; set; }
        public DateTime FechaPago { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal MontoPago { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Interes { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Capital { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Mora { get; set; }
    }
}
