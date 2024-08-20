using AmitdPres.Modelos;
using AmitdPrestamo.Data;

namespace AmitdPrestamo.BLL
{
    public class ClientesBLL
    {
        private readonly ApplicationDbContext _contexto;

        public ClientesBLL(ApplicationDbContext context)
        {
            _contexto = context;
        }

        public bool Insertar(Cliente cliente)
        {
            _contexto.Add(cliente);
            return _contexto.SaveChanges() > 0;
        }
    }
}
