// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dapper;

namespace Z.Dapper.Examples.API.Dapper.Methods
{
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
        }

        private void Anonymous(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Select;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoices = connection.Query(sql).ToList();

                My.Result.Show(invoices);
            }
        }

        private void StronglyTyped(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Select;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoices = connection.Query<Invoice>(sql).ToList();

                My.Result.Show(invoices);
            }
        }

        private void MultiMapping_OneToOne(object sender, EventArgs e)
        {
            My.Database.Reset();

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

                My.Result.Show(invoices);
            }
        }

        private void MultiMapping_OneToMany(object sender, EventArgs e)
        {
            My.Database.Reset();

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

                My.Result.Show(invoices);
            }
        }

        private void MultiType(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Select;

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var invoices = new List<Invoice>();

                using (var reader = connection.ExecuteReader(sql))
                {
                    var storeInvoiceParser = reader.GetRowParser<StoreInvoice>();
                    var webInvoiceParser = reader.GetRowParser<WebInvoice>();

                    while (reader.Read())
                    {
                        Invoice invoice;

                        switch ((InvoiceKind) reader.GetInt32(reader.GetOrdinal("Kind")))
                        {
                            case InvoiceKind.StoreInvoice:
                                invoice = storeInvoiceParser(reader);
                                break;
                            case InvoiceKind.WebInvoice:
                                invoice = webInvoiceParser(reader);
                                break;
                            default:
                                throw new Exception(ExceptionMessage.GeneralException);
                        }

                        invoices.Add(invoice);
                    }
                }

                My.Result.Show(invoices);
            }
        }
    }
}