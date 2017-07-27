namespace Z.Dapper.Examples.API.Dapper.Result
{
    partial class Multi_Type
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
            this.uiMultiType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiMultiType
            // 
            this.uiMultiType.Location = new System.Drawing.Point(20, 20);
            this.uiMultiType.Name = "uiMultiType";
            this.uiMultiType.Size = new System.Drawing.Size(245, 23);
            this.uiMultiType.TabIndex = 0;
            this.uiMultiType.Text = "Multi-Type";
            this.uiMultiType.UseVisualStyleBackColor = true;
            this.uiMultiType.Click += new System.EventHandler(this.MultiType);
            // 
            // Multi_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiMultiType);
            this.Name = "Multi_Type";
            this.Text = "Result - Multi-Type";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiMultiType;
    }
}