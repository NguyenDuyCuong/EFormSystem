// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Z.Dapper.Examples.API.Dapper.Methods;
using Z.Dapper.Plus;

namespace Z.Dapper.Examples.API.DapperPlus.Methods
{
    public partial class Bulk_Insert : Form
    {
        public Bulk_Insert()
        {
            InitializeComponent();
        }

        public void Single(object sender, EventArgs e)
        {
            My.Database.Reset();

            var invoice = new Invoice {Kind = InvoiceKind.WebInvoice, Code = "BulkInsert_Single_0"};

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var clock = new Stopwatch();
                clock.Start();

                connection.BulkInsert(invoice);

                clock.Stop();

                My.Result.Show(clock, 1);
            }
        }

        public void Many(object sender, EventArgs e)
        {
            My.Database.Reset();

            var invoices = new List<Invoice>();

            for (var i = 0; i < 10000; i++)
            {
                invoices.Add(new Invoice {Code = "BulkInsert_Many_" + i});
            }

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var clock = new Stopwatch();
                clock.Start();

                connection.BulkInsert(invoices);

                clock.Stop();

                My.Result.Show(clock, invoices.Count);
            }
        }

        public void Relation_OneToOne(object sender, EventArgs e)
        {
            My.Database.Reset();

            var invoices = new List<Invoice>();

            for (var i = 0; i < 10000; i++)
            {
                var invoice = new Invoice {Code = "BulkInsert_Many_" + i};
                invoice.Detail = new InvoiceDetail {Detail = "BulkInsert_Many_" + i};
                invoices.Add(invoice);
            }

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var clock = new Stopwatch();
                clock.Start();

                connection.BulkInsert(invoices)
                    .ThenForEach(x => x.Detail.InvoiceID = x.InvoiceID)
                    .ThenBulkInsert(x => x.Detail);

                clock.Stop();

                My.Result.Show(clock, invoices.Count * 2);
            }
        }

        public void Relation_OneToMany(object sender, EventArgs e)
        {
            My.Database.Reset();

            var invoices = new List<Invoice>();

            for (var i = 0; i < 10000; i++)
            {
                var invoice = new Invoice {Code = "BulkInsert_Many_" + i};
                invoice.Items = new List<InvoiceItem>();

                for (var j = 0; j < 5; j++)
                {
                    invoice.Items.Add(new InvoiceItem {Code = "BulkInsert_Many_" + i});
                }

                invoices.Add(invoice);
            }

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var clock = new Stopwatch();
                clock.Start();

                connection.BulkInsert(invoices)
                    .ThenForEach(x => x.Items.ForEach(y => y.InvoiceID = x.InvoiceID))
                    .ThenBulkInsert(x => x.Items);

                clock.Stop();

                My.Result.Show(clock, invoices.Count + invoices.Sum(x => x.Items.Count));
            }
        }
    }
}