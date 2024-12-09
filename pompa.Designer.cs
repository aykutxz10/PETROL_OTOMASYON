namespace PETROL_OTOMASYON_8_ARALIIK
{
    partial class pompa
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.petrol_otomasyonDataSet4 = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet4();
            this.pompaCihazlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pompaCihazlariTableAdapter = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet4TableAdapters.PompaCihazlariTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.petrol_otomasyonDataSet5 = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet5();
            this.pompakeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pompakeTableAdapter = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet5TableAdapters.PompakeTableAdapter();
            this.petrol_otomasyonDataSet6 = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet6();
            this.pompakeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pompakeTableAdapter1 = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet6TableAdapters.PompakeTableAdapter();
            this.pompaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakıtMiktarıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakıtTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ödemeTürüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pompaCihazlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pompakeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pompakeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pompaIDDataGridViewTextBoxColumn,
            this.personelAdıDataGridViewTextBoxColumn,
            this.plakaDataGridViewTextBoxColumn,
            this.tutarDataGridViewTextBoxColumn,
            this.yakıtMiktarıDataGridViewTextBoxColumn,
            this.yakıtTipiDataGridViewTextBoxColumn,
            this.ödemeTürüDataGridViewTextBoxColumn,
            this.subeIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pompakeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(781, 149);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(232, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Açılacak Pompa ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(2, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yakıt Miktarı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(2, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ödeme Türü :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(2, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yakıt Tipi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(2, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Yakıt Stoğu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(2, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sube ID :";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(232, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 27);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(232, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(217, 27);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(232, 92);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(217, 27);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(232, 121);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(217, 27);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(232, 148);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(217, 27);
            this.textBox6.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(502, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 57);
            this.button1.TabIndex = 13;
            this.button1.Text = "YAKIT VER";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // petrol_otomasyonDataSet4
            // 
            this.petrol_otomasyonDataSet4.DataSetName = "petrol_otomasyonDataSet4";
            this.petrol_otomasyonDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pompaCihazlariBindingSource
            // 
            this.pompaCihazlariBindingSource.DataMember = "PompaCihazlari";
            this.pompaCihazlariBindingSource.DataSource = this.petrol_otomasyonDataSet4;
            // 
            // pompaCihazlariTableAdapter
            // 
            this.pompaCihazlariTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(2, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "Personel Adı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(2, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 27);
            this.label8.TabIndex = 16;
            this.label8.Text = "Plaka :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Highlight;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(2, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 27);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tutar :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PETROL_OTOMASYON_8_ARALIIK.Properties.Resources.depo;
            this.pictureBox1.Location = new System.Drawing.Point(502, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // petrol_otomasyonDataSet5
            // 
            this.petrol_otomasyonDataSet5.DataSetName = "petrol_otomasyonDataSet5";
            this.petrol_otomasyonDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pompakeBindingSource
            // 
            this.pompakeBindingSource.DataMember = "Pompake";
            this.pompakeBindingSource.DataSource = this.petrol_otomasyonDataSet5;
            // 
            // pompakeTableAdapter
            // 
            this.pompakeTableAdapter.ClearBeforeFill = true;
            // 
            // petrol_otomasyonDataSet6
            // 
            this.petrol_otomasyonDataSet6.DataSetName = "petrol_otomasyonDataSet6";
            this.petrol_otomasyonDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pompakeBindingSource1
            // 
            this.pompakeBindingSource1.DataMember = "Pompake";
            this.pompakeBindingSource1.DataSource = this.petrol_otomasyonDataSet6;
            // 
            // pompakeTableAdapter1
            // 
            this.pompakeTableAdapter1.ClearBeforeFill = true;
            // 
            // pompaIDDataGridViewTextBoxColumn
            // 
            this.pompaIDDataGridViewTextBoxColumn.DataPropertyName = "PompaID";
            this.pompaIDDataGridViewTextBoxColumn.HeaderText = "PompaID";
            this.pompaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pompaIDDataGridViewTextBoxColumn.Name = "pompaIDDataGridViewTextBoxColumn";
            this.pompaIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelAdıDataGridViewTextBoxColumn
            // 
            this.personelAdıDataGridViewTextBoxColumn.DataPropertyName = "Personel Adı";
            this.personelAdıDataGridViewTextBoxColumn.HeaderText = "Personel Adı";
            this.personelAdıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelAdıDataGridViewTextBoxColumn.Name = "personelAdıDataGridViewTextBoxColumn";
            this.personelAdıDataGridViewTextBoxColumn.Width = 125;
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "Plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "Plaka";
            this.plakaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            this.plakaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tutarDataGridViewTextBoxColumn
            // 
            this.tutarDataGridViewTextBoxColumn.DataPropertyName = "Tutar";
            this.tutarDataGridViewTextBoxColumn.HeaderText = "Tutar";
            this.tutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tutarDataGridViewTextBoxColumn.Name = "tutarDataGridViewTextBoxColumn";
            this.tutarDataGridViewTextBoxColumn.Width = 125;
            // 
            // yakıtMiktarıDataGridViewTextBoxColumn
            // 
            this.yakıtMiktarıDataGridViewTextBoxColumn.DataPropertyName = "Yakıt Miktarı";
            this.yakıtMiktarıDataGridViewTextBoxColumn.HeaderText = "Yakıt Miktarı";
            this.yakıtMiktarıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yakıtMiktarıDataGridViewTextBoxColumn.Name = "yakıtMiktarıDataGridViewTextBoxColumn";
            this.yakıtMiktarıDataGridViewTextBoxColumn.Width = 125;
            // 
            // yakıtTipiDataGridViewTextBoxColumn
            // 
            this.yakıtTipiDataGridViewTextBoxColumn.DataPropertyName = "Yakıt Tipi";
            this.yakıtTipiDataGridViewTextBoxColumn.HeaderText = "Yakıt Tipi";
            this.yakıtTipiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yakıtTipiDataGridViewTextBoxColumn.Name = "yakıtTipiDataGridViewTextBoxColumn";
            this.yakıtTipiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ödemeTürüDataGridViewTextBoxColumn
            // 
            this.ödemeTürüDataGridViewTextBoxColumn.DataPropertyName = "Ödeme Türü";
            this.ödemeTürüDataGridViewTextBoxColumn.HeaderText = "Ödeme Türü";
            this.ödemeTürüDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ödemeTürüDataGridViewTextBoxColumn.Name = "ödemeTürüDataGridViewTextBoxColumn";
            this.ödemeTürüDataGridViewTextBoxColumn.Width = 125;
            // 
            // subeIDDataGridViewTextBoxColumn
            // 
            this.subeIDDataGridViewTextBoxColumn.DataPropertyName = "Sube ID";
            this.subeIDDataGridViewTextBoxColumn.HeaderText = "Sube ID";
            this.subeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subeIDDataGridViewTextBoxColumn.Name = "subeIDDataGridViewTextBoxColumn";
            this.subeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.Location = new System.Drawing.Point(232, 173);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(217, 27);
            this.textBox7.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox8.Location = new System.Drawing.Point(232, 200);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(217, 27);
            this.textBox8.TabIndex = 19;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox9.Location = new System.Drawing.Point(232, 229);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(217, 27);
            this.textBox9.TabIndex = 20;
            // 
            // pompa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "pompa";
            this.Text = "pompa";
            this.Load += new System.EventHandler(this.pompa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pompaCihazlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pompakeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pompakeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private petrol_otomasyonDataSet4 petrol_otomasyonDataSet4;
        private System.Windows.Forms.BindingSource pompaCihazlariBindingSource;
        private petrol_otomasyonDataSet4TableAdapters.PompaCihazlariTableAdapter pompaCihazlariTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private petrol_otomasyonDataSet5 petrol_otomasyonDataSet5;
        private System.Windows.Forms.BindingSource pompakeBindingSource;
        private petrol_otomasyonDataSet5TableAdapters.PompakeTableAdapter pompakeTableAdapter;
        private petrol_otomasyonDataSet6 petrol_otomasyonDataSet6;
        private System.Windows.Forms.BindingSource pompakeBindingSource1;
        private petrol_otomasyonDataSet6TableAdapters.PompakeTableAdapter pompakeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pompaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakıtMiktarıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakıtTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ödemeTürüDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
    }
}