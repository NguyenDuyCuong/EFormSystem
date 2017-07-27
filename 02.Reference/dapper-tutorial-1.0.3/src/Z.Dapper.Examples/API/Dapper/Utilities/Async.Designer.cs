namespace Z.Dapper.Examples.API.Dapper.Utilities
{
    partial class Async
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiQuerySingleAsync = new System.Windows.Forms.Button();
            this.uiQuerySingleOrDefaultAsync = new System.Windows.Forms.Button();
            this.uiQueryFirstOrDefaultAsync = new System.Windows.Forms.Button();
            this.uiQueryFirstAsync = new System.Windows.Forms.Button();
            this.uiQueryAsync = new System.Windows.Forms.Button();
            this.uiExecuteAsync = new System.Windows.Forms.Button();
            this.uiQueryMultipleAsync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiQuerySingleAsync
            // 
            this.uiQuerySingleAsync.Location = new System.Drawing.Point(20, 180);
            this.uiQuerySingleAsync.Name = "uiQuerySingleAsync";
            this.uiQuerySingleAsync.Size = new System.Drawing.Size(245, 23);
            this.uiQuerySingleAsync.TabIndex = 4;
            this.uiQuerySingleAsync.Text = "QuerySingleAsync";
            this.uiQuerySingleAsync.UseVisualStyleBackColor = true;
            this.uiQuerySingleAsync.Click += new System.EventHandler(this.QuerySingleAsync);
            // 
            // uiQuerySingleOrDefaultAsync
            // 
            this.uiQuerySingleOrDefaultAsync.Location = new System.Drawing.Point(20, 220);
            this.uiQuerySingleOrDefaultAsync.Name = "uiQuerySingleOrDefaultAsync";
            this.uiQuerySingleOrDefaultAsync.Size = new System.Drawing.Size(245, 23);
            this.uiQuerySingleOrDefaultAsync.TabIndex = 5;
            this.uiQuerySingleOrDefaultAsync.Text = "QuerySingleOrDefaultAsync";
            this.uiQuerySingleOrDefaultAsync.UseVisualStyleBackColor = true;
            this.uiQuerySingleOrDefaultAsync.Click += new System.EventHandler(this.QuerySingleOrDefaultAsync);
            // 
            // uiQueryFirstOrDefaultAsync
            // 
            this.uiQueryFirstOrDefaultAsync.Location = new System.Drawing.Point(20, 140);
            this.uiQueryFirstOrDefaultAsync.Name = "uiQueryFirstOrDefaultAsync";
            this.uiQueryFirstOrDefaultAsync.Size = new System.Drawing.Size(245, 23);
            this.uiQueryFirstOrDefaultAsync.TabIndex = 3;
            this.uiQueryFirstOrDefaultAsync.Text = "QueryFirstOrDefaultAsync";
            this.uiQueryFirstOrDefaultAsync.UseVisualStyleBackColor = true;
            this.uiQueryFirstOrDefaultAsync.Click += new System.EventHandler(this.QueryFirstOrDefaultAsync);
            // 
            // uiQueryFirstAsync
            // 
            this.uiQueryFirstAsync.Location = new System.Drawing.Point(20, 100);
            this.uiQueryFirstAsync.Name = "uiQueryFirstAsync";
            this.uiQueryFirstAsync.Size = new System.Drawing.Size(245, 23);
            this.uiQueryFirstAsync.TabIndex = 2;
            this.uiQueryFirstAsync.Text = "QueryFirstAsync";
            this.uiQueryFirstAsync.UseVisualStyleBackColor = true;
            this.uiQueryFirstAsync.Click += new System.EventHandler(this.QueryFirstAsync);
            // 
            // uiQueryAsync
            // 
            this.uiQueryAsync.Location = new System.Drawing.Point(20, 60);
            this.uiQueryAsync.Name = "uiQueryAsync";
            this.uiQueryAsync.Size = new System.Drawing.Size(245, 23);
            this.uiQueryAsync.TabIndex = 1;
            this.uiQueryAsync.Text = "QueryAsync";
            this.uiQueryAsync.UseVisualStyleBackColor = true;
            this.uiQueryAsync.Click += new System.EventHandler(this.QueryAsync);
            // 
            // uiExecuteAsync
            // 
            this.uiExecuteAsync.Location = new System.Drawing.Point(20, 20);
            this.uiExecuteAsync.Name = "uiExecuteAsync";
            this.uiExecuteAsync.Size = new System.Drawing.Size(245, 23);
            this.uiExecuteAsync.TabIndex = 0;
            this.uiExecuteAsync.Text = "ExecuteAsync";
            this.uiExecuteAsync.UseVisualStyleBackColor = true;
            this.uiExecuteAsync.Click += new System.EventHandler(this.ExecuteAsync);
            // 
            // uiQueryMultipleAsync
            // 
            this.uiQueryMultipleAsync.Location = new System.Drawing.Point(20, 260);
            this.uiQueryMultipleAsync.Name = "uiQueryMultipleAsync";
            this.uiQueryMultipleAsync.Size = new System.Drawing.Size(245, 23);
            this.uiQueryMultipleAsync.TabIndex = 6;
            this.uiQueryMultipleAsync.Text = "QueryMultipleAsync";
            this.uiQueryMultipleAsync.UseVisualStyleBackColor = true;
            this.uiQueryMultipleAsync.Click += new System.EventHandler(this.QueryMultipleAsync);
            // 
            // Async
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 301);
            this.Controls.Add(this.uiQueryMultipleAsync);
            this.Controls.Add(this.uiExecuteAsync);
            this.Controls.Add(this.uiQuerySingleAsync);
            this.Controls.Add(this.uiQuerySingleOrDefaultAsync);
            this.Controls.Add(this.uiQueryFirstOrDefaultAsync);
            this.Controls.Add(this.uiQueryFirstAsync);
            this.Controls.Add(this.uiQueryAsync);
            this.Name = "Async";
            this.Text = "Async";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiQuerySingleAsync;
        private System.Windows.Forms.Button uiQuerySingleOrDefaultAsync;
        private System.Windows.Forms.Button uiQueryFirstOrDefaultAsync;
        private System.Windows.Forms.Button uiQueryFirstAsync;
        private System.Windows.Forms.Button uiQueryAsync;
        private System.Windows.Forms.Button uiExecuteAsync;
        private System.Windows.Forms.Button uiQueryMultipleAsync;
    }
}