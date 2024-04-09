using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Kayitt
{
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciDetay ogrenciDetay = new OgrenciDetay();
            ogrenciDetay.numara = maskedTextBox1.Text;
            ogrenciDetay.Show();
        }


        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "111")
            {
                OgretmenDetay ogretmenDetay = new OgretmenDetay();
                ogretmenDetay.Show();
            }
        }
    }
}
