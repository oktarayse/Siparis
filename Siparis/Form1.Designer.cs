
namespace Siparis
{
    partial class siparisekrani_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siparisekrani_form));
            this.groupbox_siparis = new System.Windows.Forms.GroupBox();
            this.sodaeksi_btn = new System.Windows.Forms.Button();
            this.sodaarti_btn = new System.Windows.Forms.Button();
            this.kahveeksi_btn = new System.Windows.Forms.Button();
            this.kahvearti_btn = new System.Windows.Forms.Button();
            this.sodasayisi_lbl = new System.Windows.Forms.Label();
            this.cayeksi_btn = new System.Windows.Forms.Button();
            this.kahvesayisi_lbl = new System.Windows.Forms.Label();
            this.soda_label = new System.Windows.Forms.Label();
            this.cayarti_btn = new System.Windows.Forms.Button();
            this.label_kahve = new System.Windows.Forms.Label();
            this.caysayisi_lbl = new System.Windows.Forms.Label();
            this.label_cay = new System.Windows.Forms.Label();
            this.sifirla_btn = new System.Windows.Forms.Button();
            this.tamamla_btn = new System.Windows.Forms.Button();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.groupbox_siparis.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox_siparis
            // 
            this.groupbox_siparis.Controls.Add(this.sodaeksi_btn);
            this.groupbox_siparis.Controls.Add(this.sodaarti_btn);
            this.groupbox_siparis.Controls.Add(this.kahveeksi_btn);
            this.groupbox_siparis.Controls.Add(this.kahvearti_btn);
            this.groupbox_siparis.Controls.Add(this.sodasayisi_lbl);
            this.groupbox_siparis.Controls.Add(this.cayeksi_btn);
            this.groupbox_siparis.Controls.Add(this.kahvesayisi_lbl);
            this.groupbox_siparis.Controls.Add(this.soda_label);
            this.groupbox_siparis.Controls.Add(this.cayarti_btn);
            this.groupbox_siparis.Controls.Add(this.label_kahve);
            this.groupbox_siparis.Controls.Add(this.caysayisi_lbl);
            this.groupbox_siparis.Controls.Add(this.label_cay);
            this.groupbox_siparis.Location = new System.Drawing.Point(12, 12);
            this.groupbox_siparis.Name = "groupbox_siparis";
            this.groupbox_siparis.Size = new System.Drawing.Size(522, 234);
            this.groupbox_siparis.TabIndex = 0;
            this.groupbox_siparis.TabStop = false;
            this.groupbox_siparis.Text = "SİPARİŞ";
            // 
            // sodaeksi_btn
            // 
            this.sodaeksi_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sodaeksi_btn.Location = new System.Drawing.Point(313, 156);
            this.sodaeksi_btn.Name = "sodaeksi_btn";
            this.sodaeksi_btn.Size = new System.Drawing.Size(53, 33);
            this.sodaeksi_btn.TabIndex = 3;
            this.sodaeksi_btn.Text = "-";
            this.sodaeksi_btn.UseVisualStyleBackColor = true;
            this.sodaeksi_btn.Click += new System.EventHandler(this.sodaeksi_btn_Click);
            // 
            // sodaarti_btn
            // 
            this.sodaarti_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sodaarti_btn.Location = new System.Drawing.Point(222, 156);
            this.sodaarti_btn.Name = "sodaarti_btn";
            this.sodaarti_btn.Size = new System.Drawing.Size(55, 33);
            this.sodaarti_btn.TabIndex = 2;
            this.sodaarti_btn.Text = "+";
            this.sodaarti_btn.UseVisualStyleBackColor = true;
            this.sodaarti_btn.Click += new System.EventHandler(this.sodaarti_btn_Click);
            // 
            // kahveeksi_btn
            // 
            this.kahveeksi_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kahveeksi_btn.Location = new System.Drawing.Point(313, 108);
            this.kahveeksi_btn.Name = "kahveeksi_btn";
            this.kahveeksi_btn.Size = new System.Drawing.Size(53, 33);
            this.kahveeksi_btn.TabIndex = 3;
            this.kahveeksi_btn.Text = "-";
            this.kahveeksi_btn.UseVisualStyleBackColor = true;
            this.kahveeksi_btn.Click += new System.EventHandler(this.kahveeksi_btn_Click);
            // 
            // kahvearti_btn
            // 
            this.kahvearti_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kahvearti_btn.Location = new System.Drawing.Point(222, 108);
            this.kahvearti_btn.Name = "kahvearti_btn";
            this.kahvearti_btn.Size = new System.Drawing.Size(55, 33);
            this.kahvearti_btn.TabIndex = 2;
            this.kahvearti_btn.Text = "+";
            this.kahvearti_btn.UseVisualStyleBackColor = true;
            this.kahvearti_btn.Click += new System.EventHandler(this.kahvearti_btn_Click);
            // 
            // sodasayisi_lbl
            // 
            this.sodasayisi_lbl.AutoSize = true;
            this.sodasayisi_lbl.Location = new System.Drawing.Point(154, 161);
            this.sodasayisi_lbl.Name = "sodasayisi_lbl";
            this.sodasayisi_lbl.Size = new System.Drawing.Size(16, 17);
            this.sodasayisi_lbl.TabIndex = 1;
            this.sodasayisi_lbl.Text = "0";
            // 
            // cayeksi_btn
            // 
            this.cayeksi_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cayeksi_btn.Location = new System.Drawing.Point(313, 52);
            this.cayeksi_btn.Name = "cayeksi_btn";
            this.cayeksi_btn.Size = new System.Drawing.Size(53, 33);
            this.cayeksi_btn.TabIndex = 3;
            this.cayeksi_btn.Text = "-";
            this.cayeksi_btn.UseVisualStyleBackColor = true;
            this.cayeksi_btn.Click += new System.EventHandler(this.cayeksi_btn_Click);
            // 
            // kahvesayisi_lbl
            // 
            this.kahvesayisi_lbl.AutoSize = true;
            this.kahvesayisi_lbl.Location = new System.Drawing.Point(154, 108);
            this.kahvesayisi_lbl.Name = "kahvesayisi_lbl";
            this.kahvesayisi_lbl.Size = new System.Drawing.Size(16, 17);
            this.kahvesayisi_lbl.TabIndex = 1;
            this.kahvesayisi_lbl.Text = "0";
            // 
            // soda_label
            // 
            this.soda_label.AutoSize = true;
            this.soda_label.Location = new System.Drawing.Point(85, 161);
            this.soda_label.Name = "soda_label";
            this.soda_label.Size = new System.Drawing.Size(47, 17);
            this.soda_label.TabIndex = 0;
            this.soda_label.Text = "SODA";
            // 
            // cayarti_btn
            // 
            this.cayarti_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cayarti_btn.Location = new System.Drawing.Point(222, 52);
            this.cayarti_btn.Name = "cayarti_btn";
            this.cayarti_btn.Size = new System.Drawing.Size(55, 33);
            this.cayarti_btn.TabIndex = 2;
            this.cayarti_btn.Text = "+";
            this.cayarti_btn.UseVisualStyleBackColor = true;
            this.cayarti_btn.Click += new System.EventHandler(this.cayarti_btn_Click);
            // 
            // label_kahve
            // 
            this.label_kahve.AutoSize = true;
            this.label_kahve.Location = new System.Drawing.Point(85, 108);
            this.label_kahve.Name = "label_kahve";
            this.label_kahve.Size = new System.Drawing.Size(54, 17);
            this.label_kahve.TabIndex = 0;
            this.label_kahve.Text = "KAHVE";
            // 
            // caysayisi_lbl
            // 
            this.caysayisi_lbl.AutoSize = true;
            this.caysayisi_lbl.Location = new System.Drawing.Point(154, 55);
            this.caysayisi_lbl.Name = "caysayisi_lbl";
            this.caysayisi_lbl.Size = new System.Drawing.Size(16, 17);
            this.caysayisi_lbl.TabIndex = 1;
            this.caysayisi_lbl.Text = "0";
            // 
            // label_cay
            // 
            this.label_cay.AutoSize = true;
            this.label_cay.Location = new System.Drawing.Point(85, 55);
            this.label_cay.Name = "label_cay";
            this.label_cay.Size = new System.Drawing.Size(35, 17);
            this.label_cay.TabIndex = 0;
            this.label_cay.Text = "ÇAY";
            // 
            // sifirla_btn
            // 
            this.sifirla_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifirla_btn.Image = ((System.Drawing.Image)(resources.GetObject("sifirla_btn.Image")));
            this.sifirla_btn.Location = new System.Drawing.Point(12, 252);
            this.sifirla_btn.Name = "sifirla_btn";
            this.sifirla_btn.Size = new System.Drawing.Size(151, 62);
            this.sifirla_btn.TabIndex = 1;
            this.sifirla_btn.Text = "SIFIRLA";
            this.sifirla_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sifirla_btn.UseVisualStyleBackColor = true;
            this.sifirla_btn.Click += new System.EventHandler(this.sifirla_btn_Click);
            // 
            // tamamla_btn
            // 
            this.tamamla_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tamamla_btn.Image = ((System.Drawing.Image)(resources.GetObject("tamamla_btn.Image")));
            this.tamamla_btn.Location = new System.Drawing.Point(169, 253);
            this.tamamla_btn.Name = "tamamla_btn";
            this.tamamla_btn.Size = new System.Drawing.Size(191, 60);
            this.tamamla_btn.TabIndex = 1;
            this.tamamla_btn.Text = "SİPARİŞİ TAMAMLA";
            this.tamamla_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tamamla_btn.UseVisualStyleBackColor = true;
            this.tamamla_btn.Click += new System.EventHandler(this.tamamla_btn_Click);
            // 
            // cikis_btn
            // 
            this.cikis_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis_btn.Image = ((System.Drawing.Image)(resources.GetObject("cikis_btn.Image")));
            this.cikis_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cikis_btn.Location = new System.Drawing.Point(379, 254);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(146, 60);
            this.cikis_btn.TabIndex = 2;
            this.cikis_btn.Text = "ÇIKIŞ";
            this.cikis_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cikis_btn.UseVisualStyleBackColor = true;
            // 
            // siparisekrani_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 393);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.tamamla_btn);
            this.Controls.Add(this.sifirla_btn);
            this.Controls.Add(this.groupbox_siparis);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MinimizeBox = false;
            this.Name = "siparisekrani_form";
            this.Text = "SİPARİŞ EKRANI";
            this.groupbox_siparis.ResumeLayout(false);
            this.groupbox_siparis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox_siparis;
        private System.Windows.Forms.Button sodaeksi_btn;
        private System.Windows.Forms.Button sodaarti_btn;
        private System.Windows.Forms.Button kahveeksi_btn;
        private System.Windows.Forms.Button kahvearti_btn;
        private System.Windows.Forms.Label sodasayisi_lbl;
        private System.Windows.Forms.Button cayeksi_btn;
        private System.Windows.Forms.Label kahvesayisi_lbl;
        private System.Windows.Forms.Label soda_label;
        private System.Windows.Forms.Button cayarti_btn;
        private System.Windows.Forms.Label label_kahve;
        private System.Windows.Forms.Label caysayisi_lbl;
        private System.Windows.Forms.Label label_cay;
        private System.Windows.Forms.Button sifirla_btn;
        private System.Windows.Forms.Button tamamla_btn;
        private System.Windows.Forms.Button cikis_btn;
    }
}

