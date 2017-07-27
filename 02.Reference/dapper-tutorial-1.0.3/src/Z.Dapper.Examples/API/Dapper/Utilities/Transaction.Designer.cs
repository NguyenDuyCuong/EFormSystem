namespace Z.Dapper.Examples.API.Dapper.Utilities
{
    partial class Transaction
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
            this.uiTransactionScope = new System.Windows.Forms.Button();
            this.uiTransaction_FromConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiTransactionScope
            // 
            this.uiTransactionScope.Location = new System.Drawing.Point(20, 60);
            this.uiTransactionScope.Name = "uiTransactionScope";
            this.uiTransactionScope.Size = new System.Drawing.Size(245, 23);
            this.uiTransactionScope.TabIndex = 1;
            this.uiTransactionScope.Text = "TransactionScope";
            this.uiTransactionScope.UseVisualStyleBackColor = true;
            this.uiTransactionScope.Click += new System.EventHandler(this.TransactionScope);
            // 
            // uiTransaction_FromConnection
            // 
            this.uiTransaction_FromConnection.Location = new System.Drawing.Point(20, 20);
            this.uiTransaction_FromConnection.Name = "uiTransaction_FromConnection";
            this.uiTransaction_FromConnection.Size = new System.Drawing.Size(245, 23);
            this.uiTransaction_FromConnection.TabIndex = 0;
            this.uiTransaction_FromConnection.Text = "Transaction (From Connection)";
            this.uiTransaction_FromConnection.UseVisualStyleBackColor = true;
            this.uiTransaction_FromConnection.Click += new System.EventHandler(this.Transaction_FromConnection);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiTransactionScope);
            this.Controls.Add(this.uiTransaction_FromConnection);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiTransactionScope;
        private System.Windows.Forms.Button uiTransaction_FromConnection;
    }
}