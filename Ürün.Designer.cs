using System.Data.SqlClient;

namespace PETROL_OTOMASYON_8_ARALIIK
{
    partial class Ürün
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ürünBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrol_otomasyonDataSet3 = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet3();
            this.ürünTableAdapter = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet3TableAdapters.ürünTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.petrol_otomasyonDataSet9 = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet9();
            this.ürünBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ürünTableAdapter1 = new PETROL_OTOMASYON_8_ARALIIK.petrol_otomasyonDataSet9TableAdapters.ürünTableAdapter();
            this.ürünidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünMarkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowText;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(16, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowText;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(192, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 49);
            this.button2.TabIndex = 24;
            this.button2.Text = "SİL";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.WindowText;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(16, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 48);
            this.button3.TabIndex = 25;
            this.button3.Text = "LİSTELE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.WindowText;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(192, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 48);
            this.button4.TabIndex = 26;
            this.button4.Text = "GÜNCELLE";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ürün Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ürün Markası :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ürün Fiyatı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ürün Tipi :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 22);
            this.textBox2.TabIndex = 31;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(124, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 22);
            this.textBox3.TabIndex = 32;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(124, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(174, 22);
            this.textBox4.TabIndex = 33;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(124, 146);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(174, 22);
            this.textBox5.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Ürün Stoğu:";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(353, 75);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(306, 34);
            this.textBox6.TabIndex = 36;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(356, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 31);
            this.label6.TabIndex = 37;
            this.label6.Text = "Ürün Adını Giriniz";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ürünidDataGridViewTextBoxColumn,
            this.ürünAdiDataGridViewTextBoxColumn,
            this.ürünMarkaDataGridViewTextBoxColumn,
            this.ürünFiyatiDataGridViewTextBoxColumn,
            this.ürünTipiDataGridViewTextBoxColumn,
            this.stokMiktariDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ürünBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(353, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(435, 284);
            this.dataGridView1.TabIndex = 38;
            // 
            // ürünBindingSource
            // 
            this.ürünBindingSource.DataMember = "ürün";
            this.ürünBindingSource.DataSource = this.petrol_otomasyonDataSet3;
            // 
            // petrol_otomasyonDataSet3
            // 
            this.petrol_otomasyonDataSet3.DataSetName = "petrol_otomasyonDataSet3";
            this.petrol_otomasyonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ürünTableAdapter
            // 
            this.ürünTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.WindowText;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(665, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 38);
            this.button5.TabIndex = 39;
            this.button5.Text = "ARA";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // petrol_otomasyonDataSet9
            // 
            this.petrol_otomasyonDataSet9.DataSetName = "petrol_otomasyonDataSet9";
            this.petrol_otomasyonDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ürünBindingSource1
            // 
            this.ürünBindingSource1.DataMember = "ürün";
            this.ürünBindingSource1.DataSource = this.petrol_otomasyonDataSet9;
            // 
            // ürünTableAdapter1
            // 
            this.ürünTableAdapter1.ClearBeforeFill = true;
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
            // Ürün
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Ürün";
            this.Text = "Ürün";
            this.Load += new System.EventHandler(this.Ürün_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrol_otomasyonDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private petrol_otomasyonDataSet3 petrol_otomasyonDataSet3;
        private System.Windows.Forms.BindingSource ürünBindingSource;
        private petrol_otomasyonDataSet3TableAdapters.ürünTableAdapter ürünTableAdapter;
        private System.Windows.Forms.Button button5;
        private petrol_otomasyonDataSet9 petrol_otomasyonDataSet9;
        private System.Windows.Forms.BindingSource ürünBindingSource1;
        private petrol_otomasyonDataSet9TableAdapters.ürünTableAdapter ürünTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünMarkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokMiktariDataGridViewTextBoxColumn;
    }
}