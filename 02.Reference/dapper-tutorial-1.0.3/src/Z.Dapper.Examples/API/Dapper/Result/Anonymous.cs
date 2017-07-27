// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using Z.Dapper.Examples.API.Dapper.Methods;

namespace Z.Dapper.Examples.API.Dapper.Result
{
    public partial class Anonymous : Form
    {
        public Anonymous()
        {
            InitializeComponent();

            // Copy & Paste current example
        }

        private void Query(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Select;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoices = connection.Query(sql).ToList();

                My.Result.Show(invoices);
            }
        }

        private void QueryFirst(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Select_ByID;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoice = connection.QueryFirst(sql, new {InvoiceID = 1});

                My.Result.Show(invoice);
            }
        }

        private void QueryFirstOrDefault(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Select_ByID;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoice = connection.QueryFirstOrDefault(sql, new {InvoiceID = 1});

                My.Result.Show(invoice);
            }
        }

        private void QuerySingle(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Select_ByID;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoice = connection.QuerySingle(sql, new {InvoiceID = 1});

                My.Result.Show(invoice);
            }
        }

        private void QuerySingleOrDefault(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Select_ByID;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoice = connection.QuerySingleOrDefault(sql, new {InvoiceID = 1});

                My.Result.Show(invoice);
            }
        }
    }
}