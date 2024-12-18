namespace PETROL_OTOMASYON_8_ARALIIK
{
    partial class Kasa
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
            this.kASASATISBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrol_otomasyonDataSet11 = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet11();
            this.kasaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrol_otomasyonDataSet2 = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet2();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.kasaTableAdapter = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet2TableAdapters.KasaTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.kASA_SATISTableAdapter = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet11TableAdapters.KASA_SATISTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ürünidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünMarkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrol_otomasyonDataSet12 = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet12();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ürünTableAdapter = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet12TableAdapters.ürünTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.petrol_otomasyonDataSet13 = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet13();
            this.urunSatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunSatisTableAdapter = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet13TableAdapters.UrunSatisTableAdapter();
            this.urunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kASASATISBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunSatisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIDDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.toplamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunSatisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(383, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // kASASATISBindingSource
            // 
            this.kASASATISBindingSource.DataMember = "KASA_SATIS";
            this.kASASATISBindingSource.DataSource = this.petrol_otomasyonDataSet11;
            // 
            // petrol_otomasyonDataSet11
            // 
            this.petrol_otomasyonDataSet11.DataSetName = "petrol_otomasyonDataSet11";
            this.petrol_otomasyonDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasaBindingSource
            // 
            this.kasaBindingSource.DataMember = "Kasa";
            this.kasaBindingSource.DataSource = this.petrol_otomasyonDataSet2;
            // 
            // petrol_otomasyonDataSet2
            // 
            this.petrol_otomasyonDataSet2.DataSetName = "petrol_otomasyonDataSet2";
            this.petrol_otomasyonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(152, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 34);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(152, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 34);
            this.textBox2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(634, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 44);
            this.label3.TabIndex = 9;
            this.label3.Text = "KASA";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(368, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 58);
            this.button1.TabIndex = 10;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kasaTableAdapter
            // 
            this.kasaTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.WindowText;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(630, 186);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 64);
            this.button6.TabIndex = 41;
            this.button6.Text = "GERİ";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 42;
            this.label1.Text = "Ürün adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 31);
            this.label4.TabIndex = 44;
            this.label4.Text = "Adet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(111, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 31);
            this.label5.TabIndex = 46;
            this.label5.Text = "Toplam Fiyat  ";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(372, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 58);
            this.button4.TabIndex = 49;
            this.button4.Text = "YENİ SATIŞ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(372, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 60);
            this.button2.TabIndex = 50;
            this.button2.Text = "YAZDIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(372, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 60);
            this.button3.TabIndex = 55;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kASA_SATISTableAdapter
            // 
            this.kASA_SATISTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ürünidDataGridViewTextBoxColumn,
            this.ürünAdiDataGridViewTextBoxColumn,
            this.ürünMarkaDataGridViewTextBoxColumn,
            this.ürünFiyatiDataGridViewTextBoxColumn,
            this.ürünTipiDataGridViewTextBoxColumn,
            this.stokMiktariDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.ürünBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(401, 259);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(389, 179);
            this.dataGridView2.TabIndex = 56;
            // 
            // ürünidDataGridViewTextBoxColumn
            // 
            this.ürünidDataGridViewTextBoxColumn.DataPropertyName = "ürün_id";
            this.ürünidDataGridViewTextBoxColumn.HeaderText = "ürün_id";
            this.ürünidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ürünidDataGridViewTextBoxColumn.Name = "ürünidDataGridViewTextBoxColumn";
            this.ürünidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ürünidDataGridViewTextBoxColumn.Width = 125;
            // 
            // ürünAdiDataGridViewTextBoxColumn
            // 
            this.ürünAdiDataGridViewTextBoxColumn.DataPropertyName = "ürünAdi";
            this.ürünAdiDataGridViewTextBoxColumn.HeaderText = "ürünAdi";
            this.ürünAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ürünAdiDataGridViewTextBoxColumn.Name = "ürünAdiDataGridViewTextBoxColumn";
            this.ürünAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ürünMarkaDataGridViewTextBoxColumn
            // 
            this.ürünMarkaDataGridViewTextBoxColumn.DataPropertyName = "ürünMarka";
            this.ürünMarkaDataGridViewTextBoxColumn.HeaderText = "ürünMarka";
            this.ürünMarkaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ürünMarkaDataGridViewTextBoxColumn.Name = "ürünMarkaDataGridViewTextBoxColumn";
            this.ürünMarkaDataGridViewTextBoxColumn.Width = 125;
            // 
            // ürünFiyatiDataGridViewTextBoxColumn
            // 
            this.ürünFiyatiDataGridViewTextBoxColumn.DataPropertyName = "ürünFiyati";
            this.ürünFiyatiDataGridViewTextBoxColumn.HeaderText = "ürünFiyati";
            this.ürünFiyatiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ürünFiyatiDataGridViewTextBoxColumn.Name = "ürünFiyatiDataGridViewTextBoxColumn";
            this.ürünFiyatiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ürünTipiDataGridViewTextBoxColumn
            // 
            this.ürünTipiDataGridViewTextBoxColumn.DataPropertyName = "ürünTipi";
            this.ürünTipiDataGridViewTextBoxColumn.HeaderText = "ürünTipi";
            this.ürünTipiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ürünTipiDataGridViewTextBoxColumn.Name = "ürünTipiDataGridViewTextBoxColumn";
            this.ürünTipiDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokMiktariDataGridViewTextBoxColumn
            // 
            this.stokMiktariDataGridViewTextBoxColumn.DataPropertyName = "stokMiktari";
            this.stokMiktariDataGridViewTextBoxColumn.HeaderText = "stokMiktari";
            this.stokMiktariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokMiktariDataGridViewTextBoxColumn.Name = "stokMiktariDataGridViewTextBoxColumn";
            this.stokMiktariDataGridViewTextBoxColumn.Width = 125;
            // 
            // ürünBindingSource
            // 
            this.ürünBindingSource.DataMember = "ürün";
            this.ürünBindingSource.DataSource = this.petrol_otomasyonDataSet12;
            // 
            // petrol_otomasyonDataSet12
            // 
            this.petrol_otomasyonDataSet12.DataSetName = "petrol_otomasyonDataSet12";
            this.petrol_otomasyonDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(152, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 34);
            this.textBox3.TabIndex = 57;
            // 
            // ürünTableAdapter
            // 
            this.ürünTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 31);
            this.label2.TabIndex = 58;
            this.label2.Text = "Fiyatı :";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(59, 224);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(267, 34);
            this.textBox4.TabIndex = 59;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Highlight;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(605, 81);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 89);
            this.button5.TabIndex = 60;
            this.button5.Text = "KAYDET";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // petrol_otomasyonDataSet13
            // 
            this.petrol_otomasyonDataSet13.DataSetName = "petrol_otomasyonDataSet13";
            this.petrol_otomasyonDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunSatisBindingSource
            // 
            this.urunSatisBindingSource.DataMember = "UrunSatis";
            this.urunSatisBindingSource.DataSource = this.petrol_otomasyonDataSet13;
            // 
            // urunSatisTableAdapter
            // 
            this.urunSatisTableAdapter.ClearBeforeFill = true;
            // 
            // urunIDDataGridViewTextBoxColumn
            // 
            this.urunIDDataGridViewTextBoxColumn.DataPropertyName = "UrunID";
            this.urunIDDataGridViewTextBoxColumn.HeaderText = "UrunID";
            this.urunIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunIDDataGridViewTextBoxColumn.Name = "urunIDDataGridViewTextBoxColumn";
            this.urunIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            this.urunAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "Adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "Adet";
            this.adetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            this.adetDataGridViewTextBoxColumn.Width = 125;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // toplamDataGridViewTextBoxColumn
            // 
            this.toplamDataGridViewTextBoxColumn.DataPropertyName = "Toplam";
            this.toplamDataGridViewTextBoxColumn.HeaderText = "Toplam";
            this.toplamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamDataGridViewTextBoxColumn.Name = "toplamDataGridViewTextBoxColumn";
            this.toplamDataGridViewTextBoxColumn.Width = 125;
            // 
            // Kasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kasa";
            this.Text = "Kasa";
            this.Load += new System.EventHandler(this.Kasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kASASATISBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunSatisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private petrol_otomasyonDataSet2 petrol_otomasyonDataSet2;
        private System.Windows.Forms.BindingSource kasaBindingSource;
        private petrol_otomasyonDataSet2TableAdapters.KasaTableAdapter kasaTableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private petrol_otomasyonDataSet11 petrol_otomasyonDataSet11;
        private System.Windows.Forms.BindingSource kASASATISBindingSource;
        private petrol_otomasyonDataSet11TableAdapters.KASA_SATISTableAdapter kASA_SATISTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox3;
        private petrol_otomasyonDataSet12 petrol_otomasyonDataSet12;
        private System.Windows.Forms.BindingSource ürünBindingSource;
        private petrol_otomasyonDataSet12TableAdapters.ürünTableAdapter ürünTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünMarkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokMiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button5;
        private petrol_otomasyonDataSet13 petrol_otomasyonDataSet13;
        private System.Windows.Forms.BindingSource urunSatisBindingSource;
        private petrol_otomasyonDataSet13TableAdapters.UrunSatisTableAdapter urunSatisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamDataGridViewTextBoxColumn;
    }
}