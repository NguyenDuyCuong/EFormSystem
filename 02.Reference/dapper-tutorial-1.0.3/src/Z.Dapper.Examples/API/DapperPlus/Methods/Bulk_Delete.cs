// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using Z.Dapper.Examples.API.Dapper.Methods;
using Z.Dapper.Plus;

namespace Z.Dapper.Examples.API.DapperPlus.Methods
{
    public partial class Bulk_Delete : Form
    {
        public Bulk_Delete()
        {
            InitializeComponent();
        }

        public void Single(object sender, EventArgs e)
        {
            My.Database.Reset(10000, false, false);

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoice = connection.QueryFirst<Invoice>(My.SqlText.Invoice_Select_ByID, new {InvoiceID = 1});

                var clock = new Stopwatch();
                clock.Start();

                connection.BulkDelete(invoice);

                clock.Stop();

                My.Result.Show(clock, 1);
            }
        }

        public void Many(object sender, EventArgs e)
        {
            My.Database.Reset(10000, false, false);

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoices = connection.Query<Invoice>(My.SqlText.Invoice_Select).ToList();

                var clock = new Stopwatch();
                clock.Start();

                connection.BulkDelete(invoices);

                clock.Stop();

                My.Result.Show(clock, invoices.Count);
            }
        }

        public void Relation_OneToOne(object sender, EventArgs e)
        {
            My.Database.Reset(10000, true, false);

            var invoices = GetInvoiceWithDetail();

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var clock = new Stopwatch();
                clock.Start();

                connection.BulkDelete(invoices.Select(x => x.Detail))
                    .BulkDelete(invoices);

                clock.Stop();

                My.Result.Show(clock, invoices.Count * 2);
            }
        }

        public void Relation_OneToMany(object sender, EventArgs e)
        {
            My.Database.Reset(10000, false, true);

            var invoices = GetInvoiceWithItems();

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var clock = new Stopwatch();
                clock.Start();

                connection.BulkDelete(invoices.SelectMany(x => x.Items))
                    .BulkDelete(invoices);

                clock.Stop();

                My.Result.Show(clock, invoices.Count + invoices.Sum(x => x.Items.Count));
            }
        }

        private List<Invoice> GetInvoiceWithDetail()
        {
            var sql = My.SqlText.Invoice_Select_WithDetail;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoices = connection.Query<Invoice, InvoiceDetail, Invoice>(
                        sql,
                        (invoice, invoiceDetail) =>
                        {
                            invoice.Detail = invoiceDetail;
                            return invoice;
                        },
                        splitOn: "InvoiceID")
                    .Distinct()
                    .ToList();

                return invoices;
            }
        }

        private List<Invoice> GetInvoiceWithItems()
        {
            var sql = My.SqlText.Invoice_Select_WithItem;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoiceDictionary = new Dictionary<int, Invoice>();

                var invoices = connection.Query<Invoice, InvoiceItem, Invoice>(
                        sql,
                        (invoice, invoiceItem) =>
                        {
                            Invoice invoiceEntry;

                            if (!invoiceDictionary.TryGetValue(invoice.InvoiceID, out invoiceEntry))
                            {
                                invoiceEntry = invoice;
                                invoiceEntry.Items = new List<InvoiceItem>();
                                invoiceDictionary.Add(invoiceEntry.InvoiceID, invoiceEntry);
                            }

                            invoiceEntry.Items.Add(invoiceItem);
                            return invoiceEntry;
                        },
                        splitOn: "InvoiceItemID")
                    .Distinct()
                    .ToList();

                return invoices;
            }
        }
    }
}