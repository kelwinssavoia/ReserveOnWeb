using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class UsuarioBusiness
    {
        public PessoaEntity AutenticarUsuario(UsuarioEntity Usuario)
        {
            PessoaEntity Pessoa = null;
            
            try
            {
                Pessoa = new UsuarioData().AutenticaUsuario(Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Pessoa;
        }

        public bool ExisteUsuario(UsuarioEntity Usuario)
        {
            bool retorno = false;

            try
            {
                retorno = new UsuarioData().ExisteUsuario(Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }
    }
}
