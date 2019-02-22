namespace Program1
{
    partial class historyForm
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
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.program1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.program1DataSet = new Program1.program1DataSet();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.productTableAdapter = new Program1.program1DataSetTableAdapters.productTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.program1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.program1DataSet)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 543);
            this.dataGridView1.TabIndex = 0;
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
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.program1DataSetBindingSource;
            // 
            // program1DataSetBindingSource
            // 
            this.program1DataSetBindingSource.DataSource = this.program1DataSet;
            this.program1DataSetBindingSource.Position = 0;
            // 
            // program1DataSet
            // 
            this.program1DataSet.DataSetName = "program1DataSet";
            this.program1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxSearch.Location = new System.Drawing.Point(12, 20);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(196, 34);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearch.Location = new System.Drawing.Point(214, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // historyForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 624);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "historyForm";
            this.Load += new System.EventHandler(this.historyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.program1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.program1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource program1DataSetBindingSource;
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