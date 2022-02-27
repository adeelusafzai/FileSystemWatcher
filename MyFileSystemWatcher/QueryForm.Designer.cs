namespace MyFileSystemWatcher
{
    partial class QueryForm
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
            this.query_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.query_btn = new System.Windows.Forms.Button();
            this.QueryView_grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.QueryView_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // query_box
            // 
            this.query_box.Location = new System.Drawing.Point(12, 34);
            this.query_box.Name = "query_box";
            this.query_box.Size = new System.Drawing.Size(850, 20);
            this.query_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Extension Query (Empty = Show All records,   Delete = Delete All Records, or Type" +
    " Sql Query)";
            // 
            // query_btn
            // 
            this.query_btn.Location = new System.Drawing.Point(868, 34);
            this.query_btn.Name = "query_btn";
            this.query_btn.Size = new System.Drawing.Size(75, 23);
            this.query_btn.TabIndex = 2;
            this.query_btn.Text = "Submit";
            this.query_btn.UseVisualStyleBackColor = true;
            this.query_btn.Click += new System.EventHandler(this.query_btn_Click);
            // 
            // QueryView_grid
            // 
            this.QueryView_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueryView_grid.Location = new System.Drawing.Point(12, 81);
            this.QueryView_grid.Name = "QueryView_grid";
            this.QueryView_grid.Size = new System.Drawing.Size(931, 249);
            this.QueryView_grid.TabIndex = 3;


            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 381);
            this.Controls.Add(this.QueryView_grid);
            this.Controls.Add(this.query_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.query_box);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QueryForm_FormClosing);
            this.Load += new System.EventHandler(this.QueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QueryView_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox query_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button query_btn;
        private System.Windows.Forms.DataGridView QueryView_grid;
    }
}