using System.ComponentModel.DataAnnotations;

namespace AmitdPres.Modelos
{

    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaIngreso { get; set; } = DateTime.Now;
        public string Direccion { get; set; }
        public string FotoCedulaFrente { get; set; } = string.Empty;
        public string FotoCedulaAtras { get; set; } = string.Empty;
        public string FotoCliente { get; set; } = string.Empty;
        public string Apodo { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ocupacion { get; set; }
        public string Sexo { get; set; }
    }

}
