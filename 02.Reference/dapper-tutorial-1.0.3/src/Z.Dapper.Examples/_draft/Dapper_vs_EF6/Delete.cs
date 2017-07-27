using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using Z.Dapper.Examples.API.Dapper.Methods;

namespace Z.Dapper.Examples.Performance_Comparison.Dapper_vs_EF6
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        #region Delete Single (One Record, 500 Iterations)

        private void uiDapper_Delete_Single_Execute_Single_Click(object sender, EventArgs e)
        {
            // ENSURE JIT Compile
            Dapper_Delete_Single_Execute_Single(sender, false);

            // Benchmark Test
            Dapper_Delete_Single_Execute_Single(sender, true);
        }

        private void uiEF6_Delete_Single_SaveChanges_Click(object sender, EventArgs e)
        {
            // ENSURE JIT Compile
            EF6_Delete_Single_SaveChanges(sender, false);

            // Benchmark Test
            EF6_Delete_Single_SaveChanges(sender, true);
        }

        public void Dapper_Delete_Single_Execute_Single(object sender, bool showResult)
        {
            My.Database.Reset(My.AppSettings.NbTestItems, false, false);

            var affectedRows = 0;
            var clock = new Stopwatch();
            var sql = My.SqlText.Invoice_Delete;

            clock.Start();

            for (var i = 0; i < My.AppSettings.NbTestItems; i++)
            {
                using (var connection = My.ConnectionFactory())
                {
                    connection.Open();
                    affectedRows += connection.Execute(sql, new { InvoiceID = i + 1 });
                }
            }

            clock.Stop();

            if (showResult)
            {
                My.Result.Show(this, sender, clock, affectedRows);
            }
        }

        public void EF6_Delete_Single_SaveChanges(object sender, bool showResult)
        {
            My.Database.Reset(My.AppSettings.NbTestItems, false, false);

            var affectedRows = 0;
            var clock = new Stopwatch();

            List<EntitiesContextEF6.Invoice> list;
            using (var context = new EntitiesContextEF6())
            {
                list = context.Invoices.ToList();
            }

            clock.Start();

            for (var i = 0; i < My.AppSettings.NbTestItems; i++)
            {
                using (var context = new EntitiesContextEF6())
                {
                    context.Invoices.Attach(list[i]);
                    context.Invoices.Remove(list[i]);
                    affectedRows += context.SaveChanges();
                }
            }

            clock.Stop();

            if (showResult)
            {
                My.Result.Show(this, sender, clock, affectedRows);
            }
        }

        #endregion

        #region Delete Many (500 Records, 1 Iterations)

        #endregion

        private void uiDapper_Delete_Many_Execute_Single_Click(object sender, EventArgs e)
        {
            // ENSURE JIT Compile
            Dapper_Delete_Many_Execute_Single(sender, false);

            // Benchmark Test
            Dapper_Delete_Many_Execute_Single(sender, true);
        }

        private void uiDapper_Delete_Many_Execute_Many_Click(object sender, EventArgs e)
        {
            // ENSURE JIT Compile
            Dapper_Delete_Many_Execute_Many(sender, false);

            // Benchmark Test
            Dapper_Delete_Many_Execute_Many(sender, true);
        }

        private void uiEF6_Delete_Many_SaveChanges_Bad_Click(object sender, EventArgs e)
        {
            // ENSURE JIT Compile
            EF6_Delete_Many_SaveChanges_Bad(sender, false);

            // Benchmark Test
            EF6_Delete_Many_SaveChanges_Bad(sender, true);
        }

        private void uiEF6_Delete_Many_SaveChanges_Good_Click(object sender, EventArgs e)
        {
            // ENSURE JIT Compile
            EF6_Delete_Many_SaveChanges_Good(sender, false);

            // Benchmark Test
            EF6_Delete_Many_SaveChanges_Good(sender, true);
        }


        private void uiEFCore_Delete_Many_EFCore_Click(object sender, EventArgs e)
        {
            // ENSURE JIT Compile
            EFCore_Delete_Many_EFCore(sender, false);

            // Benchmark Test
            EFCore_Delete_Many_EFCore(sender, true);
        }

        private void uiEF6_Delete_Many_BulkDelete_Click(object sender, EventArgs e)
        {
            // ENSURE JIT Compile
            EF6_Delete_Many_BulkDelete(sender, false);

            // Benchmark Test
            EF6_Delete_Many_BulkDelete(sender, true);
        }

        private void Dapper_Delete_Many_Execute_Single(object sender, bool showResult)
        {
            My.Database.Reset(My.AppSettings.NbTestItems, false, false);

            var sql = My.SqlText.Invoice_Delete;

            var clock = new Stopwatch();

            int affectedRows = 0;
            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                clock.Start();
                for (var i = 0; i < My.AppSettings.NbTestItems; i++)
                {
                    affectedRows += connection.Execute(sql, new { InvoiceID = i + 1 });
                }
                clock.Stop();
            }

            if (showResult)
            {
                My.Result.Show(this, sender, clock, affectedRows);
            }
        }

        private void Dapper_Delete_Many_Execute_Many(object sender, bool showResult)
        {
            My.Database.Reset(My.AppSettings.NbTestItems, false, false);

            var sql = My.SqlText.Invoice_Delete;

            var clock = new Stopwatch();
        

            var affectedRows = 0;
            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var parameters = new List<object>();
                for (var i = 0; i < My.AppSettings.NbTestItems; i++)
                {
                    parameters.Add(new { InvoiceID = i + 1 });
                }

                clock.Start();
                affectedRows = connection.Execute(sql, parameters);
                clock.Stop();
            }

            if (showResult)
            {
                My.Result.Show(this, sender, clock, affectedRows);
            }
        }

        private void EF6_Delete_Many_SaveChanges_Bad(object sender, bool showResult)
        {
            My.Database.Reset(My.AppSettings.NbTestItems, false, false);

            var clock = new Stopwatch();

            var affectedRows = 0;

            using (var context = new EntitiesContextEF6())
            {
                var list = context.Invoices.Take(My.AppSettings.NbTestItems).ToList();

                clock.Start();
                for (int i = 0; i < My.AppSettings.NbTestItems; i++)
                {
                    context.Invoices.Remove(list[i]);
                    affectedRows += context.SaveChanges();
                }
                clock.Stop();
            }

            if (showResult)
            {
                My.Result.Show(this, sender, clock, My.AppSettings.NbTestItems);
            }
        }

        private void EF6_Delete_Many_SaveChanges_Good(object sender, bool showResult)
        {
            My.Database.Reset(My.AppSettings.NbTestItems, false, false);

            var clock = new Stopwatch();

            var affectedRows = 0;

            using (var context = new EntitiesContextEF6())
            {
                context.Invoices.RemoveRange(context.Invoices.Take(My.AppSettings.NbTestItems));

                clock.Start();
                affectedRows = context.SaveChanges();
                clock.Stop();
            }

            if (showResult)
            {
                My.Result.Show(this, sender, clock, My.AppSettings.NbTestItems);
            }
        }

        private void EFCore_Delete_Many_EFCore(object sender, bool showResult)
        {
            My.Database.Reset(My.AppSettings.NbTestItems, false, false);

            var clock = new Stopwatch();

            var affectedRows = 0;

            using (var context = new EntitiesContextEFCore())
            {
                context.Invoices.RemoveRange(context.Invoices.Take(My.AppSettings.NbTestItems));

                clock.Start();
                affectedRows = context.SaveChanges();
                clock.Stop();
            }

            if (showResult)
            {
                My.Result.Show(this, sender, clock, My.AppSettings.NbTestItems);
            }
        }


        private void EF6_Delete_Many_BulkDelete(object sender, bool showResult)
        {
            My.Database.Reset(My.AppSettings.NbTestItems, false, false);

            var clock = new Stopwatch();

            var affectedRows = 0;

            using (var context = new EntitiesContextEF6())
            {
                var list = context.Invoices.Take(My.AppSettings.NbTestItems).ToList();

                clock.Start();
                context.BulkDelete(list);
                clock.Stop();
            }

            if (showResult)
            {
                My.Result.Show(this, sender, clock, My.AppSettings.NbTestItems);
            }
        }

    }
}