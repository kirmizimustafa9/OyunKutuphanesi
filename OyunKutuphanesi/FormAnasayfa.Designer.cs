
namespace OyunKutuphanesi
{
    partial class FormAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnasayfa));
            this.btn_tumOyunlar = new System.Windows.Forms.Button();
            this.btn_oyunekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_tumOyunlar
            // 
            this.btn_tumOyunlar.Font = new System.Drawing.Font("Miriam", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tumOyunlar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_tumOyunlar.Image = ((System.Drawing.Image)(resources.GetObject("btn_tumOyunlar.Image")));
            this.btn_tumOyunlar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_tumOyunlar.Location = new System.Drawing.Point(12, 12);
            this.btn_tumOyunlar.Name = "btn_tumOyunlar";
            this.btn_tumOyunlar.Size = new System.Drawing.Size(234, 142);
            this.btn_tumOyunlar.TabIndex = 0;
            this.btn_tumOyunlar.Text = "Tüm Oyunlar";
            this.btn_tumOyunlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_tumOyunlar.UseVisualStyleBackColor = true;
            this.btn_tumOyunlar.Click += new System.EventHandler(this.btn_tumOyunlar_Click);
            // 
            // btn_oyunekle
            // 
            this.btn_oyunekle.Font = new System.Drawing.Font("Miriam", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oyunekle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_oyunekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_oyunekle.Image")));
            this.btn_oyunekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_oyunekle.Location = new System.Drawing.Point(554, 12);
            this.btn_oyunekle.Name = "btn_oyunekle";
            this.btn_oyunekle.Size = new System.Drawing.Size(234, 142);
            this.btn_oyunekle.TabIndex = 1;
            this.btn_oyunekle.Text = "Oyun Ekle";
            this.btn_oyunekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_oyunekle.UseVisualStyleBackColor = true;
            this.btn_oyunekle.Click += new System.EventHandler(this.btn_oyunekle_Click);
            // 
            // FormAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_oyunekle);
            this.Controls.Add(this.btn_tumOyunlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yakisikli Oyun Kütüphanesi";
            this.Load += new System.EventHandler(this.FormAnasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_tumOyunlar;
        private System.Windows.Forms.Button btn_oyunekle;
    }
}

