// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using Z.Dapper.Examples.API.Dapper.Methods;

namespace Z.Dapper.Examples.API.Dapper.Parameter
{
    public partial class Dynamic : Form
    {
        public Dynamic()
        {
            InitializeComponent();
        }

        private void Execute_Single(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Proc_Invoice_Insert;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                DynamicParameters parameter = new DynamicParameters();

                parameter.Add("@Kind", InvoiceKind.WebInvoice, DbType.Int32, ParameterDirection.Input);
                parameter.Add("@Code", "Many_Insert_0", DbType.String, ParameterDirection.Input);
                parameter.Add("@RowCount", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                connection.Execute(sql,
                    parameter,
                    commandType: CommandType.StoredProcedure);

                My.Result.Show(parameter.Get<int>("@RowCount"));
            }
        }

        private void Execute_Many(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Proc_Invoice_Insert;

            var parameters = new List<DynamicParameters>();

            for (var i = 0; i < 3; i++)
            {
                var p = new DynamicParameters();
                p.Add("@Kind", InvoiceKind.WebInvoice, DbType.Int32, ParameterDirection.Input);
                p.Add("@Code", "Many_Insert_" + (i + 1), DbType.String, ParameterDirection.Input);
                p.Add("@RowCount", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                parameters.Add(p);
            }

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                connection.Execute(sql,
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                var rowCount = parameters.Sum(x => x.Get<int>("@RowCount"));

                My.Result.Show(rowCount);
            }
        }
    }
}