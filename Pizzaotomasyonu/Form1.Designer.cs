namespace Pizzadeneme
{
    partial class Form1
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
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSepetiOnayla = new System.Windows.Forms.Button();
            this.listSepet = new System.Windows.Forms.ListBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rdbKalinKenar = new System.Windows.Forms.RadioButton();
            this.rdbInceKenar = new System.Windows.Forms.RadioButton();
            this.listPizzalar = new System.Windows.Forms.ListBox();
            this.cmbEbat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudAdet
            // 
            this.nudAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudAdet.Location = new System.Drawing.Point(84, 406);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(71, 26);
            this.nudAdet.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(808, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "TL";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(757, 370);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(45, 20);
            this.lblToplamTutar.TabIndex = 34;
            this.lblToplamTutar.Text = "------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(633, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Toplam Tutar :";
            // 
            // btnSepetiOnayla
            // 
            this.btnSepetiOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepetiOnayla.Location = new System.Drawing.Point(650, 398);
            this.btnSepetiOnayla.Name = "btnSepetiOnayla";
            this.btnSepetiOnayla.Size = new System.Drawing.Size(187, 35);
            this.btnSepetiOnayla.TabIndex = 32;
            this.btnSepetiOnayla.Text = "Sepeti Onayla";
            this.btnSepetiOnayla.UseVisualStyleBackColor = true;
            this.btnSepetiOnayla.Click += new System.EventHandler(this.btnSepetiOnayla_Click);
            // 
            // listSepet
            // 
            this.listSepet.FormattingEnabled = true;
            this.listSepet.HorizontalScrollbar = true;
            this.listSepet.ItemHeight = 16;
            this.listSepet.Location = new System.Drawing.Point(401, 12);
            this.listSepet.Name = "listSepet";
            this.listSepet.Size = new System.Drawing.Size(436, 340);
            this.listSepet.TabIndex = 31;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepeteEkle.Location = new System.Drawing.Point(481, 402);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(117, 29);
            this.btnSepeteEkle.TabIndex = 30;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Location = new System.Drawing.Point(370, 404);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(93, 24);
            this.txtTutar.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(311, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tutar:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(169, 404);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(117, 29);
            this.btnHesapla.TabIndex = 27;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Adet:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Controls.Add(this.checkBox10);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(73, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 168);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzemeler";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(133, 21);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(69, 21);
            this.checkBox6.TabIndex = 9;
            this.checkBox6.Text = "Salam";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(133, 48);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(69, 21);
            this.checkBox7.TabIndex = 8;
            this.checkBox7.Text = "Sucuk";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(133, 75);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(74, 21);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Mantar";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(133, 102);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(93, 21);
            this.checkBox9.TabIndex = 6;
            this.checkBox9.Text = "Ton Balığı";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(133, 129);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(70, 21);
            this.checkBox10.TabIndex = 5;
            this.checkBox10.Text = "Peynir";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(12, 129);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(69, 21);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Zeytin";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(12, 102);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(77, 21);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Ançuez";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 75);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(59, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Mısır";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 48);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(64, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Sosis";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Dana Jambon";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rdbKalinKenar
            // 
            this.rdbKalinKenar.AutoSize = true;
            this.rdbKalinKenar.Location = new System.Drawing.Point(241, 178);
            this.rdbKalinKenar.Name = "rdbKalinKenar";
            this.rdbKalinKenar.Size = new System.Drawing.Size(102, 21);
            this.rdbKalinKenar.TabIndex = 24;
            this.rdbKalinKenar.Text = "Kalın Kenar";
            this.rdbKalinKenar.UseVisualStyleBackColor = true;
            // 
            // rdbInceKenar
            // 
            this.rdbInceKenar.AutoSize = true;
            this.rdbInceKenar.Checked = true;
            this.rdbInceKenar.Location = new System.Drawing.Point(108, 178);
            this.rdbInceKenar.Name = "rdbInceKenar";
            this.rdbInceKenar.Size = new System.Drawing.Size(97, 21);
            this.rdbInceKenar.TabIndex = 23;
            this.rdbInceKenar.TabStop = true;
            this.rdbInceKenar.Text = "İnce Kenar";
            this.rdbInceKenar.UseVisualStyleBackColor = true;
            // 
            // listPizzalar
            // 
            this.listPizzalar.FormattingEnabled = true;
            this.listPizzalar.ItemHeight = 16;
            this.listPizzalar.Location = new System.Drawing.Point(73, 56);
            this.listPizzalar.Name = "listPizzalar";
            this.listPizzalar.Size = new System.Drawing.Size(286, 116);
            this.listPizzalar.TabIndex = 22;
            // 
            // cmbEbat
            // 
            this.cmbEbat.FormattingEnabled = true;
            this.cmbEbat.Location = new System.Drawing.Point(73, 12);
            this.cmbEbat.Name = "cmbEbat";
            this.cmbEbat.Size = new System.Drawing.Size(286, 24);
            this.cmbEbat.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Pizzalar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ebatlar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 456);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSepetiOnayla);
            this.Controls.Add(this.listSepet);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdbKalinKenar);
            this.Controls.Add(this.rdbInceKenar);
            this.Controls.Add(this.listPizzalar);
            this.Controls.Add(this.cmbEbat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSepetiOnayla;
        private System.Windows.Forms.ListBox listSepet;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton rdbKalinKenar;
        private System.Windows.Forms.RadioButton rdbInceKenar;
        private System.Windows.Forms.ListBox listPizzalar;
        private System.Windows.Forms.ComboBox cmbEbat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

