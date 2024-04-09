using NotKayit;
using System.Security.Cryptography;

namespace WinFormsApp1
{
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciDetay ogrenciDetay = new OgrenciDetay();
            ogrenciDetay.numara = maskedTextBox1.Text;

            ogrenciDetay.Show();

        }

    }
}