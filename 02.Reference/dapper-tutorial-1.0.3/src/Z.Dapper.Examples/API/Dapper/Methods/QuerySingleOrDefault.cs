// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Windows.Forms;
using Dapper;

namespace Z.Dapper.Examples.API.Dapper.Methods
{
    public partial class QuerySingleOrDefault : Form
    {
        public QuerySingleOrDefault()
        {
            InitializeComponent();
        }

        private void Anonymous(object sender, EventArgs e)
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

        private void StronglyTyped(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Select_ByID;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoice = connection.QuerySingleOrDefault<Invoice>(sql, new {InvoiceID = 1});

                My.Result.Show(invoice);
            }
        }
    }
}