using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siparis
{
    public partial class siparisekrani_form : Form
    {
        public siparisekrani_form()
        {
            InitializeComponent();
        }

        private void cayarti_btn_Click(object sender, EventArgs e)
        {
            int caysayisi = Convert.ToInt32(caysayisi_lbl.Text);
            caysayisi++;
            caysayisi_lbl.Text = Convert.ToString(caysayisi);
        }

        private void cayeksi_btn_Click(object sender, EventArgs e)
        {
            int caysayisi = Convert.ToInt32(caysayisi_lbl.Text);
            if (caysayisi > 0)
            {
                caysayisi--;
                caysayisi_lbl.Text = Convert.ToString(caysayisi);
            }
           
        }

        private void kahvearti_btn_Click(object sender, EventArgs e)
        {
            int kahvesayisi = Convert.ToInt32(kahvesayisi_lbl.Text);
            kahvesayisi++;
            kahvesayisi_lbl.Text = Convert.ToString(kahvesayisi);

        }

        private void kahveeksi_btn_Click(object sender, EventArgs e)
        {
            int kahvesayisi = Convert.ToInt32(kahvesayisi_lbl.Text);
            if (kahvesayisi > 0)
            {
                kahvesayisi--;
                kahvesayisi_lbl.Text = Convert.ToString(kahvesayisi);
            }
         

        }

        private void sodaarti_btn_Click(object sender, EventArgs e)
        {
            int sodasayisi = Convert.ToInt32(sodasayisi_lbl.Text);
            sodasayisi++;
            sodasayisi_lbl.Text = Convert.ToString(sodasayisi);

        }

        private void sodaeksi_btn_Click(object sender, EventArgs e)
        {
            int sodasayisi = Convert.ToInt32(sodasayisi_lbl.Text);
            if (sodasayisi > 0)
            {
                sodasayisi--;
                sodasayisi_lbl.Text = Convert.ToString(sodasayisi);

            }
        }

        private void sifirla_btn_Click(object sender, EventArgs e)
        {
            caysayisi_lbl.Text = Convert.ToString(0);
            kahvesayisi_lbl.Text = "0";
            sodasayisi_lbl.Text = "0";

        }

        private void tamamla_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SİPARİŞ ÖZETİ:" + caysayisi_lbl.Text + " ÇAY, " +  kahvesayisi_lbl.Text + " KAHVE, " + sodasayisi_lbl.Text + " SODA.");
        }

       
    }
}
