using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PessoaBusiness
    {
        public bool InsereClienteUsuario(PessoaEntity Cliente)
        {
            try
            {
                Cliente.Usuario.Id = new UsuarioData().InsereUsuario(Cliente.Usuario);
                Cliente.Id = new PessoaData().InsereCliente(Cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}
