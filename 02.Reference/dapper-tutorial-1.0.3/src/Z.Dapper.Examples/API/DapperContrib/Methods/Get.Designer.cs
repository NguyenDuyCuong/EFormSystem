namespace Z.Dapper.Examples.API.DapperContrib.Methods
{
    partial class Get
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
            this.uiSingle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiSingle
            // 
            this.uiSingle.Location = new System.Drawing.Point(20, 20);
            this.uiSingle.Name = "uiSingle";
            this.uiSingle.Size = new System.Drawing.Size(245, 23);
            this.uiSingle.TabIndex = 0;
            this.uiSingle.Text = "Single";
            this.uiSingle.UseVisualStyleBackColor = true;
            this.uiSingle.Click += new System.EventHandler(this.Single);
            // 
            // Get
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiSingle);
            this.Name = "Get";
            this.Text = "Get";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiSingle;
    }
}