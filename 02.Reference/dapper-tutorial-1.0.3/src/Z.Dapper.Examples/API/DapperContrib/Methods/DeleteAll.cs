// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Windows.Forms;
using Dapper.Contrib.Extensions;
using Z.Dapper.Examples.API.Dapper.Methods;

namespace Z.Dapper.Examples.API.DapperContrib.Methods
{
    public partial class DeleteAll : Form
    {
        public DeleteAll()
        {
            InitializeComponent();
        }

        private void All(object sender, EventArgs e)
        {
            My.Database.Reset(includeDetail: false, includeItems: false);

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var isSuccess = connection.DeleteAll<InvoiceContrib>();

                My.Result.Show(isSuccess);
            }
        }
    }
}