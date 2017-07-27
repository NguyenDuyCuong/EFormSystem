// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Windows.Forms;
using Dapper.Contrib.Extensions;
using Z.Dapper.Examples.API.Dapper.Methods;

namespace Z.Dapper.Examples.API.DapperContrib.DataAnnotations
{
    public partial class ExplicitKey : Form
    {
        public ExplicitKey()
        {
            InitializeComponent();
        }

        private void Insert(object sender, EventArgs e)
        {
            My.Database.Reset();

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoice = new InvoiceContrib {Kind = InvoiceKind.WebInvoice, Code = "Insert_Single_1"};
                connection.Insert(invoice);

                var invoiceDetail = new InvoiceDetailContrib {InvoiceID = invoice.InvoiceID, Detail = "Insert_Single_1"};
                connection.Insert(invoiceDetail);

                My.Result.Show(true);
            }
        }
    }
}