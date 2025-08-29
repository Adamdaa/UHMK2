namespace UHMK2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            jm = new ComboBox();
            nm = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            jumlah = new TextBox();
            harga = new TextBox();
            nomernota = new TextBox();
            totalharga = new TextBox();
            potongan = new TextBox();
            totalbayar = new TextBox();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 115);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "TANGAL TRANSAKSI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 202);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 1;
            label2.Text = "JENIS MAKANAN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 254);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 2;
            label3.Text = "NAMA MAKANAN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 331);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "JUMLAH";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 381);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 4;
            label5.Text = "HARGA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(507, 115);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 5;
            label6.Text = "NO NOTA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(507, 415);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 6;
            label7.Text = "TOTAL HARGA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(507, 463);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 7;
            label8.Text = "POTONGAN";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(507, 510);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 8;
            label9.Text = "TOTAL BAYAR";
            // 
            // jm
            // 
            jm.FormattingEnabled = true;
            jm.Location = new Point(194, 199);
            jm.Name = "jm";
            jm.Size = new Size(151, 28);
            jm.TabIndex = 9;
            jm.SelectedIndexChanged += jm_SelectedIndexChanged;
            // 
            // nm
            // 
            nm.FormattingEnabled = true;
            nm.Location = new Point(194, 251);
            nm.Name = "nm";
            nm.Size = new Size(151, 28);
            nm.TabIndex = 10;
            nm.SelectedIndexChanged += nm_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(194, 110);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // jumlah
            // 
            jumlah.Location = new Point(194, 328);
            jumlah.Name = "jumlah";
            jumlah.Size = new Size(125, 27);
            jumlah.TabIndex = 12;
            // 
            // harga
            // 
            harga.Location = new Point(194, 378);
            harga.Name = "harga";
            harga.Size = new Size(125, 27);
            harga.TabIndex = 13;
            // 
            // nomernota
            // 
            nomernota.Location = new Point(629, 112);
            nomernota.Name = "nomernota";
            nomernota.Size = new Size(125, 27);
            nomernota.TabIndex = 14;
            // 
            // totalharga
            // 
            totalharga.Location = new Point(629, 412);
            totalharga.Name = "totalharga";
            totalharga.Size = new Size(125, 27);
            totalharga.TabIndex = 15;
            // 
            // potongan
            // 
            potongan.Location = new Point(629, 460);
            potongan.Name = "potongan";
            potongan.Size = new Size(125, 27);
            potongan.TabIndex = 16;
            // 
            // totalbayar
            // 
            totalbayar.Location = new Point(629, 507);
            totalbayar.Name = "totalbayar";
            totalbayar.Size = new Size(125, 27);
            totalbayar.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(369, 29);
            label10.Name = "label10";
            label10.Size = new Size(145, 20);
            label10.TabIndex = 18;
            label10.Text = "Angkringan Pak Toro";
            // 
            // button1
            // 
            button1.Location = new Point(94, 483);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 19;
            button1.Text = "HITUNG";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(288, 483);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 20;
            button2.Text = "BERSIH";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(660, 575);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 21;
            button3.Text = "EXIT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.ImageLocation = "picturebox1";
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(456, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 260);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(899, 616);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(totalbayar);
            Controls.Add(potongan);
            Controls.Add(totalharga);
            Controls.Add(nomernota);
            Controls.Add(harga);
            Controls.Add(jumlah);
            Controls.Add(dateTimePicker1);
            Controls.Add(nm);
            Controls.Add(jm);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox jm;
        private ComboBox nm;
        private DateTimePicker dateTimePicker1;
        private TextBox jumlah;
        private TextBox harga;
        private TextBox nomernota;
        private TextBox totalharga;
        private TextBox potongan;
        private TextBox totalbayar;
        private Label label10;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}
