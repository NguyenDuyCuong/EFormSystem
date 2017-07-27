namespace Z.Dapper.Examples.API.DapperContrib.DataAnnotations
{
    partial class Table
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
            this.uiGet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiGet
            // 
            this.uiGet.Location = new System.Drawing.Point(20, 20);
            this.uiGet.Name = "uiGet";
            this.uiGet.Size = new System.Drawing.Size(245, 23);
            this.uiGet.TabIndex = 4;
            this.uiGet.Text = "Get";
            this.uiGet.UseVisualStyleBackColor = true;
            this.uiGet.Click += new System.EventHandler(this.Get);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiGet);
            this.Name = "Table";
            this.Text = "Data Annoation - Table";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiGet;
    }
}