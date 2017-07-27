// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Data;
using System.Windows.Forms;
using Dapper;

namespace Z.Dapper.Examples.API.Dapper.Methods
{
    public partial class Execute : Form
    {
        public Execute()
        {
            InitializeComponent();
        }

        private void StoredProcedure_Single(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Proc_Invoice_Insert;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var affectedRows = connection.Execute(sql,
                    new {Kind = InvoiceKind.WebInvoice, Code = "Single_Insert_1"},
                    commandType: CommandType.StoredProcedure);

                My.Result.Show(affectedRows);
            }
        }

        private void StoredProcedure_Many(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Proc_Invoice_Insert;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var affectedRows = connection.Execute(sql,
                    new[]
                    {
                        new {Kind = InvoiceKind.WebInvoice, Code = "Many_Insert_1"},
                        new {Kind = InvoiceKind.WebInvoice, Code = "Many_Insert_2"},
                        new {Kind = InvoiceKind.StoreInvoice, Code = "Many_Insert_3"}
                    },
                    commandType: CommandType.StoredProcedure
                );

                My.Result.Show(affectedRows);
            }
        }

        private void Insert_Single(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Insert;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var affectedRows = connection.Execute(sql, new {Kind = InvoiceKind.WebInvoice, Code = "Single_Insert_1"});

                My.Result.Show(affectedRows);
            }
        }

        private void Insert_Many(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Insert;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var affectedRows = connection.Execute(sql,
                    new[]
                    {
                        new {Kind = InvoiceKind.WebInvoice, Code = "Many_Insert_1"},
                        new {Kind = InvoiceKind.WebInvoice, Code = "Many_Insert_2"},
                        new {Kind = InvoiceKind.StoreInvoice, Code = "Many_Insert_3"}
                    }
                );

                My.Result.Show(affectedRows);
            }
        }

        private void Update_Single(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Update;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var affectedRows = connection.Execute(sql, new {InvoiceID = 1, Code = "Single_Update_1"});

                My.Result.Show(affectedRows);
            }
        }

        private void Update_Many(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Update;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var affectedRows = connection.Execute(sql,
                    new[]
                    {
                        new {InvoiceID = 1, Code = "Many_Update_1"},
                        new {InvoiceID = 2, Code = "Many_Update_2"},
                        new {InvoiceID = 3, Code = "Many_Update_3"}
                    });

                My.Result.Show(affectedRows);
            }
        }

        private void Delete_Single(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Delete;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var affectedRows = connection.Execute(sql, new {InvoiceID = 1});

                My.Result.Show(affectedRows);
            }
        }

        private void Delete_Many(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Delete;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var affectedRows = connection.Execute(sql,
                    new[]
                    {
                        new {InvoiceID = 1},
                        new {InvoiceID = 2},
                        new {InvoiceID = 3}
                    });

                My.Result.Show(affectedRows);
            }
        }
    }
}