// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Data;
using System.Windows.Forms;
using Dapper;
using Z.Dapper.Examples.API.Dapper.Methods;

namespace Z.Dapper.Examples.API.Dapper.Utilities
{
    public partial class Stored_Procedure : Form
    {
        public Stored_Procedure()
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

                var affectedRows = connection.Execute(sql,
                    new {Kind = InvoiceKind.WebInvoice, Code = "Single_Insert_1"},
                    commandType: CommandType.StoredProcedure);

                My.Result.Show(affectedRows);
            }
        }

        private void Execute_Many(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Proc_Invoice_Insert;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var affectedRows = connection.Execute(sql,
                    new[]
                    {
                        new {Kind = InvoiceKind.WebInvoice, Code = "Many_Insert_1"},
                        new {Kind = InvoiceKind.WebInvoice, Code = "Many_Insert_2"},
                        new {Kind = InvoiceKind.StoreInvoice, Code = "Many_Insert_3"}
                    },
                    commandType: CommandType.StoredProcedure
                );

                My.Result.Show(affectedRows);
            }
        }
    }
}