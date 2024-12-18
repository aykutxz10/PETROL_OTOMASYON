namespace PETROL_OTOMASYON_8_ARALIIK
{
    partial class Sube
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.subeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeIsmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrol_otomasyonDataSet1 = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet1();
            this.subelerTableAdapter = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet1TableAdapters.SubelerTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(241, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "ARAMA :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(404, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 38);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subeIDDataGridViewTextBoxColumn,
            this.subeIsmiDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.ılDataGridViewTextBoxColumn,
            this.ılceDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.subelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 319);
            this.dataGridView1.TabIndex = 4;
            // 
            // subeIDDataGridViewTextBoxColumn
            // 
            this.subeIDDataGridViewTextBoxColumn.DataPropertyName = "SubeID";
            this.subeIDDataGridViewTextBoxColumn.HeaderText = "SubeID";
            this.subeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subeIDDataGridViewTextBoxColumn.Name = "subeIDDataGridViewTextBoxColumn";
            this.subeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.subeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // subeIsmiDataGridViewTextBoxColumn
            // 
            this.subeIsmiDataGridViewTextBoxColumn.DataPropertyName = "SubeIsmi";
            this.subeIsmiDataGridViewTextBoxColumn.HeaderText = "SubeIsmi";
            this.subeIsmiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subeIsmiDataGridViewTextBoxColumn.Name = "subeIsmiDataGridViewTextBoxColumn";
            this.subeIsmiDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // ılDataGridViewTextBoxColumn
            // 
            this.ılDataGridViewTextBoxColumn.DataPropertyName = "Il";
            this.ılDataGridViewTextBoxColumn.HeaderText = "Il";
            this.ılDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ılDataGridViewTextBoxColumn.Name = "ılDataGridViewTextBoxColumn";
            this.ılDataGridViewTextBoxColumn.Width = 125;
            // 
            // ılceDataGridViewTextBoxColumn
            // 
            this.ılceDataGridViewTextBoxColumn.DataPropertyName = "Ilce";
            this.ılceDataGridViewTextBoxColumn.HeaderText = "Ilce";
            this.ılceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ılceDataGridViewTextBoxColumn.Name = "ılceDataGridViewTextBoxColumn";
            this.ılceDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // subelerBindingSource
            // 
            this.subelerBindingSource.DataMember = "Subeler";
            this.subelerBindingSource.DataSource = this.petrol_otomasyonDataSet1;
            // 
            // petrol_otomasyonDataSet1
            // 
            this.petrol_otomasyonDataSet1.DataSetName = "petrol_otomasyonDataSet1";
            this.petrol_otomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subelerTableAdapter
            // 
            this.subelerTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Highlight;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(477, 68);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(238, 45);
            this.button6.TabIndex = 21;
            this.button6.Text = "ARA";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PETROL_OTOMASYON_8_ARALIIK.Properties.Resources.shel1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowText;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(258, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 45);
            this.button1.TabIndex = 41;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Sube";
            this.Text = "Sube";
            this.Load += new System.EventHandler(this.Sube_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private petrol_otomasyonDataSet1 petrol_otomasyonDataSet1;
        private System.Windows.Forms.BindingSource subelerBindingSource;
        private petrol_otomasyonDataSet1TableAdapters.SubelerTableAdapter subelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeIsmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
    }
}