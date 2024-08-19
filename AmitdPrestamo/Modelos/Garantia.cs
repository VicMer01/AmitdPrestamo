using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmitdPres.Modelos
{
    public class Garantia
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey(nameof(Id))]
        public int TipoGarantiaId { get; set; }
    }
}
