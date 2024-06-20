
namespace OyunKutuphanesi
{
    partial class FormOyunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOyunEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_oyunAdi = new System.Windows.Forms.TextBox();
            this.fileDialog_oyunyolu = new System.Windows.Forms.OpenFileDialog();
            this.btn_yolsec = new System.Windows.Forms.Button();
            this.lbl_yol = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_resimsec = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.fileDialog_resimyolu = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(192, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oyun Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(192, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oyun Yolu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(192, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Oyun Resmi";
            // 
            // txt_oyunAdi
            // 
            this.txt_oyunAdi.Location = new System.Drawing.Point(338, 46);
            this.txt_oyunAdi.Name = "txt_oyunAdi";
            this.txt_oyunAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_oyunAdi.TabIndex = 3;
            // 
            // fileDialog_oyunyolu
            // 
            this.fileDialog_oyunyolu.InitialDirectory = "c:\\\\";
            // 
            // btn_yolsec
            // 
            this.btn_yolsec.Location = new System.Drawing.Point(338, 94);
            this.btn_yolsec.Name = "btn_yolsec";
            this.btn_yolsec.Size = new System.Drawing.Size(75, 23);
            this.btn_yolsec.TabIndex = 4;
            this.btn_yolsec.Text = "Seç";
            this.btn_yolsec.UseVisualStyleBackColor = true;
            this.btn_yolsec.Click += new System.EventHandler(this.btn_yolsec_Click);
            // 
            // lbl_yol
            // 
            this.lbl_yol.AutoSize = true;
            this.lbl_yol.Location = new System.Drawing.Point(442, 99);
            this.lbl_yol.Name = "lbl_yol";
            this.lbl_yol.Size = new System.Drawing.Size(52, 13);
            this.lbl_yol.TabIndex = 5;
            this.lbl_yol.Text = "Secilmedi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Secilmedi";
            // 
            // lbl_resimsec
            // 
            this.lbl_resimsec.Location = new System.Drawing.Point(338, 144);
            this.lbl_resimsec.Name = "lbl_resimsec";
            this.lbl_resimsec.Size = new System.Drawing.Size(75, 23);
            this.lbl_resimsec.TabIndex = 6;
            this.lbl_resimsec.Text = "Seç";
            this.lbl_resimsec.UseVisualStyleBackColor = true;
            this.lbl_resimsec.Click += new System.EventHandler(this.lbl_resimsec_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(195, 227);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(299, 23);
            this.btn_kaydet.TabIndex = 8;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // FormOyunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_resimsec);
            this.Controls.Add(this.lbl_yol);
            this.Controls.Add(this.btn_yolsec);
            this.Controls.Add(this.txt_oyunAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormOyunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oyun Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_oyunAdi;
        private System.Windows.Forms.OpenFileDialog fileDialog_oyunyolu;
        private System.Windows.Forms.Button btn_yolsec;
        private System.Windows.Forms.Label lbl_yol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button lbl_resimsec;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.OpenFileDialog fileDialog_resimyolu;
    }
}