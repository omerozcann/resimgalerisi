namespace resimgalerisi
{
    partial class rgFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.klasoracbtn = new System.Windows.Forms.Button();
            this.resimpb = new System.Windows.Forms.PictureBox();
            this.resimlistlv = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resimpb)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resimpb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 576);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resimlistlv);
            this.groupBox2.Location = new System.Drawing.Point(740, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 477);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resim Listesi";
            // 
            // klasoracbtn
            // 
            this.klasoracbtn.Location = new System.Drawing.Point(876, 523);
            this.klasoracbtn.Name = "klasoracbtn";
            this.klasoracbtn.Size = new System.Drawing.Size(108, 44);
            this.klasoracbtn.TabIndex = 2;
            this.klasoracbtn.Text = "Klasör Aç";
            this.klasoracbtn.UseVisualStyleBackColor = true;
            this.klasoracbtn.Click += new System.EventHandler(this.klasoracbtn_Click);
            // 
            // resimpb
            // 
            this.resimpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resimpb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resimpb.Location = new System.Drawing.Point(3, 18);
            this.resimpb.Name = "resimpb";
            this.resimpb.Size = new System.Drawing.Size(716, 555);
            this.resimpb.TabIndex = 0;
            this.resimpb.TabStop = false;
            // 
            // resimlistlv
            // 
            this.resimlistlv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resimlistlv.HideSelection = false;
            this.resimlistlv.Location = new System.Drawing.Point(3, 18);
            this.resimlistlv.MultiSelect = false;
            this.resimlistlv.Name = "resimlistlv";
            this.resimlistlv.Size = new System.Drawing.Size(366, 456);
            this.resimlistlv.TabIndex = 0;
            this.resimlistlv.UseCompatibleStateImageBehavior = false;
            this.resimlistlv.SelectedIndexChanged += new System.EventHandler(this.resimlistlv_SelectedIndexChanged);
            this.resimlistlv.Click += new System.EventHandler(this.resimlistlv_Click);
            // 
            // rgFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 600);
            this.Controls.Add(this.klasoracbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "rgFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resim Galerisi V1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resimpb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button klasoracbtn;
        private System.Windows.Forms.PictureBox resimpb;
        private System.Windows.Forms.ListView resimlistlv;
    }
}

