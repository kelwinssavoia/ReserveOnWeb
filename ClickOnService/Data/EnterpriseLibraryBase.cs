using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public abstract class EnterpriseLibraryBase
    {
        #region Propriedades
        protected Database DBase
        {
            get
            {
                return DatabaseFactory.CreateDatabase("ReserveOn");
            }
        }

        #endregion

        #region Contrutor
        public EnterpriseLibraryBase()
        {

        }
        #endregion

        #region Métodos
        /// <summary>
        /// Executa o método ExecuteNonQuery do assembly Microsoft.Practices.EnterpriseLibrary.Data.DataBase
        /// </summary>
        /// <param name="cmd">System.Data.Common.DbCommand</param>
        /// <returns>Retorna um inteiro</returns>
        protected int ExecuteNonQuery(DbCommand cmd)
        {
            return this.DBase.ExecuteNonQuery(cmd);
        }


        /// <summary>
        /// Executa o método ExecuteDataSet do assembly Microsoft.Practices.EnterpriseLibrary.Data.DataBase
        /// </summary>
        /// <param name="db">Microsoft.Practices.EnterpriseLibrary.Data.DataBase</param>
        /// <param name="cmd">System.Data.Common.DbCommand</param>
        /// <returns>Retorna um objeto do tipo DataSet</returns>
        protected DataSet ExecuteDataSet(DbCommand cmd)
        {
            return this.DBase.ExecuteDataSet(cmd);
        }


        /// <summary>
        /// Executa o método ExecuteReader do assembly Microsoft.Practices.EnterpriseLibrary.Data.DataBase
        /// </summary>
        /// <param name="cmd">System.Data.Common.DbCommand</param>
        /// <returns>Retorna um objeto do tipo IDataReader</returns>
        protected IDataReader ExecuteReader(DbCommand cmd)
        {
            return this.DBase.ExecuteReader(cmd);
        }


        /// <summary>
        /// Executa o método ExecuteScalar do assembly Microsoft.Practices.EnterpriseLibrary.Data.DataBase
        /// </summary>
        /// <param name="cmd">System.Data.Common.DbCommand</param>
        /// <returns>Retorna um objeto</returns>
        protected object ExecuteScalar(DbCommand cmd)
        {
            return this.DBase.ExecuteScalar(cmd);
        }
        #endregion
    }
}
