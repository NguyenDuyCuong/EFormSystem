using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace EFS.DataAccess.Base
{
    /// <summary>
    /// The abstract data mapper.
    /// </summary>
    /// <typeparam name="T">
    /// The data entity.
    /// </typeparam>
    public abstract class AbstractDataAccess<T>
    {
        public AbstractDataAccess(string connecString)
        {
            this.ConnectionString = connecString;
        }
        /// <summary>
        /// Gets the table name.
        /// </summary>
        protected abstract string TableName { get; }
        protected abstract string ConnectionString { get; set; }

        /// <summary>
        /// Gets the connection.
        /// </summary>
        protected IDbConnection Connection
        {
            get { return new SqlConnection(ConnectionString); }
        }
  
        /// <summary>
        /// Find a single record.
        /// </summary>
        /// <param name="query">
        /// The query.
        /// </param>
        /// <param name="param">
        /// The parameters.
        /// </param>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        public virtual T FindSingle(string query, dynamic param)
        {
            dynamic item = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                var result = cn.Query(query, (object)param).SingleOrDefault();

                if (result != null)
                {
                    item = Map(result);
                }
            }

            return item;
        }

        /// <summary>
        /// Find all.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public virtual IEnumerable<T> FindAll()
        {
            var items = new List<T>();

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                var results = cn.Query("SELECT * FROM " + TableName).ToList();

                for (int i = 0; i < results.Count(); i++)
                {
                    items.Add(Map(results.ElementAt(i)));
                }
            }

            return items;
        }

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        public virtual void Delete(Guid id)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                cn.Execute("DELETE FROM " + TableName + " WHERE ID=@ID", new { ID = id });
            }
        }

        /// <summary>
        /// The map.
        /// </summary>
        /// <param name="result">
        /// The result.
        /// </param>
        /// <returns>
        /// The <see cref="dynamic"/>.
        /// </returns>
        public abstract T Map(dynamic result);
    }
}
