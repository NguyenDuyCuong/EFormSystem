namespace Z.Dapper.Examples.API.DapperContrib.Methods
{
    partial class GetAll
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
            this.uiAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiAll
            // 
            this.uiAll.Location = new System.Drawing.Point(20, 20);
            this.uiAll.Name = "uiAll";
            this.uiAll.Size = new System.Drawing.Size(245, 23);
            this.uiAll.TabIndex = 0;
            this.uiAll.Text = "All";
            this.uiAll.UseVisualStyleBackColor = true;
            this.uiAll.Click += new System.EventHandler(this.All);
            // 
            // GetAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiAll);
            this.Name = "GetAll";
            this.Text = "GetAll";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiAll;
    }
}