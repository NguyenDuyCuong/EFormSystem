// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using Z.Dapper.Examples.API.Dapper.Methods;

namespace Z.Dapper.Examples.API.Dapper.Parameter
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void Query(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Select_ByKind;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoices = connection.Query<Invoice>(sql, new {Kind = new[] {InvoiceKind.StoreInvoice, InvoiceKind.WebInvoice}}).ToList();

                My.Result.Show(invoices);
            }
        }
    }
}