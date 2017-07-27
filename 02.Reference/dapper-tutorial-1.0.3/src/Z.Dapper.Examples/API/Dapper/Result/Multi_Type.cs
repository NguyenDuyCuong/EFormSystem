// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dapper;
using Z.Dapper.Examples.API.Dapper.Methods;

namespace Z.Dapper.Examples.API.Dapper.Result
{
    public partial class Multi_Type : Form
    {
        public Multi_Type()
        {
            InitializeComponent();
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