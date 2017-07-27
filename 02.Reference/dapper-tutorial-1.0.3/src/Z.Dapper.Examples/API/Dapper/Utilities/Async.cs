// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using Z.Dapper.Examples.API.Dapper.Methods;

namespace Z.Dapper.Examples.API.Dapper.Utilities
{
    public partial class Async : Form
    {
        public Async()
        {
            InitializeComponent();
        }

        private void ExecuteAsync(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Proc_Invoice_Insert;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var affectedRows = connection.ExecuteAsync(sql,
                        new {Kind = InvoiceKind.WebInvoice, Code = "Single_Insert_1"},
                        commandType: CommandType.StoredProcedure)
                    .Result;

                My.Result.Show(affectedRows);
            }
        }

        private void QueryAsync(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Select;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoices = connection.QueryAsync<Invoice>(sql).Result.ToList();

                My.Result.Show(invoices);
            }
        }

        private void QueryFirstAsync(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Select_ByID;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoice = connection.QueryFirstAsync<Invoice>(sql, new {InvoiceID = 1}).Result;

                My.Result.Show(invoice);
            }
        }

        private void QueryFirstOrDefaultAsync(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Select_ByID;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoice = connection.QueryFirstOrDefaultAsync<Invoice>(sql, new {InvoiceID = 1}).Result;

                My.Result.Show(invoice);
            }
        }

        private void QuerySingleAsync(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Select_ByID;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoice = connection.QuerySingleAsync<Invoice>(sql, new {InvoiceID = 1}).Result;

                My.Result.Show(invoice);
            }
        }

        private void QuerySingleOrDefaultAsync(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Select_ByID;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoice = connection.QuerySingleOrDefaultAsync<Invoice>(sql, new {InvoiceID = 1}).Result;

                My.Result.Show(invoice);
            }
        }

        private void QueryMultipleAsync(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Select_Then_Item_Select;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                using (var multi = connection.QueryMultipleAsync(sql, new { InvoiceID = 1 }).Result)
                {
                    var invoice = multi.Read<Invoice>().First();
                    var invoiceItems = multi.Read<InvoiceItem>().ToList();

                    My.Result.Show(invoice, invoiceItems);
                }
            }
        }
    }
}