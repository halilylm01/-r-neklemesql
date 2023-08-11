namespace Stajtablo
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.VeriEkleme = new System.Windows.Forms.TabPage();
            this.VeriListeleme = new System.Windows.Forms.TabPage();
            this.VeriSilme = new System.Windows.Forms.TabPage();
            this.Listele = new System.Windows.Forms.Button();
            this.ListelemeTablo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SilmeTablo = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Silme = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.VeriEkleme.SuspendLayout();
            this.VeriListeleme.SuspendLayout();
            this.VeriSilme.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(303, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(303, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 30);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(303, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 30);
            this.textBox2.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.VeriEkleme);
            this.tabControl1.Controls.Add(this.VeriListeleme);
            this.tabControl1.Controls.Add(this.VeriSilme);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 416);
            this.tabControl1.TabIndex = 6;
            // 
            // VeriEkleme
            // 
            this.VeriEkleme.Controls.Add(this.button1);
            this.VeriEkleme.Controls.Add(this.textBox2);
            this.VeriEkleme.Controls.Add(this.label1);
            this.VeriEkleme.Controls.Add(this.textBox1);
            this.VeriEkleme.Controls.Add(this.label2);
            this.VeriEkleme.Location = new System.Drawing.Point(4, 25);
            this.VeriEkleme.Name = "VeriEkleme";
            this.VeriEkleme.Padding = new System.Windows.Forms.Padding(3);
            this.VeriEkleme.Size = new System.Drawing.Size(780, 387);
            this.VeriEkleme.TabIndex = 0;
            this.VeriEkleme.Text = "Veri Ekleme";
            this.VeriEkleme.UseVisualStyleBackColor = true;
            // 
            // VeriListeleme
            // 
            this.VeriListeleme.Controls.Add(this.ListelemeTablo);
            this.VeriListeleme.Controls.Add(this.Listele);
            this.VeriListeleme.Location = new System.Drawing.Point(4, 25);
            this.VeriListeleme.Name = "VeriListeleme";
            this.VeriListeleme.Padding = new System.Windows.Forms.Padding(3);
            this.VeriListeleme.Size = new System.Drawing.Size(780, 387);
            this.VeriListeleme.TabIndex = 1;
            this.VeriListeleme.Text = "Veri Listeleme";
            this.VeriListeleme.UseVisualStyleBackColor = true;
            // 
            // VeriSilme
            // 
            this.VeriSilme.Controls.Add(this.Silme);
            this.VeriSilme.Controls.Add(this.SilmeTablo);
            this.VeriSilme.Location = new System.Drawing.Point(4, 25);
            this.VeriSilme.Name = "VeriSilme";
            this.VeriSilme.Size = new System.Drawing.Size(780, 387);
            this.VeriSilme.TabIndex = 2;
            this.VeriSilme.Text = "Veri Silme";
            this.VeriSilme.UseVisualStyleBackColor = true;
            // 
            // Listele
            // 
            this.Listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listele.Location = new System.Drawing.Point(301, 301);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(119, 44);
            this.Listele.TabIndex = 1;
            this.Listele.Text = "Listele";
            this.Listele.UseVisualStyleBackColor = true;
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // ListelemeTablo
            // 
            this.ListelemeTablo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ListelemeTablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListelemeTablo.HideSelection = false;
            this.ListelemeTablo.Location = new System.Drawing.Point(123, 6);
            this.ListelemeTablo.Name = "ListelemeTablo";
            this.ListelemeTablo.Size = new System.Drawing.Size(491, 269);
            this.ListelemeTablo.TabIndex = 2;
            this.ListelemeTablo.UseCompatibleStateImageBehavior = false;
            this.ListelemeTablo.View = System.Windows.Forms.View.Details;
            this.ListelemeTablo.SelectedIndexChanged += new System.EventHandler(this.ListelemeTablo_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün No";
            this.columnHeader1.Width = 255;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            this.columnHeader2.Width = 231;
            // 
            // SilmeTablo
            // 
            this.SilmeTablo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.SilmeTablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SilmeTablo.HideSelection = false;
            this.SilmeTablo.Location = new System.Drawing.Point(128, 14);
            this.SilmeTablo.Name = "SilmeTablo";
            this.SilmeTablo.Size = new System.Drawing.Size(491, 269);
            this.SilmeTablo.TabIndex = 3;
            this.SilmeTablo.UseCompatibleStateImageBehavior = false;
            this.SilmeTablo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün No";
            this.columnHeader3.Width = 255;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ürün Adı";
            this.columnHeader4.Width = 231;
            // 
            // Silme
            // 
            this.Silme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Silme.Location = new System.Drawing.Point(318, 289);
            this.Silme.Name = "Silme";
            this.Silme.Size = new System.Drawing.Size(91, 40);
            this.Silme.TabIndex = 4;
            this.Silme.Text = "Sil";
            this.Silme.UseVisualStyleBackColor = true;
            this.Silme.Click += new System.EventHandler(this.Silme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Yonca Kontrol Sistemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.VeriEkleme.ResumeLayout(false);
            this.VeriEkleme.PerformLayout();
            this.VeriListeleme.ResumeLayout(false);
            this.VeriSilme.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage VeriEkleme;
        private System.Windows.Forms.TabPage VeriListeleme;
        private System.Windows.Forms.Button Listele;
        private System.Windows.Forms.TabPage VeriSilme;
        private System.Windows.Forms.ListView ListelemeTablo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button Silme;
        private System.Windows.Forms.ListView SilmeTablo;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

