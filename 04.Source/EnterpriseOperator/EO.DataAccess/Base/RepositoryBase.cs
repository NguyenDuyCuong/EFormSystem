using Dapper;
using EO.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace EO.DataAccess.Base
{
    public abstract class RepositoryBase<T>
    {
        public RepositoryBase(string stringConnection)
        {
            this.connectionString = stringConnection;
        }

        public void Add(Workflow item)
        {
            using (var cn = Connection)
            {
                cn.Open();
                var ts = cn.BeginTransaction();


                ts.Commit();
            }
        }

        public List<Workflow> Query(ISpecification<Workflow> specification)
        {
            var result = new List<Workflow>();
            using (var cn = Connection)
            {
                cn.Open();
                var ts = cn.BeginTransaction();

                result = cn.Query<Workflow>(specification.GetSqlQuery()).AsList();

                ts.Commit();
            }

            return result;
        }

        public void Remove(Workflow item)
        {
            throw new NotImplementedException();
        }

        public void Remove(ISpecification<Workflow> specification)
        {
            throw new NotImplementedException();
        }

        public void Update(Workflow item)
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
