
namespace OyunKutuphanesi
{
    partial class FormTumOyunlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTumOyunlar));
            this.list_oyunlar = new System.Windows.Forms.ListBox();
            this.pb_oyunresmi = new System.Windows.Forms.PictureBox();
            this.btn_oyna = new System.Windows.Forms.Button();
            this.btn_kaldir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_oyunresmi)).BeginInit();
            this.SuspendLayout();
            // 
            // list_oyunlar
            // 
            this.list_oyunlar.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list_oyunlar.FormattingEnabled = true;
            this.list_oyunlar.ItemHeight = 17;
            this.list_oyunlar.Location = new System.Drawing.Point(12, 12);
            this.list_oyunlar.Name = "list_oyunlar";
            this.list_oyunlar.Size = new System.Drawing.Size(230, 412);
            this.list_oyunlar.TabIndex = 0;
            this.list_oyunlar.SelectedIndexChanged += new System.EventHandler(this.list_oyunlar_SelectedIndexChanged);
            // 
            // pb_oyunresmi
            // 
            this.pb_oyunresmi.Location = new System.Drawing.Point(257, 12);
            this.pb_oyunresmi.Name = "pb_oyunresmi";
            this.pb_oyunresmi.Size = new System.Drawing.Size(531, 243);
            this.pb_oyunresmi.TabIndex = 1;
            this.pb_oyunresmi.TabStop = false;
            // 
            // btn_oyna
            // 
            this.btn_oyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oyna.Image = ((System.Drawing.Image)(resources.GetObject("btn_oyna.Image")));
            this.btn_oyna.Location = new System.Drawing.Point(597, 270);
            this.btn_oyna.Name = "btn_oyna";
            this.btn_oyna.Size = new System.Drawing.Size(191, 162);
            this.btn_oyna.TabIndex = 2;
            this.btn_oyna.Text = "Oyna";
            this.btn_oyna.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_oyna.UseVisualStyleBackColor = true;
            this.btn_oyna.Click += new System.EventHandler(this.btn_oyna_Click);
            // 
            // btn_kaldir
            // 
            this.btn_kaldir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaldir.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaldir.Image")));
            this.btn_kaldir.Location = new System.Drawing.Point(257, 270);
            this.btn_kaldir.Name = "btn_kaldir";
            this.btn_kaldir.Size = new System.Drawing.Size(191, 162);
            this.btn_kaldir.TabIndex = 3;
            this.btn_kaldir.Text = "Kaldır";
            this.btn_kaldir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kaldir.UseVisualStyleBackColor = true;
            this.btn_kaldir.Click += new System.EventHandler(this.btn_kaldir_Click);
            // 
            // FormTumOyunlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_kaldir);
            this.Controls.Add(this.btn_oyna);
            this.Controls.Add(this.pb_oyunresmi);
            this.Controls.Add(this.list_oyunlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormTumOyunlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüm Oyunlar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTumOyunlar_FormClosed);
            this.Load += new System.EventHandler(this.FormTumOyunlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_oyunresmi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_oyunlar;
        private System.Windows.Forms.PictureBox pb_oyunresmi;
        private System.Windows.Forms.Button btn_oyna;
        private System.Windows.Forms.Button btn_kaldir;
    }
}