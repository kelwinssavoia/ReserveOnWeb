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
    public class PessoaData : EnterpriseLibraryBase
    {
        public int InsereCliente(PessoaEntity Cliente)
        {
            int Id = 0;

            DbConnection cnn = DBase.CreateConnection();

            cnn.Open();

            using (DbTransaction transaction = cnn.BeginTransaction())
            {
                try
                {
                    using (DbCommand cmd = DBase.GetStoredProcCommand("RSO_PR_PSO_INS"))
                    {
                        DBase.AddInParameter(cmd, "P_ID_USR", DbType.Int32, Cliente.Usuario.Id);
                        DBase.AddInParameter(cmd, "P_END_EML", DbType.String, Cliente.EnderecoEmail);
                        DBase.AddInParameter(cmd, "P_NRO_TEL", DbType.String, Cliente.NumeroTelefone);
                        DBase.AddInParameter(cmd, "P_NME_CLT", DbType.String, Cliente.Nome);
                        DBase.AddInParameter(cmd, "P_NRO_CPF", DbType.String, Cliente.NumeroCpf);
                        DBase.AddInParameter(cmd, "P_NRO_RG", DbType.String, Cliente.NumeroRg);

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
    }
}
