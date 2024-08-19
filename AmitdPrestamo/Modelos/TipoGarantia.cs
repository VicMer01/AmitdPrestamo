using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmitdPres.Modelos
{
    public class TipoGarantia
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        [ForeignKey(nameof(Id))]
        public List<Garantia> TipoGarantias { get; set; }
    }
}
