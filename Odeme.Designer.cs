namespace VTYS_HastaneDB
{
    partial class Odeme
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
            this.cmb_odemeTuru = new System.Windows.Forms.ComboBox();
            this.txt_toplamTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_odemeTarihi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_odemeNo = new System.Windows.Forms.TextBox();
            this.tc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_odemeTuru
            // 
            this.cmb_odemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_odemeTuru.FormattingEnabled = true;
            this.cmb_odemeTuru.Location = new System.Drawing.Point(998, 127);
            this.cmb_odemeTuru.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_odemeTuru.Name = "cmb_odemeTuru";
            this.cmb_odemeTuru.Size = new System.Drawing.Size(220, 28);
            this.cmb_odemeTuru.TabIndex = 52;
            // 
            // txt_toplamTutar
            // 
            this.txt_toplamTutar.Location = new System.Drawing.Point(998, 173);
            this.txt_toplamTutar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_toplamTutar.Name = "txt_toplamTutar";
            this.txt_toplamTutar.Size = new System.Drawing.Size(220, 26);
            this.txt_toplamTutar.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(889, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "TC Kimlik No :";
            // 
            // txt_odemeTarihi
            // 
            this.txt_odemeTarihi.Location = new System.Drawing.Point(998, 85);
            this.txt_odemeTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_odemeTarihi.Name = "txt_odemeTarihi";
            this.txt_odemeTarihi.Size = new System.Drawing.Size(220, 26);
            this.txt_odemeTarihi.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(884, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Toplam Tutar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(883, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Ödeme Tarihi :";
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(998, 215);
            this.txt_tc.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(220, 26);
            this.txt_tc.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(889, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Ödeme Türü :";
            // 
            // txt_odemeNo
            // 
            this.txt_odemeNo.Location = new System.Drawing.Point(998, 44);
            this.txt_odemeNo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_odemeNo.Name = "txt_odemeNo";
            this.txt_odemeNo.Size = new System.Drawing.Size(220, 26);
            this.txt_odemeNo.TabIndex = 39;
            // 
            // tc
            // 
            this.tc.AutoSize = true;
            this.tc.Location = new System.Drawing.Point(901, 47);
            this.tc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(93, 20);
            this.tc.TabIndex = 38;
            this.tc.Text = "Ödeme No :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(832, 368);
            this.dataGridView1.TabIndex = 37;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(998, 268);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(220, 48);
            this.btn_ekle.TabIndex = 57;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(998, 376);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(220, 48);
            this.btn_ara.TabIndex = 56;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(998, 430);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(220, 48);
            this.btn_sil.TabIndex = 55;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(998, 484);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(220, 48);
            this.btn_guncelle.TabIndex = 54;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(998, 322);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(220, 48);
            this.btn_listele.TabIndex = 53;
            this.btn_listele.Text = "LİSTELE";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 556);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.cmb_odemeTuru);
            this.Controls.Add(this.txt_toplamTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_odemeTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_odemeNo);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Odeme";
            this.Text = "Odeme";
            this.Load += new System.EventHandler(this.Odeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_odemeTuru;
        private System.Windows.Forms.TextBox txt_toplamTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_odemeTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_odemeNo;
        private System.Windows.Forms.Label tc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_listele;
    }
}