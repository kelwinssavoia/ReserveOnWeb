using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UsuarioData : EnterpriseLibraryBase
    {
        public int InsereUsuario(UsuarioEntity Usuario)
        {
            int Id = 0;

            DbConnection cnn = DBase.CreateConnection();

            cnn.Open();

            using (DbTransaction transaction = cnn.BeginTransaction())
            {
                try
                {
                    using (DbCommand cmd = DBase.GetStoredProcCommand("RSO_PR_USR_INS"))
                    {
                        DBase.AddInParameter(cmd, "P_USER_NME", DbType.String, Usuario.Login);
                        DBase.AddInParameter(cmd, "P_USER_PSW", DbType.String, Usuario.Senha);
                        DBase.AddInParameter(cmd, "P_ID_PRF", DbType.Int32, Usuario.Perfil.Id);

                        using (IDataReader reader = DBase.ExecuteReader(cmd, transaction))
                        {
                            while (reader.Read())
                            {
                                Id = Convert.ToInt32(reader["RETORNO"]);
                            }
                        }
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }

            cnn.Close();
            return Id;
        }

        public PessoaEntity AutenticaUsuario(UsuarioEntity Usuario)
        {
            PessoaEntity Pessoa = null;

            try
            {
                using (DbCommand cmd = DBase.GetStoredProcCommand("RSO_PR_USR_PSO_SEL"))
                {
                    DBase.AddInParameter(cmd, "P_USER_NME", DbType.String, Usuario.Login);
                    DBase.AddInParameter(cmd, "P_USER_PSW", DbType.String, Usuario.Senha);

                    using (IDataReader reader = DBase.ExecuteReader(cmd))
                    {
                        if (reader.Read())
                        {
                            Pessoa = new PessoaEntity();
                            Pessoa.Usuario = Usuario;
                            Pessoa.Usuario.Perfil = new PerfilEntity();

                            Pessoa.Usuario.Id = Convert.ToInt32(reader["ID_USR"]);

                            Pessoa.Id = Convert.ToInt32(reader["ID_PSO"]);
                            Pessoa.EnderecoEmail = reader["END_EML"].ToString();
                            Pessoa.NumeroTelefone = reader["NRO_TEL"].ToString();
                            Pessoa.Nome = reader["NME_CLT"].ToString();
                            Pessoa.NumeroCpf = reader["NRO_CPF"].ToString();
                            Pessoa.NumeroRg = reader["NRO_RG"].ToString();

                            Pessoa.Usuario.Perfil.Id = Convert.ToInt32(reader["ID_PRF"]);
                            Pessoa.Usuario.Perfil.Descricao = reader["DES_PRF"].ToString();
                        }
                    }
                }
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
                using (DbCommand cmd = DBase.GetStoredProcCommand("RSO_PR_USR_NME_VLD"))
                {
                    DBase.AddInParameter(cmd, "P_USER_NME", DbType.String, Usuario.Login);

                    using (IDataReader reader = DBase.ExecuteReader(cmd))
                    {
                        retorno = reader.Read();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }
    }
}
