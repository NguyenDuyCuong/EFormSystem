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
    public partial class Multi_Result : Form
    {
        public Multi_Result()
        {
            InitializeComponent();
        }

        private void Read(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Select_Then_Item_Select;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                using (var multi = connection.QueryMultiple(sql, new {InvoiceID = 1}))
                {
                    var invoice = multi.Read<Invoice>().First();
                    var invoiceItems = multi.Read<InvoiceItem>().ToList();

                    My.Result.Show(invoice, invoiceItems);
                }
            }
        }
    }
}