namespace myexcel
{
    partial class Excel
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
            this.button1 = new System.Windows.Forms.Button();
            this.add_row = new System.Windows.Forms.Button();
            this.add_col = new System.Windows.Forms.Button();
            this.remove_row = new System.Windows.Forms.Button();
            this.remove_col = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_row
            // 
            this.add_row.Location = new System.Drawing.Point(12, 41);
            this.add_row.Name = "add_row";
            this.add_row.Size = new System.Drawing.Size(75, 23);
            this.add_row.TabIndex = 1;
            this.add_row.Text = "Add row";
            this.add_row.UseVisualStyleBackColor = true;
            this.add_row.Click += new System.EventHandler(this.add_row_Click);
            // 
            // add_col
            // 
            this.add_col.Location = new System.Drawing.Point(93, 41);
            this.add_col.Name = "add_col";
            this.add_col.Size = new System.Drawing.Size(97, 23);
            this.add_col.TabIndex = 2;
            this.add_col.Text = "Add column";
            this.add_col.UseVisualStyleBackColor = true;
            this.add_col.Click += new System.EventHandler(this.add_col_Click);
            // 
            // remove_row
            // 
            this.remove_row.Location = new System.Drawing.Point(196, 41);
            this.remove_row.Name = "remove_row";
            this.remove_row.Size = new System.Drawing.Size(100, 23);
            this.remove_row.TabIndex = 3;
            this.remove_row.Text = "Remove row";
            this.remove_row.UseVisualStyleBackColor = true;
            this.remove_row.Click += new System.EventHandler(this.remove_row_Click);
            // 
            // remove_col
            // 
            this.remove_col.Location = new System.Drawing.Point(302, 41);
            this.remove_col.Name = "remove_col";
            this.remove_col.Size = new System.Drawing.Size(123, 23);
            this.remove_col.TabIndex = 4;
            this.remove_col.Text = "Remove column";
            this.remove_col.UseVisualStyleBackColor = true;
            this.remove_col.Click += new System.EventHandler(this.remove_col_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(907, 415);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(413, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox2.Location = new System.Drawing.Point(12, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 22);
            this.textBox2.TabIndex = 7;
            // 
            // Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 525);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.remove_col);
            this.Controls.Add(this.remove_row);
            this.Controls.Add(this.add_col);
            this.Controls.Add(this.add_row);
            this.Controls.Add(this.button1);
            this.Name = "Excel";
            this.ShowIcon = false;
            this.Text = "Excel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add_row;
        private System.Windows.Forms.Button add_col;
        private System.Windows.Forms.Button remove_row;
        private System.Windows.Forms.Button remove_col;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

