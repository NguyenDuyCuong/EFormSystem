// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Windows.Forms;
using Dapper;

namespace Z.Dapper.Examples.API.Dapper.Methods
{
    public partial class QuerySingle : Form
    {
        public QuerySingle()
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

                var invoice = connection.QuerySingle(sql, new {InvoiceID = 1});

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

                var invoice = connection.QuerySingle<Invoice>(sql, new {InvoiceID = 1});

                My.Result.Show(invoice);
            }
        }
    }
}