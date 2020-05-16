using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace martabakkuZZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            homeUC1.BringToFront();
            Sidepanel.Height = btnHome.Height;
            Sidepanel.Top = btnHome.Top;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuUC1.BringToFront();
            Sidepanel.Height = btnMenu.Height;
            Sidepanel.Top = btnMenu.Top;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            homeUC1.BringToFront();
            Sidepanel.Height = btnHome.Height;
            Sidepanel.Top = btnHome.Top;
        }

        private void btnPesanMenu_Click(object sender, EventArgs e)
        {
            pesanUC1.BringToFront();
            Sidepanel.Height = btnPesanMenu.Height;
            Sidepanel.Top = btnPesanMenu.Top;
        }

        
    }
}
