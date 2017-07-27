namespace Z.Dapper.Examples.Performance_Comparison.Dapper_vs_EF6
{
    partial class Delete
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
            this.uiDapper_Delete_Many_Execute_Single = new System.Windows.Forms.Button();
            this.uiDapper_Delete_Many_Execute_Many = new System.Windows.Forms.Button();
            this.uiEF6_Delete_Many_SaveChanges_Bad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiDapper_Delete_Single_Execute_Single = new System.Windows.Forms.Button();
            this.uiEF6_Delete_Single_SaveChanges = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uiEFCore_Delete_Many_EFCore = new System.Windows.Forms.Button();
            this.uiEF6_Delete_Many_SaveChanges_Good = new System.Windows.Forms.Button();
            this.uiEF6_Delete_Many_BulkDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiDapper_Delete_Many_Execute_Single
            // 
            this.uiDapper_Delete_Many_Execute_Single.Location = new System.Drawing.Point(5, 20);
            this.uiDapper_Delete_Many_Execute_Single.Name = "uiDapper_Delete_Many_Execute_Single";
            this.uiDapper_Delete_Many_Execute_Single.Size = new System.Drawing.Size(190, 23);
            this.uiDapper_Delete_Many_Execute_Single.TabIndex = 2;
            this.uiDapper_Delete_Many_Execute_Single.Text = "Dapper - Execute Single";
            this.uiDapper_Delete_Many_Execute_Single.UseVisualStyleBackColor = true;
            this.uiDapper_Delete_Many_Execute_Single.Click += new System.EventHandler(this.uiDapper_Delete_Many_Execute_Single_Click);
            // 
            // uiDapper_Delete_Many_Execute_Many
            // 
            this.uiDapper_Delete_Many_Execute_Many.Location = new System.Drawing.Point(5, 60);
            this.uiDapper_Delete_Many_Execute_Many.Name = "uiDapper_Delete_Many_Execute_Many";
            this.uiDapper_Delete_Many_Execute_Many.Size = new System.Drawing.Size(190, 23);
            this.uiDapper_Delete_Many_Execute_Many.TabIndex = 3;
            this.uiDapper_Delete_Many_Execute_Many.Text = "Dapper - Execute Many";
            this.uiDapper_Delete_Many_Execute_Many.UseVisualStyleBackColor = true;
            this.uiDapper_Delete_Many_Execute_Many.Click += new System.EventHandler(this.uiDapper_Delete_Many_Execute_Many_Click);
            // 
            // uiEF6_Delete_Many_SaveChanges_Bad
            // 
            this.uiEF6_Delete_Many_SaveChanges_Bad.Location = new System.Drawing.Point(5, 100);
            this.uiEF6_Delete_Many_SaveChanges_Bad.Name = "uiEF6_Delete_Many_SaveChanges_Bad";
            this.uiEF6_Delete_Many_SaveChanges_Bad.Size = new System.Drawing.Size(190, 23);
            this.uiEF6_Delete_Many_SaveChanges_Bad.TabIndex = 4;
            this.uiEF6_Delete_Many_SaveChanges_Bad.Text = "EF6 - SaveChanges - BAD";
            this.uiEF6_Delete_Many_SaveChanges_Bad.UseVisualStyleBackColor = true;
            this.uiEF6_Delete_Many_SaveChanges_Bad.Click += new System.EventHandler(this.uiEF6_Delete_Many_SaveChanges_Bad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiDapper_Delete_Single_Execute_Single);
            this.groupBox1.Controls.Add(this.uiEF6_Delete_Single_SaveChanges);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 210);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DELETE - 1 record, 500 iterations";
            // 
            // uiDapper_Delete_Single_Execute_Single
            // 
            this.uiDapper_Delete_Single_Execute_Single.Location = new System.Drawing.Point(5, 20);
            this.uiDapper_Delete_Single_Execute_Single.Name = "uiDapper_Delete_Single_Execute_Single";
            this.uiDapper_Delete_Single_Execute_Single.Size = new System.Drawing.Size(190, 23);
            this.uiDapper_Delete_Single_Execute_Single.TabIndex = 5;
            this.uiDapper_Delete_Single_Execute_Single.Text = "Dapper - Execute Single";
            this.uiDapper_Delete_Single_Execute_Single.UseVisualStyleBackColor = true;
            this.uiDapper_Delete_Single_Execute_Single.Click += new System.EventHandler(this.uiDapper_Delete_Single_Execute_Single_Click);
            // 
            // uiEF6_Delete_Single_SaveChanges
            // 
            this.uiEF6_Delete_Single_SaveChanges.Location = new System.Drawing.Point(5, 100);
            this.uiEF6_Delete_Single_SaveChanges.Name = "uiEF6_Delete_Single_SaveChanges";
            this.uiEF6_Delete_Single_SaveChanges.Size = new System.Drawing.Size(190, 23);
            this.uiEF6_Delete_Single_SaveChanges.TabIndex = 7;
            this.uiEF6_Delete_Single_SaveChanges.Text = "EF6 - SaveChanges";
            this.uiEF6_Delete_Single_SaveChanges.UseVisualStyleBackColor = true;
            this.uiEF6_Delete_Single_SaveChanges.Click += new System.EventHandler(this.uiEF6_Delete_Single_SaveChanges_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uiEFCore_Delete_Many_EFCore);
            this.groupBox2.Controls.Add(this.uiEF6_Delete_Many_SaveChanges_Good);
            this.groupBox2.Controls.Add(this.uiDapper_Delete_Many_Execute_Single);
            this.groupBox2.Controls.Add(this.uiDapper_Delete_Many_Execute_Many);
            this.groupBox2.Controls.Add(this.uiEF6_Delete_Many_SaveChanges_Bad);
            this.groupBox2.Location = new System.Drawing.Point(220, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 210);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DELETE - 500 records, 1 iterations";
            // 
            // uiEFCore_Delete_Many_EFCore
            // 
            this.uiEFCore_Delete_Many_EFCore.Location = new System.Drawing.Point(5, 180);
            this.uiEFCore_Delete_Many_EFCore.Name = "uiEFCore_Delete_Many_EFCore";
            this.uiEFCore_Delete_Many_EFCore.Size = new System.Drawing.Size(190, 23);
            this.uiEFCore_Delete_Many_EFCore.TabIndex = 6;
            this.uiEFCore_Delete_Many_EFCore.Text = "EF Core - SaveChanges";
            this.uiEFCore_Delete_Many_EFCore.UseVisualStyleBackColor = true;
            this.uiEFCore_Delete_Many_EFCore.Click += new System.EventHandler(this.uiEFCore_Delete_Many_EFCore_Click);
            // 
            // uiEF6_Delete_Many_SaveChanges_Good
            // 
            this.uiEF6_Delete_Many_SaveChanges_Good.Location = new System.Drawing.Point(5, 140);
            this.uiEF6_Delete_Many_SaveChanges_Good.Name = "uiEF6_Delete_Many_SaveChanges_Good";
            this.uiEF6_Delete_Many_SaveChanges_Good.Size = new System.Drawing.Size(190, 23);
            this.uiEF6_Delete_Many_SaveChanges_Good.TabIndex = 5;
            this.uiEF6_Delete_Many_SaveChanges_Good.Text = "EF6 - SaveChanges - GOOD";
            this.uiEF6_Delete_Many_SaveChanges_Good.UseVisualStyleBackColor = true;
            this.uiEF6_Delete_Many_SaveChanges_Good.Click += new System.EventHandler(this.uiEF6_Delete_Many_SaveChanges_Good_Click);
            // 
            // uiEF6_Delete_Many_BulkDelete
            // 
            this.uiEF6_Delete_Many_BulkDelete.Location = new System.Drawing.Point(225, 221);
            this.uiEF6_Delete_Many_BulkDelete.Name = "uiEF6_Delete_Many_BulkDelete";
            this.uiEF6_Delete_Many_BulkDelete.Size = new System.Drawing.Size(190, 23);
            this.uiEF6_Delete_Many_BulkDelete.TabIndex = 7;
            this.uiEF6_Delete_Many_BulkDelete.Text = "EF6 - BulkDelete";
            this.uiEF6_Delete_Many_BulkDelete.UseVisualStyleBackColor = true;
            this.uiEF6_Delete_Many_BulkDelete.Click += new System.EventHandler(this.uiEF6_Delete_Many_BulkDelete_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 265);
            this.Controls.Add(this.uiEF6_Delete_Many_BulkDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Delete";
            this.Text = "Dapper vs EF - DELETE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiDapper_Delete_Many_Execute_Single;
        private System.Windows.Forms.Button uiDapper_Delete_Many_Execute_Many;
        private System.Windows.Forms.Button uiEF6_Delete_Many_SaveChanges_Bad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button uiDapper_Delete_Single_Execute_Single;
        private System.Windows.Forms.Button uiEF6_Delete_Single_SaveChanges;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button uiEF6_Delete_Many_SaveChanges_Good;
        private System.Windows.Forms.Button uiEFCore_Delete_Many_EFCore;
        private System.Windows.Forms.Button uiEF6_Delete_Many_BulkDelete;
    }
}