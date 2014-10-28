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
    public class MesaData : EnterpriseLibraryBase
    {
        public int InserirMesa(MesaEntity Mesa)
        {
            int Retorno = 0;

            DbConnection cnn = DBase.CreateConnection();

            cnn.Open();

            using (DbTransaction transaction = cnn.BeginTransaction())
            {
                try
                {
                    using (DbCommand cmd = DBase.GetStoredProcCommand("RSO_PR_MSA_INS"))
                    {
                        DBase.AddInParameter(cmd, "P_QTD_LGR", DbType.Int32, Mesa.QuantidadeLugares);
                        DBase.AddInParameter(cmd, "P_DES_LOC", DbType.String, Mesa.DescricaoLocalizacao);
                        DBase.AddInParameter(cmd, "P_QR_COD", DbType.Int32, Mesa.QrCode);

                        using (IDataReader reader = DBase.ExecuteReader(cmd, transaction))
                        {
                            while (reader.Read())
                            {
                                Retorno = Convert.ToInt32(reader["RETORNO"]);
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
            return Retorno;
        }

        public bool AtualizarMesa(MesaEntity Mesa)
        {
            bool Retorno = false;

            DbConnection cnn = DBase.CreateConnection();
            cnn.Open();
            using (DbTransaction transaction = cnn.BeginTransaction())
            {
                try
                {
                    using (DbCommand cmd = DBase.GetStoredProcCommand("RSO_PR_MSA_UPD"))
                    {
                        DBase.AddInParameter(cmd, "P_ID_MSA", DbType.Int32, Mesa.Id);
                        DBase.AddInParameter(cmd, "P_QTD_LGR", DbType.Int32, Mesa.QuantidadeLugares);
                        DBase.AddInParameter(cmd, "P_DES_LOC", DbType.String, Mesa.DescricaoLocalizacao);
                        DBase.AddInParameter(cmd, "P_QR_COD", DbType.Int32, Mesa.QrCode);
                        DBase.ExecuteNonQuery(cmd, transaction);
                        transaction.Commit();
                        Retorno = true;
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Retorno = false;
                    throw ex;
                }
            }

            return Retorno;
        }

        public bool DeletarMesa(MesaEntity Mesa)
        {
            bool Retorno = false;

            DbConnection cnn = DBase.CreateConnection();
            cnn.Open();
            using (DbTransaction transaction = cnn.BeginTransaction())
            {
                try
                {
                    using (DbCommand cmd = DBase.GetStoredProcCommand("RSO_PR_MSA_DEL"))
                    {
                        DBase.AddInParameter(cmd, "P_ID_MSA", DbType.Int32, Mesa.Id);
                        DBase.ExecuteNonQuery(cmd, transaction);
                        transaction.Commit();
                        Retorno = true;
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }

            return Retorno;
        }
    }
}
