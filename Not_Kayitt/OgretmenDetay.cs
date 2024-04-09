using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Not_Kayitt
{
    public partial class OgretmenDetay : Form
    {
        public OgretmenDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2FA3KGC;Initial Catalog=DbNotKayit;Integrated Security=True");

        private void OgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayitDataSet.TBLDERSLER' table. You can move, or remove it, as needed.
            this.tBLDERSLERTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERSLER);

        }

        private void ogrenci_ekle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERSLER(OGRNUMARA,OGRAD,OGRSOYAD) values(@P1,@P2,@P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", mskNumara.Text);
            komut.Parameters.AddWithValue("@P2", mskAd.Text);
            komut.Parameters.AddWithValue("@P3", mskSoyad.Text);
            //komut.Parameters.AddWithValue("@P3", mskSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi");
            this.tBLDERSLERTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERSLER);


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;


            mskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            mskAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            mskS1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mskS2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mskS3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void ogrenci_guncelle_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(mskS1.Text);
            s2 = Convert.ToDouble(mskS2.Text);
            s3 = Convert.ToDouble(mskS3.Text);


            ortalama = (s1 + s2 + s3) / 3;
            LblOrtalama.Text = ortalama.ToString();

            if (ortalama>=50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }


            baglanti.Open();

            SqlCommand komut = new SqlCommand("update TBLDERSLER set OGRS1= @p1, OGRS2=@p2, OGRS3=@p3, ORTALAMA = @p4, DURUM =@p5 WHERE OGRNUMARA = @p6", baglanti);

            komut.Parameters.AddWithValue("@p1", mskS1.Text);
            komut.Parameters.AddWithValue("@p2", mskS2.Text);
            komut.Parameters.AddWithValue("@p3", mskS3.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(LblOrtalama.Text));
            komut.Parameters.AddWithValue("@p5",durum);
            komut.Parameters.AddWithValue("@p6", mskNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi");
            this.tBLDERSLERTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERSLER);


        }
    }
}
