using System.ComponentModel.DataAnnotations;

namespace AmitdPres.Modelos
{
    public class Documentos
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public byte[] Contenido { get; set; }
    }
}
