namespace Program1
{
    partial class editForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.program1DataSet = new Program1.program1DataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxDamage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCompleteness = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNameGoods = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNameCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productTableAdapter = new Program1.program1DataSetTableAdapters.productTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.program1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "productId", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(164, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 22);
            this.textBox1.TabIndex = 0;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(4, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 28);
            this.label7.TabIndex = 29;
            this.label7.Text = "Nomor";
            // 
            // dateTime
            // 
            this.dateTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "tanggal", true));
            this.dateTime.Location = new System.Drawing.Point(163, 46);
            this.dateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(279, 22);
            this.dateTime.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(17, 438);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(141, 37);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxDamage
            // 
            this.textBoxDamage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "kerusakan", true));
            this.textBoxDamage.Location = new System.Drawing.Point(164, 217);
            this.textBoxDamage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDamage.Name = "textBoxDamage";
            this.textBoxDamage.Size = new System.Drawing.Size(279, 22);
            this.textBoxDamage.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(4, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Kerusakan";
            // 
            // textBoxCompleteness
            // 
            this.textBoxCompleteness.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "kelengkapan", true));
            this.textBoxCompleteness.Location = new System.Drawing.Point(163, 182);
            this.textBoxCompleteness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCompleteness.Name = "textBoxCompleteness";
            this.textBoxCompleteness.Size = new System.Drawing.Size(279, 22);
            this.textBoxCompleteness.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(4, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "Kelengkapan";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "serialNomor", true));
            this.textBoxSerialNumber.Location = new System.Drawing.Point(163, 145);
            this.textBoxSerialNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(280, 22);
            this.textBoxSerialNumber.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(4, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Serial Nomor";
            // 
            // textBoxNameGoods
            // 
            this.textBoxNameGoods.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "namaBarang", true));
            this.textBoxNameGoods.Location = new System.Drawing.Point(163, 112);
            this.textBoxNameGoods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNameGoods.Name = "textBoxNameGoods";
            this.textBoxNameGoods.Size = new System.Drawing.Size(279, 22);
            this.textBoxNameGoods.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(4, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nama Barang";
            // 
            // textBoxNameCustomer
            // 
            this.textBoxNameCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "namaKonsumen", true));
            this.textBoxNameCustomer.Location = new System.Drawing.Point(163, 78);
            this.textBoxNameCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNameCustomer.Name = "textBoxNameCustomer";
            this.textBoxNameCustomer.Size = new System.Drawing.Size(279, 22);
            this.textBoxNameCustomer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(4, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nama Konsumen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(4, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tanggal";
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
            this.dataGridView1.Location = new System.Drawing.Point(461, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(504, 462);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
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
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(165, 438);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(141, 37);
            this.buttonEdit.TabIndex = 9;
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
            this.buttonDelete.Location = new System.Drawing.Point(315, 438);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(141, 37);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(4, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "Status";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "status", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rusak",
            "Tidak bisa di servis",
            "Selesai"});
            this.comboBox1.Location = new System.Drawing.Point(164, 250);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(279, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(4, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 28);
            this.label9.TabIndex = 36;
            this.label9.Text = "QR Code";
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productBindingSource, "qrcode", true));
            this.pictureBox1.Location = new System.Drawing.Point(164, 281);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 155);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxDamage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCompleteness);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSerialNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNameGoods);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNameCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "editForm";
            this.Text = "editForm";
            this.Load += new System.EventHandler(this.editForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.program1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxDamage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCompleteness;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNameGoods;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNameCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
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