// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Linq;
using System.Windows.Forms;
using Dapper.Contrib.Extensions;
using Z.Dapper.Examples.API.Dapper.Methods;

namespace Z.Dapper.Examples.API.DapperContrib.DataAnnotations
{
    public partial class Computed : Form
    {
        public Computed()
        {
            InitializeComponent();
        }

        private void Update(object sender, EventArgs e)
        {
            My.Database.Reset();

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoices = connection.GetAll<InvoiceContrib>().ToList();

                // The FakeProperty is skipped
                invoices.ForEach(x => x.FakeProperty += "z");

                var isSuccess = connection.Update(invoices);

                My.Result.Show(isSuccess);
            }
        }
    }
}