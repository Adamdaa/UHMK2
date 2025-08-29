namespace UHMK2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jm.Items.Add("Seafood");
            jm.Items.Add("daging");
            jm.Items.Add("ayam");
        }

        private void jm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jm.Text == "Seafood")
            {
                nm.Items.Clear();
                // Tambahkan item seafood
                nm.Items.Add("Udang");
                nm.Items.Add("Ikan");
                nm.Items.Add("Cumi");
                nm.Items.Add("Kepiting");
                nm.Items.Add("Kerang"); // Menambahkan kerang untuk contoh harga
            }
            else if (jm.Text == "daging")
            {
                nm.Items.Clear();
                // Tambahkan item daging
                nm.Items.Add("Sapi");
                nm.Items.Add("Kambing");
                nm.Items.Add("Domba");
            }
            else if (jm.Text == "ayam")
            {
                nm.Items.Clear();
                // Tambahkan item ayam
                nm.Items.Add("Ayam Goreng");
                nm.Items.Add("Ayam Bakar");
                nm.Items.Add("Ayam Geprek");
            }
        }

        private void nm_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Perbaikan syntax dari VB.NET ke C#
            if (nm.Text == "Kerang")
            {
                harga.Text = "5000";
            }
            else if (nm.Text == "Udang")
            {
                harga.Text = "15000";
            }
            else if (nm.Text == "Ikan")
            {
                harga.Text = "12000";
            }
            else if (nm.Text == "Cumi")
            {
                harga.Text = "18000";
            }
            else if (nm.Text == "Kepiting")
            {
                harga.Text = "25000";
            }
            else if (nm.Text == "Sapi")
            {
                harga.Text = "20000";
            }
            else if (nm.Text == "Kambing")
            {
                harga.Text = "22000";
            }
            else if (nm.Text == "Domba")
            {
                harga.Text = "24000";
            }
            else if (nm.Text == "Ayam Goreng")
            {
                harga.Text = "10000";
            }
            else if (nm.Text == "Ayam Bakar")
            {
                harga.Text = "12000";
            }
            else if (nm.Text == "Ayam Geprek")
            {
                harga.Text = "11000";
            }
            else
            {
                harga.Text = "0"; // Default jika tidak ada yang dipilih
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi input dan konversi ke integer
                if (int.TryParse(harga.Text, out int hargaValue) &&
                    int.TryParse(jumlah.Text, out int jumlahValue))
                {
                    // Hitung total harga
                    int totalHarga = hargaValue * jumlahValue;
                    totalharga.Text = totalHarga.ToString();

                    // Tentukan potongan harga
                    int potonganValue = totalHarga > 50000 ? 5000 : 0;
                    potongan.Text = potonganValue.ToString();

                    // Hitung total bayar
                    int totalBayar = totalHarga - potonganValue;
                    totalbayar.Text = totalBayar.ToString();
                }
                else
                {
                    MessageBox.Show("Masukkan angka yang valid untuk harga dan jumlah!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // PERBAIKAN: Tambahkan semicolon dan string quotes
            jm.Text = "";
            nm.Text = "";
            harga.Text = "";
            jumlah.Text = "";
            totalbayar.Text = "";
            potongan.Text = "";
            totalharga.Text = "";

            // Reset ComboBox selections
            jm.SelectedIndex = -1;
            nm.SelectedIndex = -1;

            // Clear nm items
            nm.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // PERBAIKAN: Gunakan Application.Exit() atau this.Close()

            // Opsi 1: Tutup aplikasi sepenuhnya
            Application.Exit();

            // Opsi 2: Hanya tutup form ini (jika ada form lain)
            // this.Close();

            // Opsi 3: Tutup dengan konfirmasi
            // DialogResult result = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", 
            //     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // if (result == DialogResult.Yes)
            // {
            //     Application.Exit();
            // }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}