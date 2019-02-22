namespace Program1
{
    partial class checkoutForm
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
            this.textBoxBiayaServis = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.program1DataSet = new Program1.program1DataSet();
            this.textBoxHargaSparepart = new System.Windows.Forms.TextBox();
            this.textBoxSparepart = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKonsumenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNomorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kelengkapanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kerusakanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qrcodeDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.biayaServisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaSparepartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparepartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.productTableAdapter = new Program1.program1DataSetTableAdapters.productTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.program1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBiayaServis
            // 
            this.textBoxBiayaServis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "biayaServis", true));
            this.textBoxBiayaServis.Location = new System.Drawing.Point(171, 135);
            this.textBoxBiayaServis.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBiayaServis.Name = "textBoxBiayaServis";
            this.textBoxBiayaServis.Size = new System.Drawing.Size(275, 22);
            this.textBoxBiayaServis.TabIndex = 1;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.program1DataSet;
            // 
            // program1DataSet
            // 
            this.program1DataSet.DataSetName = "program1DataSet";
            this.program1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxHargaSparepart
            // 
            this.textBoxHargaSparepart.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "hargaSparepart", true));
            this.textBoxHargaSparepart.Location = new System.Drawing.Point(171, 167);
            this.textBoxHargaSparepart.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHargaSparepart.Name = "textBoxHargaSparepart";
            this.textBoxHargaSparepart.Size = new System.Drawing.Size(275, 22);
            this.textBoxHargaSparepart.TabIndex = 2;
            // 
            // textBoxSparepart
            // 
            this.textBoxSparepart.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "sparepart", true));
            this.textBoxSparepart.Location = new System.Drawing.Point(171, 199);
            this.textBoxSparepart.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSparepart.Name = "textBoxSparepart";
            this.textBoxSparepart.Size = new System.Drawing.Size(275, 22);
            this.textBoxSparepart.TabIndex = 3;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "total", true));
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(171, 231);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(275, 22);
            this.textBoxTotal.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn,
            this.namaKonsumenDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn,
            this.serialNomorDataGridViewTextBoxColumn,
            this.kelengkapanDataGridViewTextBoxColumn,
            this.kerusakanDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.qrcodeDataGridViewImageColumn,
            this.biayaServisDataGridViewTextBoxColumn,
            this.hargaSparepartDataGridViewTextBoxColumn,
            this.sparepartDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(453, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 463);
            this.dataGridView1.TabIndex = 45;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "productId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "productId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "tanggal";
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            // 
            // namaKonsumenDataGridViewTextBoxColumn
            // 
            this.namaKonsumenDataGridViewTextBoxColumn.DataPropertyName = "namaKonsumen";
            this.namaKonsumenDataGridViewTextBoxColumn.HeaderText = "namaKonsumen";
            this.namaKonsumenDataGridViewTextBoxColumn.Name = "namaKonsumenDataGridViewTextBoxColumn";
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "namaBarang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "namaBarang";
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            // 
            // serialNomorDataGridViewTextBoxColumn
            // 
            this.serialNomorDataGridViewTextBoxColumn.DataPropertyName = "serialNomor";
            this.serialNomorDataGridViewTextBoxColumn.HeaderText = "serialNomor";
            this.serialNomorDataGridViewTextBoxColumn.Name = "serialNomorDataGridViewTextBoxColumn";
            // 
            // kelengkapanDataGridViewTextBoxColumn
            // 
            this.kelengkapanDataGridViewTextBoxColumn.DataPropertyName = "kelengkapan";
            this.kelengkapanDataGridViewTextBoxColumn.HeaderText = "kelengkapan";
            this.kelengkapanDataGridViewTextBoxColumn.Name = "kelengkapanDataGridViewTextBoxColumn";
            // 
            // kerusakanDataGridViewTextBoxColumn
            // 
            this.kerusakanDataGridViewTextBoxColumn.DataPropertyName = "kerusakan";
            this.kerusakanDataGridViewTextBoxColumn.HeaderText = "kerusakan";
            this.kerusakanDataGridViewTextBoxColumn.Name = "kerusakanDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // qrcodeDataGridViewImageColumn
            // 
            this.qrcodeDataGridViewImageColumn.DataPropertyName = "qrcode";
            this.qrcodeDataGridViewImageColumn.HeaderText = "qrcode";
            this.qrcodeDataGridViewImageColumn.Name = "qrcodeDataGridViewImageColumn";
            // 
            // biayaServisDataGridViewTextBoxColumn
            // 
            this.biayaServisDataGridViewTextBoxColumn.DataPropertyName = "biayaServis";
            this.biayaServisDataGridViewTextBoxColumn.HeaderText = "biayaServis";
            this.biayaServisDataGridViewTextBoxColumn.Name = "biayaServisDataGridViewTextBoxColumn";
            // 
            // hargaSparepartDataGridViewTextBoxColumn
            // 
            this.hargaSparepartDataGridViewTextBoxColumn.DataPropertyName = "hargaSparepart";
            this.hargaSparepartDataGridViewTextBoxColumn.HeaderText = "hargaSparepart";
            this.hargaSparepartDataGridViewTextBoxColumn.Name = "hargaSparepartDataGridViewTextBoxColumn";
            // 
            // sparepartDataGridViewTextBoxColumn
            // 
            this.sparepartDataGridViewTextBoxColumn.DataPropertyName = "sparepart";
            this.sparepartDataGridViewTextBoxColumn.HeaderText = "sparepart";
            this.sparepartDataGridViewTextBoxColumn.Name = "sparepartDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(5, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 47;
            this.label2.Text = "Biaya Servis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(5, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 48;
            this.label4.Text = "Sparepart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(3, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 28);
            this.label3.TabIndex = 49;
            this.label3.Text = "Harga Sparepart";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(5, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 50;
            this.label5.Text = "Total";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(8, 281);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(141, 37);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(156, 281);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(141, 37);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(305, 281);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(141, 37);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(8, 322);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(438, 37);
            this.button1.TabIndex = 51;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // checkoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxSparepart);
            this.Controls.Add(this.textBoxHargaSparepart);
            this.Controls.Add(this.textBoxBiayaServis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "checkoutForm";
            this.Text = "checkoutForm";
            this.Load += new System.EventHandler(this.checkoutForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.program1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxBiayaServis;
        private System.Windows.Forms.TextBox textBoxHargaSparepart;
        private System.Windows.Forms.TextBox textBoxSparepart;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button1;
        private program1DataSet program1DataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private program1DataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKonsumenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNomorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelengkapanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kerusakanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn qrcodeDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biayaServisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaSparepartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sparepartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}