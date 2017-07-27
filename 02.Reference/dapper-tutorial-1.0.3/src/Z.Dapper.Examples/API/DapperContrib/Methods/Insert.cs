// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dapper.Contrib.Extensions;
using Z.Dapper.Examples.API.Dapper.Methods;

namespace Z.Dapper.Examples.API.DapperContrib.Methods
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void Single(object sender, EventArgs e)
        {
            My.Database.Reset();

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var identity = connection.Insert(new InvoiceContrib {Kind = InvoiceKind.WebInvoice, Code = "Insert_Single_1"});

                My.Result.Show(identity);
            }
        }

        private void Many(object sender, EventArgs e)
        {
            My.Database.Reset();

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var list = new List<InvoiceContrib>
                {
                    new InvoiceContrib {Kind = InvoiceKind.WebInvoice, Code = "Insert_Many_1"},
                    new InvoiceContrib {Kind = InvoiceKind.WebInvoice, Code = "Insert_Many_2"},
                    new InvoiceContrib {Kind = InvoiceKind.StoreInvoice, Code = "Insert_Many_3"}
                };

                var identity = connection.Insert(list);

                My.Result.Show(identity);
            }
        }
    }
}