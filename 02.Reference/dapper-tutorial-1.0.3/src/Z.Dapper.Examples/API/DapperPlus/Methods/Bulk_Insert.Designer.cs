namespace Z.Dapper.Examples.API.DapperPlus.Methods
{
    partial class Bulk_Insert
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
            this.uiRelation_OneToMany = new System.Windows.Forms.Button();
            this.uiRelation_OneToOne = new System.Windows.Forms.Button();
            this.uiMany = new System.Windows.Forms.Button();
            this.uiSingle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiRelation_OneToMany
            // 
            this.uiRelation_OneToMany.Location = new System.Drawing.Point(20, 140);
            this.uiRelation_OneToMany.Name = "uiRelation_OneToMany";
            this.uiRelation_OneToMany.Size = new System.Drawing.Size(245, 23);
            this.uiRelation_OneToMany.TabIndex = 3;
            this.uiRelation_OneToMany.Text = "Relation (One to Many)";
            this.uiRelation_OneToMany.UseVisualStyleBackColor = true;
            this.uiRelation_OneToMany.Click += new System.EventHandler(this.Relation_OneToMany);
            // 
            // uiRelation_OneToOne
            // 
            this.uiRelation_OneToOne.Location = new System.Drawing.Point(20, 100);
            this.uiRelation_OneToOne.Name = "uiRelation_OneToOne";
            this.uiRelation_OneToOne.Size = new System.Drawing.Size(245, 23);
            this.uiRelation_OneToOne.TabIndex = 2;
            this.uiRelation_OneToOne.Text = "Relation (One to One)";
            this.uiRelation_OneToOne.UseVisualStyleBackColor = true;
            this.uiRelation_OneToOne.Click += new System.EventHandler(this.Relation_OneToOne);
            // 
            // uiMany
            // 
            this.uiMany.Location = new System.Drawing.Point(20, 60);
            this.uiMany.Name = "uiMany";
            this.uiMany.Size = new System.Drawing.Size(245, 23);
            this.uiMany.TabIndex = 1;
            this.uiMany.Text = "Many";
            this.uiMany.UseVisualStyleBackColor = true;
            this.uiMany.Click += new System.EventHandler(this.Many);
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
            // Bulk_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiRelation_OneToMany);
            this.Controls.Add(this.uiRelation_OneToOne);
            this.Controls.Add(this.uiMany);
            this.Controls.Add(this.uiSingle);
            this.Name = "Bulk_Insert";
            this.Text = "Bulk Insert";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiRelation_OneToMany;
        private System.Windows.Forms.Button uiRelation_OneToOne;
        private System.Windows.Forms.Button uiMany;
        private System.Windows.Forms.Button uiSingle;
    }
}