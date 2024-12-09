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
            this.kasaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pompaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satilanYakitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemeTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemYapanPersonelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kasaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrol_otomasyonDataSet2 = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.kasaTableAdapter = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet2TableAdapters.KasaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kasaIDDataGridViewTextBoxColumn,
            this.pompaIDDataGridViewTextBoxColumn,
            this.satilanYakitDataGridViewTextBoxColumn,
            this.odemeTuruDataGridViewTextBoxColumn,
            this.tutarDataGridViewTextBoxColumn,
            this.ıslemTarihiDataGridViewTextBoxColumn,
            this.ıslemYapanPersonelIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kasaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // kasaIDDataGridViewTextBoxColumn
            // 
            this.kasaIDDataGridViewTextBoxColumn.DataPropertyName = "KasaID";
            this.kasaIDDataGridViewTextBoxColumn.HeaderText = "KasaID";
            this.kasaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kasaIDDataGridViewTextBoxColumn.Name = "kasaIDDataGridViewTextBoxColumn";
            this.kasaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kasaIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pompaIDDataGridViewTextBoxColumn
            // 
            this.pompaIDDataGridViewTextBoxColumn.DataPropertyName = "PompaID";
            this.pompaIDDataGridViewTextBoxColumn.HeaderText = "PompaID";
            this.pompaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pompaIDDataGridViewTextBoxColumn.Name = "pompaIDDataGridViewTextBoxColumn";
            this.pompaIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // satilanYakitDataGridViewTextBoxColumn
            // 
            this.satilanYakitDataGridViewTextBoxColumn.DataPropertyName = "SatilanYakit";
            this.satilanYakitDataGridViewTextBoxColumn.HeaderText = "SatilanYakit";
            this.satilanYakitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.satilanYakitDataGridViewTextBoxColumn.Name = "satilanYakitDataGridViewTextBoxColumn";
            this.satilanYakitDataGridViewTextBoxColumn.Width = 125;
            // 
            // odemeTuruDataGridViewTextBoxColumn
            // 
            this.odemeTuruDataGridViewTextBoxColumn.DataPropertyName = "OdemeTuru";
            this.odemeTuruDataGridViewTextBoxColumn.HeaderText = "OdemeTuru";
            this.odemeTuruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odemeTuruDataGridViewTextBoxColumn.Name = "odemeTuruDataGridViewTextBoxColumn";
            this.odemeTuruDataGridViewTextBoxColumn.Width = 125;
            // 
            // tutarDataGridViewTextBoxColumn
            // 
            this.tutarDataGridViewTextBoxColumn.DataPropertyName = "Tutar";
            this.tutarDataGridViewTextBoxColumn.HeaderText = "Tutar";
            this.tutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tutarDataGridViewTextBoxColumn.Name = "tutarDataGridViewTextBoxColumn";
            this.tutarDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıslemTarihiDataGridViewTextBoxColumn
            // 
            this.ıslemTarihiDataGridViewTextBoxColumn.DataPropertyName = "IslemTarihi";
            this.ıslemTarihiDataGridViewTextBoxColumn.HeaderText = "IslemTarihi";
            this.ıslemTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıslemTarihiDataGridViewTextBoxColumn.Name = "ıslemTarihiDataGridViewTextBoxColumn";
            this.ıslemTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıslemYapanPersonelIDDataGridViewTextBoxColumn
            // 
            this.ıslemYapanPersonelIDDataGridViewTextBoxColumn.DataPropertyName = "IslemYapanPersonelID";
            this.ıslemYapanPersonelIDDataGridViewTextBoxColumn.HeaderText = "IslemYapanPersonelID";
            this.ıslemYapanPersonelIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıslemYapanPersonelIDDataGridViewTextBoxColumn.Name = "ıslemYapanPersonelIDDataGridViewTextBoxColumn";
            this.ıslemYapanPersonelIDDataGridViewTextBoxColumn.Width = 125;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personel Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(122, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(230, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 34);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(230, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 34);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(262, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kasa Girişi  ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(498, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 82);
            this.button1.TabIndex = 10;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kasaTableAdapter
            // 
            this.kasaTableAdapter.ClearBeforeFill = true;
            // 
            // Kasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kasa";
            this.Text = "Kasa";
            this.Load += new System.EventHandler(this.Kasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private petrol_otomasyonDataSet2 petrol_otomasyonDataSet2;
        private System.Windows.Forms.BindingSource kasaBindingSource;
        private petrol_otomasyonDataSet2TableAdapters.KasaTableAdapter kasaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kasaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pompaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satilanYakitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemYapanPersonelIDDataGridViewTextBoxColumn;
    }
}