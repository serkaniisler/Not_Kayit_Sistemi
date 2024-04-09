namespace Not_Kayit_Sistemi
{
    partial class FrmOgretmenDetay
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            groupBox3 = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Location = new Point(12, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 182);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ÖğrenciEkle";
            // 
            // button1
            // 
            button1.Location = new Point(101, 139);
            button1.Name = "button1";
            button1.Size = new Size(140, 37);
            button1.TabIndex = 6;
            button1.Text = "Öğrenci Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 106);
            label3.Name = "label3";
            label3.Size = new Size(51, 18);
            label3.TabIndex = 5;
            label3.Text = "Soyad";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 26);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 74);
            label2.Name = "label2";
            label2.Size = new Size(28, 18);
            label2.TabIndex = 3;
            label2.Text = "Ad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 26);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 37);
            label1.Name = "label1";
            label1.Size = new Size(66, 18);
            label1.TabIndex = 1;
            label1.Text = "Numara";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(101, 34);
            maskedTextBox1.Mask = "0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(140, 26);
            maskedTextBox1.TabIndex = 0;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(268, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(272, 182);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "SınavNotları";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 106);
            label6.Name = "label6";
            label6.Size = new Size(56, 18);
            label6.TabIndex = 8;
            label6.Text = "Sınav3";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(119, 98);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(140, 26);
            textBox5.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(119, 139);
            button2.Name = "button2";
            button2.Size = new Size(140, 37);
            button2.TabIndex = 6;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 74);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 5;
            label4.Text = "Sınav2";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(119, 66);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 26);
            textBox3.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 42);
            label5.Name = "label5";
            label5.Size = new Size(55, 18);
            label5.TabIndex = 3;
            label5.Text = "Sınav1";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(119, 34);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(140, 26);
            textBox4.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(557, 32);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(268, 182);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "SınavNotları";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(150, 106);
            label12.Name = "label12";
            label12.Size = new Size(28, 18);
            label12.TabIndex = 11;
            label12.Text = "00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(150, 74);
            label11.Name = "label11";
            label11.Size = new Size(28, 18);
            label11.TabIndex = 10;
            label11.Text = "00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(150, 42);
            label10.Name = "label10";
            label10.Size = new Size(28, 18);
            label10.TabIndex = 9;
            label10.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 106);
            label7.Name = "label7";
            label7.Size = new Size(98, 18);
            label7.TabIndex = 8;
            label7.Text = "Kalan Sayısı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 74);
            label8.Name = "label8";
            label8.Size = new Size(102, 18);
            label8.TabIndex = 5;
            label8.Text = "Geçen Sayısı:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 42);
            label9.Name = "label9";
            label9.Size = new Size(84, 18);
            label9.TabIndex = 3;
            label9.Text = "Ortalama: ";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(12, 220);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(813, 309);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(807, 284);
            dataGridView1.TabIndex = 0;
            // 
            // FrmOgretmenDetay
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(844, 575);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmOgretmenDetay";
            Text = "FrmOgretmenDetay";
            Load += FrmOgretmenDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox textBox5;
        private Button button2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private GroupBox groupBox3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label12;
        private Label label11;
        private Label label10;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
    }
}