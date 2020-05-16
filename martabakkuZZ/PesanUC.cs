using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace martabakkuZZ
{
    public partial class PesanUC : UserControl
    {
        public PesanUC()
        {
            InitializeComponent();
        }

        private void PesanUC_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxMartabak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMartabak.SelectedIndex == 0)
            {
                groupBoxTelor.Visible = true;
                groupBoxManis.Visible = false;
                buttonPesanan.Visible = true;
            }
            if (comboBoxMartabak.SelectedIndex == 1)
            {
                groupBoxTelor.Visible = false;
                groupBoxManis.Visible = true;
                buttonPesanan.Visible = true;
                
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxManis_VisibleChanged(object sender, EventArgs e)
        {
            comboBoxManis.SelectedIndex = 0;
        }

        private void groupBoxTelor_VisibleChanged(object sender, EventArgs e)
        {
            comboBoxTelor.SelectedIndex = 0;
        }

        private void buttonPesanan_Click(object sender, EventArgs e)
        {
            groupBoxPesanan.Visible = true;
            Stack stack = new Stack();            
            int harga = 0;
            if (comboBoxMartabak.SelectedIndex == 0)
            {
                if (comboBoxTelor.SelectedIndex == 0)
                {
                    harga += 10000;
                }
                if (comboBoxTelor.SelectedIndex == 1)
                {
                    harga += 15000;
                }
                if (comboBoxTelor.SelectedIndex == 2)

                {
                    harga += 20000;
                }
                if (checkBoxKejuTelor.Checked == true)
                {
                    harga += 10000;
                    stack.Push("Keju Mozarella");
                }
                if (checkBoxKornet.Checked == true)
                {
                    harga += 7000;
                    stack.Push("Kornet");
                }
                if (checkBoxAbon.Checked == true)
                {
                    harga += 5000;
                    stack.Push("Abon");
                }

                labelPesanan2.Text = comboBoxTelor.Text;
            }
            if (comboBoxMartabak.SelectedIndex == 1)
            {
                if (comboBoxManis.SelectedIndex == 0)
                {
                    harga += 10000;
                }
                if (comboBoxManis.SelectedIndex == 1)
                {
                    harga += 15000;
                }
                if (comboBoxManis.SelectedIndex == 2)
                {
                    harga += 20000;
                }
                if (checkBoxKejuManis.Checked == true)
                {
                    harga += 10000;
                    stack.Push("Keju");
                }
                if (checkBoxCoklat.Checked == true)
                {
                    harga += 6000;
                    stack.Push("Coklat");
                }
                if (checkBoxKismis.Checked == true)
                {
                    harga += 5000;
                    stack.Push("Kismis");
                }
                
                labelPesanan2.Text = comboBoxManis.Text;
            }
            string a = "";
            foreach (Object obj in stack) {
               a += "-" + obj + " ";
            }
            labelPesanan3.Text = a;
            Harga.Text = "Rp. " +  Convert.ToString(harga) + ",00";
            labelPesanan1.Text = comboBoxMartabak.Text;
            buttonPesan.Visible = true;
            buttonHapus.Visible = true;
            buttonPesanan.Visible = false;
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            groupBoxPesanan.Visible = false;
            buttonPesan.Visible = false;
            buttonHapus.Visible = false;
            buttonPesanan.Visible = true;
            labelPesanan3.Text = "";
            
        }

        private void buttonPesan_Click(object sender, EventArgs e)
        {
            string selesai = "Pesanan anda : " + labelPesanan1.Text +" dengan Varian " + labelPesanan2.Text + " dan topping " +labelPesanan3.Text+ " Total:"+Harga.Text+ " sudah kami terima.";
            MessageBox.Show(selesai +" Terimakasih sudah memesan martabak di Martabakku ");
            Environment.Exit(0);
        }

       
    }
}
