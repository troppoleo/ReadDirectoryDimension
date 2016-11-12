namespace ReadDirectoryDimension
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.dgvRead = new System.Windows.Forms.DataGridView();
            this.clsDirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dirNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.byteSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.byteSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(540, 40);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(603, 22);
            this.txtPath.TabIndex = 1;
            this.txtPath.Text = "D:\\Programmazione\\test\\Progetto_PercorsoSQL2016";
            // 
            // dgvRead
            // 
            this.dgvRead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRead.AutoGenerateColumns = false;
            this.dgvRead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRead.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dirNameDataGridViewTextBoxColumn,
            this.byteSumDataGridViewTextBoxColumn,
            this.byteSum});
            this.dgvRead.DataSource = this.clsDirBindingSource;
            this.dgvRead.Location = new System.Drawing.Point(12, 138);
            this.dgvRead.Name = "dgvRead";
            this.dgvRead.RowTemplate.Height = 24;
            this.dgvRead.Size = new System.Drawing.Size(672, 182);
            this.dgvRead.TabIndex = 2;
            // 
            // clsDirBindingSource
            // 
            this.clsDirBindingSource.DataSource = typeof(ReadDirectoryDimension.clsDir);
            // 
            // dirNameDataGridViewTextBoxColumn
            // 
            this.dirNameDataGridViewTextBoxColumn.DataPropertyName = "DirName";
            this.dirNameDataGridViewTextBoxColumn.HeaderText = "DirName";
            this.dirNameDataGridViewTextBoxColumn.Name = "dirNameDataGridViewTextBoxColumn";
            // 
            // byteSumDataGridViewTextBoxColumn
            // 
            this.byteSumDataGridViewTextBoxColumn.DataPropertyName = "byteSum";
            dataGridViewCellStyle1.Format = "N0";
            this.byteSumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.byteSumDataGridViewTextBoxColumn.HeaderText = "byteSum";
            this.byteSumDataGridViewTextBoxColumn.Name = "byteSumDataGridViewTextBoxColumn";
            // 
            // byteSum
            // 
            this.byteSum.DataPropertyName = "byteSum";
            this.byteSum.HeaderText = "byteSum";
            this.byteSum.Name = "byteSum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 332);
            this.Controls.Add(this.dgvRead);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDirBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.DataGridView dgvRead;
        private System.Windows.Forms.BindingSource clsDirBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn byteSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn byteSum;
    }
}

