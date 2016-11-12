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
            this.btnRead = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.dgvRead = new System.Windows.Forms.DataGridView();
            this.byteSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFindMax = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dirNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsDirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCopyIt = new System.Windows.Forms.Button();
            this.txtMaxFiles = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dgvRead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRead.AutoGenerateColumns = false;
            this.dgvRead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRead.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dirNameDataGridViewTextBoxColumn,
            this.byteSum});
            this.dgvRead.DataSource = this.clsDirBindingSource;
            this.dgvRead.Location = new System.Drawing.Point(12, 81);
            this.dgvRead.Name = "dgvRead";
            this.dgvRead.RowTemplate.Height = 24;
            this.dgvRead.Size = new System.Drawing.Size(884, 150);
            this.dgvRead.TabIndex = 2;
            // 
            // byteSum
            // 
            this.byteSum.DataPropertyName = "byteSum";
            this.byteSum.HeaderText = "byteSum";
            this.byteSum.Name = "byteSum";
            // 
            // btnFindMax
            // 
            this.btnFindMax.Location = new System.Drawing.Point(12, 261);
            this.btnFindMax.Name = "btnFindMax";
            this.btnFindMax.Size = new System.Drawing.Size(75, 23);
            this.btnFindMax.TabIndex = 3;
            this.btnFindMax.Text = "Read";
            this.btnFindMax.UseVisualStyleBackColor = true;
            this.btnFindMax.Click += new System.EventHandler(this.btnFindMax_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(875, 177);
            this.dataGridView1.TabIndex = 4;
            // 
            // dirNameDataGridViewTextBoxColumn
            // 
            this.dirNameDataGridViewTextBoxColumn.DataPropertyName = "DirName";
            this.dirNameDataGridViewTextBoxColumn.HeaderText = "DirName";
            this.dirNameDataGridViewTextBoxColumn.Name = "dirNameDataGridViewTextBoxColumn";
            // 
            // clsDirBindingSource
            // 
            this.clsDirBindingSource.DataSource = typeof(ReadDirectoryDimension.clsDir);
            // 
            // btnCopyIt
            // 
            this.btnCopyIt.Location = new System.Drawing.Point(216, 261);
            this.btnCopyIt.Name = "btnCopyIt";
            this.btnCopyIt.Size = new System.Drawing.Size(75, 23);
            this.btnCopyIt.TabIndex = 5;
            this.btnCopyIt.Text = "Copy It in ";
            this.btnCopyIt.UseVisualStyleBackColor = true;
            this.btnCopyIt.Click += new System.EventHandler(this.btnCopyIt_Click);
            // 
            // txtMaxFiles
            // 
            this.txtMaxFiles.Location = new System.Drawing.Point(297, 261);
            this.txtMaxFiles.Name = "txtMaxFiles";
            this.txtMaxFiles.Size = new System.Drawing.Size(560, 22);
            this.txtMaxFiles.TabIndex = 6;
            this.txtMaxFiles.Text = "D:\\Programmazione\\test\\Progetto_PercorsoSQL2016\\__MaxFiles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 479);
            this.Controls.Add(this.txtMaxFiles);
            this.Controls.Add(this.btnCopyIt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFindMax);
            this.Controls.Add(this.dgvRead);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btnFindMax;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCopyIt;
        private System.Windows.Forms.TextBox txtMaxFiles;
    }
}

