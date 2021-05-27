namespace MasterBarang017
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRp = new System.Windows.Forms.Label();
            this.txtNamaSupplier = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.dt = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.quizDataSet = new MasterBarang017.QuizDataSet();
            this.tblbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_barangTableAdapter = new MasterBarang017.QuizDataSetTableAdapters.tbl_barangTableAdapter();
            this.idbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namasupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Input Barang";
            // 
            // txtRp
            // 
            this.txtRp.AutoSize = true;
            this.txtRp.Location = new System.Drawing.Point(315, 278);
            this.txtRp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRp.Name = "txtRp";
            this.txtRp.Size = new System.Drawing.Size(30, 20);
            this.txtRp.TabIndex = 23;
            this.txtRp.Text = "Rp";
            // 
            // txtNamaSupplier
            // 
            this.txtNamaSupplier.Location = new System.Drawing.Point(319, 399);
            this.txtNamaSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamaSupplier.Name = "txtNamaSupplier";
            this.txtNamaSupplier.Size = new System.Drawing.Size(254, 26);
            this.txtNamaSupplier.TabIndex = 22;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(319, 336);
            this.txtStok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(254, 26);
            this.txtStok.TabIndex = 21;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(355, 273);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(218, 26);
            this.txtHarga.TabIndex = 20;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(319, 210);
            this.txtNamaBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(254, 26);
            this.txtNamaBarang.TabIndex = 19;
            // 
            // dt
            // 
            this.dt.AllowUserToAddRows = false;
            this.dt.AutoGenerateColumns = false;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbarangDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.namasupplierDataGridViewTextBoxColumn});
            this.dt.DataSource = this.tblbarangBindingSource;
            this.dt.Location = new System.Drawing.Point(135, 516);
            this.dt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(675, 231);
            this.dt.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 461);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(130, 399);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(113, 20);
            this.lbl2.TabIndex = 16;
            this.lbl2.Text = "Nama Supplier";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(130, 336);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(42, 20);
            this.lbl1.TabIndex = 15;
            this.lbl1.Text = "Stok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Harga";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(130, 210);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 20);
            this.label.TabIndex = 13;
            this.label.Text = "Nama Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID Barang";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(319, 147);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(254, 26);
            this.txtID.TabIndex = 25;
            // 
            // quizDataSet
            // 
            this.quizDataSet.DataSetName = "QuizDataSet";
            this.quizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblbarangBindingSource
            // 
            this.tblbarangBindingSource.DataMember = "tbl_barang";
            this.tblbarangBindingSource.DataSource = this.quizDataSet;
            // 
            // tbl_barangTableAdapter
            // 
            this.tbl_barangTableAdapter.ClearBeforeFill = true;
            // 
            // idbarangDataGridViewTextBoxColumn
            // 
            this.idbarangDataGridViewTextBoxColumn.DataPropertyName = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.HeaderText = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.Name = "idbarangDataGridViewTextBoxColumn";
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // namasupplierDataGridViewTextBoxColumn
            // 
            this.namasupplierDataGridViewTextBoxColumn.DataPropertyName = "nama_supplier";
            this.namasupplierDataGridViewTextBoxColumn.HeaderText = "nama_supplier";
            this.namasupplierDataGridViewTextBoxColumn.Name = "namasupplierDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 780);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRp);
            this.Controls.Add(this.txtNamaSupplier);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtRp;
        private System.Windows.Forms.TextBox txtNamaSupplier;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private QuizDataSet quizDataSet;
        private System.Windows.Forms.BindingSource tblbarangBindingSource;
        private QuizDataSetTableAdapters.tbl_barangTableAdapter tbl_barangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namasupplierDataGridViewTextBoxColumn;
    }
}

