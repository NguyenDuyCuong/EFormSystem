using Dapper;
using EO.Models;
using EO.Models.Base;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace EO.DataAccess.Base
{
    public abstract class RepositoryBase
    {
        public RepositoryBase(string stringConnection)
        {
            this.connectionString = stringConnection;
        }

        public void Add(IEntity item)
        {
            using (var cn = Connection)
            {
                cn.Open();
                var ts = cn.BeginTransaction();


                ts.Commit();
            }
        }

        public List<T> Query<T>(ISpecification specification)
        {
            var result = new List<T>();
            using (var cn = Connection)
            {
                cn.Open();
                var ts = cn.BeginTransaction();
                var tmp = cn.Query<T>(specification.GetSqlQuery());
                result = tmp.AsList();

                ts.Commit();
            }

            return result;
        }

        public void Remove(IEntity item)
        {
            throw new NotImplementedException();
        }

        public void Remove(ISpecification specification)
        {
            throw new NotImplementedException();
        }

        public void Update(IEntity item)
        {
            throw new NotImplementedException();
        }

        private readonly String connectionString;
        protected IDbConnection Connection
        {
            get
            {
                return new SqliteConnection(connectionString);
            }
        }
    }
}
