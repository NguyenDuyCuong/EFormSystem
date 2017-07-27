namespace Z.Dapper.Examples.API.Dapper.Utilities
{
    partial class Buffered
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
            this.uiQuery_False = new System.Windows.Forms.Button();
            this.uiQuery_True = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiQuery_False
            // 
            this.uiQuery_False.Location = new System.Drawing.Point(20, 60);
            this.uiQuery_False.Name = "uiQuery_False";
            this.uiQuery_False.Size = new System.Drawing.Size(245, 23);
            this.uiQuery_False.TabIndex = 3;
            this.uiQuery_False.Text = "Query (False)";
            this.uiQuery_False.UseVisualStyleBackColor = true;
            this.uiQuery_False.Click += new System.EventHandler(this.Query_False);
            // 
            // uiQuery_True
            // 
            this.uiQuery_True.Location = new System.Drawing.Point(20, 20);
            this.uiQuery_True.Name = "uiQuery_True";
            this.uiQuery_True.Size = new System.Drawing.Size(245, 23);
            this.uiQuery_True.TabIndex = 2;
            this.uiQuery_True.Text = "Query (True)";
            this.uiQuery_True.UseVisualStyleBackColor = true;
            this.uiQuery_True.Click += new System.EventHandler(this.Query_True);
            // 
            // Buffered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiQuery_False);
            this.Controls.Add(this.uiQuery_True);
            this.Name = "Buffered";
            this.Text = "Buffered";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiQuery_False;
        private System.Windows.Forms.Button uiQuery_True;
    }
}