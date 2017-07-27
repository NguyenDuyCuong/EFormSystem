namespace Z.Dapper.Examples.API.Dapper.Methods
{
    partial class QuerySingleOrDefault
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
            this.uiStronglyTyped = new System.Windows.Forms.Button();
            this.uiAnonymous = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // QuerySingleOrDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiStronglyTyped);
            this.Controls.Add(this.uiAnonymous);
            this.Name = "QuerySingleOrDefault";
            this.Text = "QuerySingleOrDefault";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button uiStronglyTyped;
        private System.Windows.Forms.Button uiAnonymous;
    }
}