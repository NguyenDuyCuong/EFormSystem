namespace Z.Dapper.Examples.API.Dapper.Result
{
    partial class Multi_Mapping
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
            this.uiMultiMapping_OneToMany = new System.Windows.Forms.Button();
            this.uiMultiMapping_OneToOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiMultiMapping_OneToMany
            // 
            this.uiMultiMapping_OneToMany.Location = new System.Drawing.Point(20, 60);
            this.uiMultiMapping_OneToMany.Name = "uiMultiMapping_OneToMany";
            this.uiMultiMapping_OneToMany.Size = new System.Drawing.Size(245, 23);
            this.uiMultiMapping_OneToMany.TabIndex = 1;
            this.uiMultiMapping_OneToMany.Text = "Multi-Mapping (One to Many)";
            this.uiMultiMapping_OneToMany.UseVisualStyleBackColor = true;
            this.uiMultiMapping_OneToMany.Click += new System.EventHandler(this.MultiMapping_OneToMany);
            // 
            // uiMultiMapping_OneToOne
            // 
            this.uiMultiMapping_OneToOne.Location = new System.Drawing.Point(20, 20);
            this.uiMultiMapping_OneToOne.Name = "uiMultiMapping_OneToOne";
            this.uiMultiMapping_OneToOne.Size = new System.Drawing.Size(245, 23);
            this.uiMultiMapping_OneToOne.TabIndex = 0;
            this.uiMultiMapping_OneToOne.Text = "Multi-Mapping (One to One)";
            this.uiMultiMapping_OneToOne.UseVisualStyleBackColor = true;
            this.uiMultiMapping_OneToOne.Click += new System.EventHandler(this.MultiMapping_OneToOne);
            // 
            // Multi_Mapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiMultiMapping_OneToMany);
            this.Controls.Add(this.uiMultiMapping_OneToOne);
            this.Name = "Multi_Mapping";
            this.Text = "Result - Multi-Mapping";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiMultiMapping_OneToMany;
        private System.Windows.Forms.Button uiMultiMapping_OneToOne;
    }
}