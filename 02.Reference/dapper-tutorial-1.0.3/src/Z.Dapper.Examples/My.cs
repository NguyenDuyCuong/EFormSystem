// Description: Dapper Tutorial | Examples
// Website: http://dapper-tutorial.net/
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2017. All rights reserved.

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace Z.Dapper.Examples.API.Dapper.Methods
{
    public static class My
    {
        public static Func<DbConnection> ConnectionFactory = () => new SqlConnection(ConnectionString.Connection);

        static My()
        {
            DapperPlusManager.Entity<Invoice>()
                .Map(x => new {x.InvoiceID, x.Kind, x.Code})
                .Identity(x => x.InvoiceID);
        }

        public static class ConnectionString
        {
            public static string Connection = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        }

        public static class SqlText
        {
            public static string Invoice_Select = "SELECT * FROM Invoice;";
            public static string Invoice_Select_WithDetail = "SELECT * FROM Invoice AS A INNER JOIN InvoiceDetail AS B ON A.InvoiceID = B.InvoiceID;";
            public static string Invoice_Select_WithItem = "SELECT * FROM Invoice AS A INNER JOIN InvoiceItem AS B ON A.InvoiceID = B.InvoiceID;";
            public static string Invoice_Select_ByKind = "SELECT * FROM Invoice WHERE Kind IN @Kind;";
            public static string Invoice_Select_ByCode = "SELECT * FROM Invoice WHERE Code = @Code;";
            public static string Invoice_Select_ByID = "SELECT * FROM Invoice WHERE InvoiceID = @InvoiceID;";
            public static string Invoice_Select_Then_Item_Select = "SELECT * FROM Invoice; SELECT * FROM InvoiceItem;";
            public static string Invoice_Insert = "INSERT INTO Invoice (Kind, Code) Values (@Kind, @Code);";
            public static string Invoice_Update = "UPDATE Invoice SET Code = @Code WHERE InvoiceID = @InvoiceID";
            public static string Invoice_Delete = "DELETE FROM Invoice WHERE InvoiceID = @InvoiceID";
            public static string Proc_Invoice_Insert = "Invoice_Insert";
        }

        public static class Database
        {
            public static void Reset(int count = 3, bool includeDetail = true, bool includeItems = true)
            {
                using (var connection = ConnectionFactory())
                {
                    connection.Open();

                    // RESET
                    {
                        var command = connection.CreateCommand();

                        command.CommandText = @"
-- DELETE all data
DELETE FROM InvoiceItem
DELETE FROM InvoiceDetail
DELETE FROM Invoice

-- RESEED Identity
DBCC CHECKIDENT (InvoiceItem, RESEED, 0)
DBCC CHECKIDENT (Invoice, RESEED, 0)
";
                        command.ExecuteNonQuery();
                    }

                    // SEED
                    {
                        var invoices = new List<Invoice>();

                        for (var i = 0; i < count; i++)
                        {
                            var invoice = new Invoice
                            {
                                Kind = i % 3 == 0 ? InvoiceKind.StoreInvoice : InvoiceKind.WebInvoice,
                                Code = "Invoice_" + i
                            };

                            if (includeDetail)
                            {
                                invoice.Detail = new InvoiceDetail {Detail = "InvoiceDetail_" + i};
                            }

                            if (includeItems)
                            {
                                invoice.Items = new List<InvoiceItem>();

                                var maxItems = 3 - i % 3;
                                for (var j = 0; j < maxItems; j++)
                                {
                                    invoice.Items.Add(new InvoiceItem {Code = "InvoiceItem_" + j});
                                }
                            }

                            invoices.Add(invoice);
                        }

                        connection.BulkInsert(invoices);

                        if (includeDetail)
                        {
                            invoices.ForEach(x => x.Detail.InvoiceID = x.InvoiceID);
                            connection.BulkInsert(invoices.Select(x => x.Detail));
                        }

                        if (includeItems)
                        {
                            invoices.ForEach(x => x.Items.ForEach(y => y.InvoiceID = x.InvoiceID));
                            connection.BulkInsert(invoices.SelectMany(x => x.Items));
                        }
                    }
                }
            }
        }
        public static class AppSettings
        {
            public static int NbTestItems = Convert.ToInt32(ConfigurationManager.AppSettings["NbTestItems"]);
        }

        public static class Result
        {
            public static void Show(Form form, object button, Stopwatch clock, int nbItems)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Form: " + form.Text);
                sb.AppendLine("Example: " + ((Button)button).Text);

                if (nbItems != -1)
                {
                    sb.AppendLine("Rows Affected: " + nbItems);
                }

                sb.AppendLine("Elapsed Milliseconds: " + clock.Elapsed.TotalMilliseconds);

                MessageBox.Show(sb.ToString(), @"Result");
            }

            public static void Show(object result)
            {
                if (result is Invoice || result is InvoiceContrib)
                {
                    MessageBox.Show("One invoice returned", "Result");
                }
                else if (result is List<Invoice>)
                {
                    var list = (List<Invoice>) result;

                    if ((list.Count > 0) && (list[0].Detail != null))
                    {
                        MessageBox.Show(string.Format("{0} invoice(s) returned (Including InvoiceDetail information)", list.Count), "Result");
                    }
                    else if ((list.Count > 0)
                             && (list[0] is StoreInvoice || list[0] is WebInvoice))
                    {
                        MessageBox.Show(string.Format("{0} invoice(s) returned (StoreInvoice: {1}, WebInvoice: {2})",
                                list.Count,
                                list.Count(x => x is StoreInvoice),
                                list.Count(x => x is WebInvoice)),
                            "Result");
                    }
                    else if ((list.Count > 0) && (list[0].Items != null))
                    {
                        MessageBox.Show(string.Format("{0} invoice(s) returned (Including {1} InvoiceItem)",
                                list.Count,
                                list.SelectMany(x => x.Items).Count()),
                            "Result");
                    }
                    else
                    {
                        MessageBox.Show(string.Format("{0} invoice(s) returned", list.Count), "Result");
                    }
                }
                else if (result is List<InvoiceContrib>)
                {
                    var list = (List<InvoiceContrib>) result;

                    MessageBox.Show(string.Format("{0} invoice(s) returned", list.Count), "Result");
                }
                else if (result is List<object>)
                {
                    MessageBox.Show(string.Format("{0} anonymous entity returned", ((List<object>) result).Count), "Result");
                }
                else if (result is bool)
                {
                    MessageBox.Show("The operation has been succesfully completed", "Result");
                }
                else if (result is int)
                {
                    MessageBox.Show(string.Format("Row Affecteds: {0}", result), "Result");
                }
                else if (result is long)
                {
                    MessageBox.Show(string.Format("Inserted with Identity: {0}", result), "Result");
                }
                else
                {
                    MessageBox.Show("1 anonymous entity returned", "Result");
                }
            }

            public static void Show(object result1, object result2)
            {
                if (result1 is Invoice && result2 is List<InvoiceItem>)
                {
                    MessageBox.Show(string.Format("1 returned with {0} InvoiceItem(s)", ((List<InvoiceItem>) result2).Count), "Result");
                }
                else if (result1 is Stopwatch && result2 is int)
                {
                    MessageBox.Show(string.Format("Row Affecteds: {1}; Time: {0}ms", ((Stopwatch) result1).ElapsedMilliseconds, result2), "Result");
                }
                else
                {
                    MessageBox.Show("Unknown", "Result");
                }
            }
        }
    }
}