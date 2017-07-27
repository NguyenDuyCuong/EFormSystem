namespace Z.Dapper.Examples.API.Dapper.Parameter
{
    partial class String
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
            this.uiQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiQuery
            // 
            this.uiQuery.Location = new System.Drawing.Point(20, 20);
            this.uiQuery.Name = "uiQuery";
            this.uiQuery.Size = new System.Drawing.Size(245, 23);
            this.uiQuery.TabIndex = 0;
            this.uiQuery.Text = "Query";
            this.uiQuery.UseVisualStyleBackColor = true;
            this.uiQuery.Click += new System.EventHandler(this.Query);
            // 
            // String
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiQuery);
            this.Name = "String";
            this.Text = "Parameter - String";
            this.Click += new System.EventHandler(this.Query);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiQuery;
    }
}