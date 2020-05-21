namespace Bir_Kelime
{
    partial class Form_Kelime
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Harfler = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Kelime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Puan = new System.Windows.Forms.Label();
            this.button_Tekrarla = new System.Windows.Forms.Button();
            this.button_Cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Harfler
            // 
            this.label_Harfler.AutoSize = true;
            this.label_Harfler.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Harfler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.label_Harfler.Location = new System.Drawing.Point(337, 48);
            this.label_Harfler.Name = "label_Harfler";
            this.label_Harfler.Size = new System.Drawing.Size(224, 40);
            this.label_Harfler.TabIndex = 0;
            this.label_Harfler.Text = "1 2 3 4 5 6 7 8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gelen Harfler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(25, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bulunan Kelime";
            // 
            // label_Kelime
            // 
            this.label_Kelime.AutoSize = true;
            this.label_Kelime.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Kelime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(80)))));
            this.label_Kelime.Location = new System.Drawing.Point(337, 108);
            this.label_Kelime.Name = "label_Kelime";
            this.label_Kelime.Size = new System.Drawing.Size(238, 40);
            this.label_Kelime.TabIndex = 3;
            this.label_Kelime.Text = "EQWERTYUI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(25, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Puan";
            // 
            // label_Puan
            // 
            this.label_Puan.AutoSize = true;
            this.label_Puan.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.label_Puan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.label_Puan.Location = new System.Drawing.Point(338, 170);
            this.label_Puan.Name = "label_Puan";
            this.label_Puan.Size = new System.Drawing.Size(53, 40);
            this.label_Puan.TabIndex = 5;
            this.label_Puan.Text = "10";
            // 
            // button_Tekrarla
            // 
            this.button_Tekrarla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Tekrarla.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Tekrarla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.button_Tekrarla.Location = new System.Drawing.Point(175, 240);
            this.button_Tekrarla.Name = "button_Tekrarla";
            this.button_Tekrarla.Size = new System.Drawing.Size(239, 40);
            this.button_Tekrarla.TabIndex = 6;
            this.button_Tekrarla.Text = "Tekrarla Oynat";
            this.button_Tekrarla.UseVisualStyleBackColor = true;
            this.button_Tekrarla.Click += new System.EventHandler(this.button_Tekrarla_Click);
            // 
            // button_Cikis
            // 
            this.button_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cikis.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Cikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(7)))), ((int)(((byte)(63)))));
            this.button_Cikis.Location = new System.Drawing.Point(567, 3);
            this.button_Cikis.Name = "button_Cikis";
            this.button_Cikis.Size = new System.Drawing.Size(25, 25);
            this.button_Cikis.TabIndex = 7;
            this.button_Cikis.Text = "X";
            this.button_Cikis.UseVisualStyleBackColor = true;
            this.button_Cikis.Click += new System.EventHandler(this.button_Cikis_Click);
            // 
            // Form_Kelime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(595, 327);
            this.Controls.Add(this.button_Cikis);
            this.Controls.Add(this.button_Tekrarla);
            this.Controls.Add(this.label_Puan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_Kelime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Harfler);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Kelime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime";
            this.Load += new System.EventHandler(this.Form_Kelime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Harfler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Kelime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Puan;
        private System.Windows.Forms.Button button_Tekrarla;
        private System.Windows.Forms.Button button_Cikis;
    }
}

