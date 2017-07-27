namespace Z.Dapper.Examples.API.Dapper.Result
{
    partial class Strongly_Typed
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
            this.uiQuerySingle = new System.Windows.Forms.Button();
            this.uiQuerySingleOrDefault = new System.Windows.Forms.Button();
            this.uiQueryFirstOrDefault = new System.Windows.Forms.Button();
            this.uiQueryFirst = new System.Windows.Forms.Button();
            this.uiQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiQuerySingle
            // 
            this.uiQuerySingle.Location = new System.Drawing.Point(20, 140);
            this.uiQuerySingle.Name = "uiQuerySingle";
            this.uiQuerySingle.Size = new System.Drawing.Size(245, 23);
            this.uiQuerySingle.TabIndex = 3;
            this.uiQuerySingle.Text = "QuerySingle";
            this.uiQuerySingle.UseVisualStyleBackColor = true;
            this.uiQuerySingle.Click += new System.EventHandler(this.QuerySingle);
            // 
            // uiQuerySingleOrDefault
            // 
            this.uiQuerySingleOrDefault.Location = new System.Drawing.Point(20, 180);
            this.uiQuerySingleOrDefault.Name = "uiQuerySingleOrDefault";
            this.uiQuerySingleOrDefault.Size = new System.Drawing.Size(245, 23);
            this.uiQuerySingleOrDefault.TabIndex = 4;
            this.uiQuerySingleOrDefault.Text = "QuerySingleOrDefault";
            this.uiQuerySingleOrDefault.UseVisualStyleBackColor = true;
            this.uiQuerySingleOrDefault.Click += new System.EventHandler(this.QuerySingleOrDefault);
            // 
            // uiQueryFirstOrDefault
            // 
            this.uiQueryFirstOrDefault.Location = new System.Drawing.Point(20, 100);
            this.uiQueryFirstOrDefault.Name = "uiQueryFirstOrDefault";
            this.uiQueryFirstOrDefault.Size = new System.Drawing.Size(245, 23);
            this.uiQueryFirstOrDefault.TabIndex = 2;
            this.uiQueryFirstOrDefault.Text = "QueryFirstOrDefault";
            this.uiQueryFirstOrDefault.UseVisualStyleBackColor = true;
            this.uiQueryFirstOrDefault.Click += new System.EventHandler(this.QueryFirstOrDefault);
            // 
            // uiQueryFirst
            // 
            this.uiQueryFirst.Location = new System.Drawing.Point(20, 60);
            this.uiQueryFirst.Name = "uiQueryFirst";
            this.uiQueryFirst.Size = new System.Drawing.Size(245, 23);
            this.uiQueryFirst.TabIndex = 1;
            this.uiQueryFirst.Text = "QueryFirst";
            this.uiQueryFirst.UseVisualStyleBackColor = true;
            this.uiQueryFirst.Click += new System.EventHandler(this.QueryFirst);
            // 
            // uiQuery
            // 
            this.uiQuery.Location = new System.Drawing.Point(20, 20);
            this.uiQuery.Name = "uiQuery";
            this.uiQuery.Size = new System.Drawing.Size(245, 23);
            this.uiQuery.TabIndex = 0;
            this.uiQuery.Text = "Query";
            this.uiQuery.UseVisualStyleBackColor = true;
            this.uiQuery.Click += new System.EventHandler(this.Query);
            // 
            // Strongly_Typed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uiQuerySingle);
            this.Controls.Add(this.uiQuerySingleOrDefault);
            this.Controls.Add(this.uiQueryFirstOrDefault);
            this.Controls.Add(this.uiQueryFirst);
            this.Controls.Add(this.uiQuery);
            this.Name = "Strongly_Typed";
            this.Text = "Result - Strongly Typed";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiQuerySingle;
        private System.Windows.Forms.Button uiQuerySingleOrDefault;
        private System.Windows.Forms.Button uiQueryFirstOrDefault;
        private System.Windows.Forms.Button uiQueryFirst;
        private System.Windows.Forms.Button uiQuery;
    }
}