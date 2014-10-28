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
    public class ReservaData : EnterpriseLibraryBase
    {
        public int InserirReserva(ReservaEntity Reserva)
        {
            int Retorno = 0;

            DbConnection cnn = DBase.CreateConnection();

            cnn.Open();

            using (DbTransaction transaction = cnn.BeginTransaction())
            {
                try
                {
                    using (DbCommand cmd = DBase.GetStoredProcCommand("RSO_PR_RSV_INS"))
                    {
                        DBase.AddInParameter(cmd, "P_DTA_RSV_INI", DbType.DateTime, Reserva.DataReservaInicio);
                        DBase.AddInParameter(cmd, "P_DTA_RSV_FIM", DbType.DateTime, Reserva.DataReservaFim);
                        DBase.AddInParameter(cmd, "P_ID_MSA", DbType.Int32, Reserva.Mesa.Id);
                        DBase.AddInParameter(cmd, "P_CDG_RSV", DbType.String, Reserva.CodigoReserva);
                        DBase.AddInParameter(cmd, "P_CDG_CHK", DbType.String, Reserva.CodigoCheckin);
                        DBase.AddInParameter(cmd, "P_FLG_CHK", DbType.Boolean, Reserva.FlagCheckin);
                        DBase.AddInParameter(cmd, "P_FLG_ATV", DbType.Boolean, Reserva.FlagAtiva);

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

        public bool AtualizarReserva(ReservaEntity Reserva)
        {
            bool Retorno = false;

            DbConnection cnn = DBase.CreateConnection();
            cnn.Open();
            using (DbTransaction transaction = cnn.BeginTransaction())
            {
                try
                {
                    using (DbCommand cmd = DBase.GetStoredProcCommand("RSO_PR_RSV_UPD"))
                    {
                        DBase.AddInParameter(cmd, "P_ID_RSV", DbType.DateTime, Reserva.Id);
                        DBase.AddInParameter(cmd, "P_DTA_RSV_INI", DbType.DateTime, Reserva.DataReservaInicio);
                        DBase.AddInParameter(cmd, "P_DTA_RSV_FIM", DbType.DateTime, Reserva.DataReservaFim);
                        DBase.AddInParameter(cmd, "P_ID_MSA", DbType.Int32, Reserva.Mesa.Id);
                        DBase.AddInParameter(cmd, "P_CDG_RSV", DbType.String, Reserva.CodigoReserva);
                        DBase.AddInParameter(cmd, "P_CDG_CHK", DbType.String, Reserva.CodigoCheckin);
                        DBase.AddInParameter(cmd, "P_FLG_CHK", DbType.Boolean, Reserva.FlagCheckin);
                        DBase.AddInParameter(cmd, "P_FLG_ATV", DbType.Boolean, Reserva.FlagAtiva);

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
    }
}
