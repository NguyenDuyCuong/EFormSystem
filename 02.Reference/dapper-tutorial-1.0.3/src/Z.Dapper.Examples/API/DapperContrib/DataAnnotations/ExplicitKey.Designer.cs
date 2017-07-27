namespace Z.Dapper.Examples.API.DapperContrib.DataAnnotations
{
    partial class ExplicitKey
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
            this.uiInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiInsert
            // 
            this.uiInsert.Location = new System.Drawing.Point(20, 20);
            this.uiInsert.Name = "uiInsert";
            this.uiInsert.Size = new System.Drawing.Size(245, 23);
            this.uiInsert.TabIndex = 2;
            this.uiInsert.Text = "Insert";
            this.uiInsert.UseVisualStyleBackColor = true;
            this.uiInsert.Click += new System.EventHandler(this.Insert);
            // 
            // ExplicitKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiInsert);
            this.Name = "ExplicitKey";
            this.Text = "Data Annoation - ExplicitKey";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiInsert;
    }
}