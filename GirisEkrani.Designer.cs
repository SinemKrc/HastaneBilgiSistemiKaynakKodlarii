namespace VTYS_HastaneDB
{
    partial class GirisEkrani
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
            this.btn_form1 = new System.Windows.Forms.Button();
            this.btn_odeme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_form1
            // 
            this.btn_form1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_form1.Location = new System.Drawing.Point(500, 191);
            this.btn_form1.Name = "btn_form1";
            this.btn_form1.Size = new System.Drawing.Size(142, 88);
            this.btn_form1.TabIndex = 1;
            this.btn_form1.Text = "ÖDEME İŞLEMLERİ";
            this.btn_form1.UseVisualStyleBackColor = true;
            this.btn_form1.Click += new System.EventHandler(this.btn_form1_Click);
            // 
            // btn_odeme
            // 
            this.btn_odeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_odeme.Location = new System.Drawing.Point(180, 191);
            this.btn_odeme.Name = "btn_odeme";
            this.btn_odeme.Size = new System.Drawing.Size(142, 88);
            this.btn_odeme.TabIndex = 2;
            this.btn_odeme.Text = "HASTA İŞLEMLERİ";
            this.btn_odeme.UseVisualStyleBackColor = true;
            this.btn_odeme.Click += new System.EventHandler(this.btn_odeme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(175, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ..";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_odeme);
            this.Controls.Add(this.btn_form1);
            this.Name = "GirisEkrani";
            this.Text = "GirisEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_form1;
        private System.Windows.Forms.Button btn_odeme;
        private System.Windows.Forms.Label label1;
    }
}