using Dapper;
using Dapper.Contrib.Extensions;
using EFS.Model.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace EFS.DataAccess.Base
{
    public class BaseRepository<T> : IRepository<T> where T : EntityBase, IAggregateRoot
    {
        protected string ConnectionString { get; set; }

        /// <summary>
        /// Gets the connection.
        /// </summary>
        protected IDbConnection Connection
        {
            get { return new SqlConnection(ConnectionString); }
        }

        public BaseRepository(string strConnection)
        {
            ConnectionString = strConnection;
        }

        public virtual IEnumerable<T> GetAll()
        {
            var items = new List<T>();

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                items = cn.GetAll<T>().ToList();
            }

            return items;
        }

        public virtual T FindById(Guid id)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                var item = cn.Get<T>(id);
                return item;
            }
        }

        public virtual T FindSingle(string query, dynamic param)
        {
            dynamic item = null;

            using (IDbConnection cn = Connection)
            {
                cn.Open();
                item = cn.Query<T>(query, (object)param).SingleOrDefault();
            }

            return item;
        }

        public virtual T Insert(T item) {
            using (IDbConnection cn = Connection)
            {
                item.ID = Guid.NewGuid();
                cn.Open();
                cn.Insert<T>(item);

                return cn.Get<T>(item.ID);
            }
        }

        public virtual void Update(T item) {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                cn.Update<T>(item);
            }
        }

        public virtual void Delete(Guid id)
        {
            using (IDbConnection cn = Connection)
            {
                cn.Open();
                var item = cn.Get<T>(id);
                if (item != null)
                    cn.Delete(item);
            }
        }
    }
}
