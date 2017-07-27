// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Data;
using System.Transactions;
using System.Windows.Forms;
using Dapper;
using Z.Dapper.Examples.API.Dapper.Methods;

namespace Z.Dapper.Examples.API.Dapper.Utilities
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_FromConnection(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Proc_Invoice_Insert;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    var affectedRows = connection.Execute(sql,
                        new {Kind = InvoiceKind.WebInvoice, Code = "Single_Insert_1"},
                        commandType: CommandType.StoredProcedure,
                        transaction: transaction);

                    transaction.Commit();

                    My.Result.Show(affectedRows);
                }
            }
        }

        private void TransactionScope(object sender, EventArgs e)
        {
            // using System.Transactions;

            My.Database.Reset();

            using (var transaction = new TransactionScope())
            {
                var sql = My.SqlText.Proc_Invoice_Insert;

                using (var connection = My.ConnectionFactory())
                {
                    connection.Open();

                    var affectedRows = connection.Execute(sql,
                        new {Kind = InvoiceKind.WebInvoice, Code = "Single_Insert_1"},
                        commandType: CommandType.StoredProcedure);

                    My.Result.Show(affectedRows);
                }

                transaction.Complete();
            }
        }
    }
}