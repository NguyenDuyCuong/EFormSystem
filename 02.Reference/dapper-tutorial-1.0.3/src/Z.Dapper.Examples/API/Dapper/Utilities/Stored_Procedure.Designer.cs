namespace Z.Dapper.Examples.API.Dapper.Utilities
{
    partial class Stored_Procedure
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
            this.uiExecute_Single = new System.Windows.Forms.Button();
            this.uiExecute_Many = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiExecute_Single
            // 
            this.uiExecute_Single.Location = new System.Drawing.Point(20, 20);
            this.uiExecute_Single.Name = "uiExecute_Single";
            this.uiExecute_Single.Size = new System.Drawing.Size(245, 23);
            this.uiExecute_Single.TabIndex = 0;
            this.uiExecute_Single.Text = "Execute (Single)";
            this.uiExecute_Single.UseVisualStyleBackColor = true;
            this.uiExecute_Single.Click += new System.EventHandler(this.Execute_Single);
            // 
            // uiExecute_Many
            // 
            this.uiExecute_Many.Location = new System.Drawing.Point(20, 60);
            this.uiExecute_Many.Name = "uiExecute_Many";
            this.uiExecute_Many.Size = new System.Drawing.Size(245, 23);
            this.uiExecute_Many.TabIndex = 1;
            this.uiExecute_Many.Text = "Execute (Many)";
            this.uiExecute_Many.UseVisualStyleBackColor = true;
            this.uiExecute_Many.Click += new System.EventHandler(this.Execute_Many);
            // 
            // Stored_Procedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiExecute_Many);
            this.Controls.Add(this.uiExecute_Single);
            this.Name = "Stored_Procedure";
            this.Text = "Stored Procedure";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiExecute_Single;
        private System.Windows.Forms.Button uiExecute_Many;
    }
}