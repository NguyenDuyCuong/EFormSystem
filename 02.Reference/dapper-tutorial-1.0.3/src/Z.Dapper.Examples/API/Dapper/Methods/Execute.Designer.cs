namespace Z.Dapper.Examples.API.Dapper.Methods
{
    partial class Execute
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
            this.uiDelete_Many = new System.Windows.Forms.Button();
            this.uiUpdate_Single = new System.Windows.Forms.Button();
            this.uiInsert_Single = new System.Windows.Forms.Button();
            this.uiDelete_Single = new System.Windows.Forms.Button();
            this.uiUpdate_Many = new System.Windows.Forms.Button();
            this.uiSingle_Many = new System.Windows.Forms.Button();
            this.uiStoredProcedure_Many = new System.Windows.Forms.Button();
            this.uiStoredProcedure_Single = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiDelete_Many
            // 
            this.uiDelete_Many.Location = new System.Drawing.Point(20, 300);
            this.uiDelete_Many.Name = "uiDelete_Many";
            this.uiDelete_Many.Size = new System.Drawing.Size(245, 23);
            this.uiDelete_Many.TabIndex = 7;
            this.uiDelete_Many.Text = "Delete (Many)";
            this.uiDelete_Many.UseVisualStyleBackColor = true;
            this.uiDelete_Many.Click += new System.EventHandler(this.Delete_Many);
            // 
            // uiUpdate_Single
            // 
            this.uiUpdate_Single.Location = new System.Drawing.Point(20, 180);
            this.uiUpdate_Single.Name = "uiUpdate_Single";
            this.uiUpdate_Single.Size = new System.Drawing.Size(245, 23);
            this.uiUpdate_Single.TabIndex = 4;
            this.uiUpdate_Single.Text = "Update (Single)";
            this.uiUpdate_Single.UseVisualStyleBackColor = true;
            this.uiUpdate_Single.Click += new System.EventHandler(this.Update_Single);
            // 
            // uiInsert_Single
            // 
            this.uiInsert_Single.Location = new System.Drawing.Point(20, 100);
            this.uiInsert_Single.Name = "uiInsert_Single";
            this.uiInsert_Single.Size = new System.Drawing.Size(245, 23);
            this.uiInsert_Single.TabIndex = 2;
            this.uiInsert_Single.Text = "Insert (Single)";
            this.uiInsert_Single.UseVisualStyleBackColor = true;
            this.uiInsert_Single.Click += new System.EventHandler(this.Insert_Single);
            // 
            // uiDelete_Single
            // 
            this.uiDelete_Single.Location = new System.Drawing.Point(20, 260);
            this.uiDelete_Single.Name = "uiDelete_Single";
            this.uiDelete_Single.Size = new System.Drawing.Size(245, 23);
            this.uiDelete_Single.TabIndex = 6;
            this.uiDelete_Single.Text = "Delete (Single)";
            this.uiDelete_Single.UseVisualStyleBackColor = true;
            this.uiDelete_Single.Click += new System.EventHandler(this.Delete_Single);
            // 
            // uiUpdate_Many
            // 
            this.uiUpdate_Many.Location = new System.Drawing.Point(20, 220);
            this.uiUpdate_Many.Name = "uiUpdate_Many";
            this.uiUpdate_Many.Size = new System.Drawing.Size(245, 23);
            this.uiUpdate_Many.TabIndex = 5;
            this.uiUpdate_Many.Text = "Update (Many)";
            this.uiUpdate_Many.UseVisualStyleBackColor = true;
            this.uiUpdate_Many.Click += new System.EventHandler(this.Update_Many);
            // 
            // uiSingle_Many
            // 
            this.uiSingle_Many.Location = new System.Drawing.Point(20, 140);
            this.uiSingle_Many.Name = "uiSingle_Many";
            this.uiSingle_Many.Size = new System.Drawing.Size(245, 23);
            this.uiSingle_Many.TabIndex = 3;
            this.uiSingle_Many.Text = "Insert (Many)";
            this.uiSingle_Many.UseVisualStyleBackColor = true;
            this.uiSingle_Many.Click += new System.EventHandler(this.Insert_Many);
            // 
            // uiStoredProcedure_Many
            // 
            this.uiStoredProcedure_Many.Location = new System.Drawing.Point(20, 60);
            this.uiStoredProcedure_Many.Name = "uiStoredProcedure_Many";
            this.uiStoredProcedure_Many.Size = new System.Drawing.Size(245, 23);
            this.uiStoredProcedure_Many.TabIndex = 1;
            this.uiStoredProcedure_Many.Text = "Stored Procedure (Many)";
            this.uiStoredProcedure_Many.UseVisualStyleBackColor = true;
            this.uiStoredProcedure_Many.Click += new System.EventHandler(this.StoredProcedure_Many);
            // 
            // uiStoredProcedure_Single
            // 
            this.uiStoredProcedure_Single.Location = new System.Drawing.Point(20, 20);
            this.uiStoredProcedure_Single.Name = "uiStoredProcedure_Single";
            this.uiStoredProcedure_Single.Size = new System.Drawing.Size(245, 23);
            this.uiStoredProcedure_Single.TabIndex = 0;
            this.uiStoredProcedure_Single.Text = "Stored Procedure (Single)";
            this.uiStoredProcedure_Single.UseVisualStyleBackColor = true;
            this.uiStoredProcedure_Single.Click += new System.EventHandler(this.StoredProcedure_Single);
            // 
            // Execute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 341);
            this.Controls.Add(this.uiStoredProcedure_Many);
            this.Controls.Add(this.uiStoredProcedure_Single);
            this.Controls.Add(this.uiDelete_Single);
            this.Controls.Add(this.uiUpdate_Many);
            this.Controls.Add(this.uiSingle_Many);
            this.Controls.Add(this.uiDelete_Many);
            this.Controls.Add(this.uiUpdate_Single);
            this.Controls.Add(this.uiInsert_Single);
            this.Name = "Execute";
            this.Text = "Execute";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiDelete_Many;
        private System.Windows.Forms.Button uiUpdate_Single;
        private System.Windows.Forms.Button uiInsert_Single;
        private System.Windows.Forms.Button uiDelete_Single;
        private System.Windows.Forms.Button uiUpdate_Many;
        private System.Windows.Forms.Button uiSingle_Many;
        private System.Windows.Forms.Button uiStoredProcedure_Many;
        private System.Windows.Forms.Button uiStoredProcedure_Single;
    }
}