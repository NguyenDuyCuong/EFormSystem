namespace Z.Dapper.Examples.API.Dapper.Methods
{
    partial class Query
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
            this.uiAnonymous = new System.Windows.Forms.Button();
            this.uiStronglyTyped = new System.Windows.Forms.Button();
            this.uiMultiMapping_OneToOne = new System.Windows.Forms.Button();
            this.uiMultiType = new System.Windows.Forms.Button();
            this.uiMultiMapping_OneToMany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiAnonymous
            // 
            this.uiAnonymous.Location = new System.Drawing.Point(20, 20);
            this.uiAnonymous.Name = "uiAnonymous";
            this.uiAnonymous.Size = new System.Drawing.Size(245, 23);
            this.uiAnonymous.TabIndex = 0;
            this.uiAnonymous.Text = "Anonymous";
            this.uiAnonymous.UseVisualStyleBackColor = true;
            this.uiAnonymous.Click += new System.EventHandler(this.Anonymous);
            // 
            // uiStronglyTyped
            // 
            this.uiStronglyTyped.Location = new System.Drawing.Point(20, 60);
            this.uiStronglyTyped.Name = "uiStronglyTyped";
            this.uiStronglyTyped.Size = new System.Drawing.Size(245, 23);
            this.uiStronglyTyped.TabIndex = 1;
            this.uiStronglyTyped.Text = "Strongly Typed";
            this.uiStronglyTyped.UseVisualStyleBackColor = true;
            this.uiStronglyTyped.Click += new System.EventHandler(this.StronglyTyped);
            // 
            // uiMultiMapping_OneToOne
            // 
            this.uiMultiMapping_OneToOne.Location = new System.Drawing.Point(20, 100);
            this.uiMultiMapping_OneToOne.Name = "uiMultiMapping_OneToOne";
            this.uiMultiMapping_OneToOne.Size = new System.Drawing.Size(245, 23);
            this.uiMultiMapping_OneToOne.TabIndex = 2;
            this.uiMultiMapping_OneToOne.Text = "Multi-Mapping (One to One)";
            this.uiMultiMapping_OneToOne.UseVisualStyleBackColor = true;
            this.uiMultiMapping_OneToOne.Click += new System.EventHandler(this.MultiMapping_OneToOne);
            // 
            // uiMultiType
            // 
            this.uiMultiType.Location = new System.Drawing.Point(20, 180);
            this.uiMultiType.Name = "uiMultiType";
            this.uiMultiType.Size = new System.Drawing.Size(245, 23);
            this.uiMultiType.TabIndex = 4;
            this.uiMultiType.Text = "Multi-Type";
            this.uiMultiType.UseVisualStyleBackColor = true;
            this.uiMultiType.Click += new System.EventHandler(this.MultiType);
            // 
            // uiMultiMapping_OneToMany
            // 
            this.uiMultiMapping_OneToMany.Location = new System.Drawing.Point(20, 140);
            this.uiMultiMapping_OneToMany.Name = "uiMultiMapping_OneToMany";
            this.uiMultiMapping_OneToMany.Size = new System.Drawing.Size(245, 23);
            this.uiMultiMapping_OneToMany.TabIndex = 3;
            this.uiMultiMapping_OneToMany.Text = "Multi-Mapping (One to Many)";
            this.uiMultiMapping_OneToMany.UseVisualStyleBackColor = true;
            this.uiMultiMapping_OneToMany.Click += new System.EventHandler(this.MultiMapping_OneToMany);
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiMultiMapping_OneToMany);
            this.Controls.Add(this.uiMultiType);
            this.Controls.Add(this.uiMultiMapping_OneToOne);
            this.Controls.Add(this.uiStronglyTyped);
            this.Controls.Add(this.uiAnonymous);
            this.Name = "Query";
            this.Text = "Query";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiAnonymous;
        private System.Windows.Forms.Button uiStronglyTyped;
        private System.Windows.Forms.Button uiMultiMapping_OneToOne;
        private System.Windows.Forms.Button uiMultiType;
        private System.Windows.Forms.Button uiMultiMapping_OneToMany;
    }
}