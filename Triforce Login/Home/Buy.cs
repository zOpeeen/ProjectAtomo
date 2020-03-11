using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triforce_Login
{
    public partial class Buy : Form
    {
        public Buy()
        {
            InitializeComponent();
        }

        private void Buy_Load(object sender, EventArgs e)
        {
            qr1.Visible = false;
            qr2.Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gerarqr1_Click(object sender, EventArgs e)
        {
            qr1.Visible = true;
            qr2.Visible = false;
            week1.Text = "25,00 R$";
            month1.Text = "MONTH";
            // WARFACE WEEK
        }

        private void gerarqr2_Click(object sender, EventArgs e)
        {
            qr1.Visible = false;
            qr2.Visible = true;
            month1.Text = "80,00 R$";
            week1.Text = "WEEK";
            // WARFACE MONTH
        }

        private void gerarqr3_Click(object sender, EventArgs e)
        {
            qr3.Visible = true;
            qr4.Visible = false;
            week2.Text = "50,00 R$";
            month2.Text = "MONTH";
            // APEX LEGENDS WEEK
        }

        private void gerarqr4_Click(object sender, EventArgs e)
        {
            qr3.Visible = false;
            qr4.Visible = true;
            month2.Text = "130,00 R$";
            week2.Text = "WEEK";
            // APEX LEGENDS MONTH
        }

        private void gerarqr5_Click(object sender, EventArgs e)
        {
            qr5.Visible = true;
            qr6.Visible = false;
            week3.Text = "25,00 R$";
            month3.Text = "MONTH";
            // PUBG LITE WEEK
        }

        private void gerarqr6_Click(object sender, EventArgs e)
        {
            qr5.Visible = false;
            qr6.Visible = true;
            month3.Text = "50,00 R$";
            week3.Text = "WEEK";
            // PUBG LITE MONTH
        }

        private void gerarqr7_Click(object sender, EventArgs e)
        {
            qr7.Visible = true;
            qr8.Visible = false;
            week4.Text = "20,00 R$";
            month4.Text = "MONTH";
            // PUBG MOBILE WEEK
        }

        private void gerarqr8_Click(object sender, EventArgs e)
        {
            qr7.Visible = false;
            qr8.Visible = true;
            month4.Text = "50,00 R$";
            week4.Text = "WEEK";
            // PUBG MOBILE MONTH
        }

        private void gerarqr9_Click(object sender, EventArgs e)
        {
            qr9.Visible = true;
            qr10.Visible = false;
            week5.Text = "40,00 R$";
            month5.Text = "MONTH";
            // SQUAD WEEK
        }

        private void gerarqr10_Click(object sender, EventArgs e)
        {
            qr9.Visible = false;
            qr10.Visible = true;
            month5.Text = "130,00 R$";
            week5.Text = "WEEK";
            // SQUAD MONTH
        }


        private void buywarface_Click(object sender, EventArgs e)
        {
            qr1.Visible = false;
            qr2.Visible = false;
            week1.Text = "WEEK";
            month1.Text = "MONTH";

            pwarface.Visible = true;
            papex.Visible = false;
            ppubglite.Visible = false;
            psquad.Visible = false;
            ppubgmobile.Visible = false;
        }

        private void buyapex_Click_1(object sender, EventArgs e)
        {
            qr3.Visible = false;
            qr4.Visible = false;
            week2.Text = "WEEK";
            month2.Text = "MONTH";

            papex.Visible = true;
            pwarface.Visible = false;
            ppubglite.Visible = false;
            psquad.Visible = false;
            ppubgmobile.Visible = false;
        }

        private void buypubglite_Click_1(object sender, EventArgs e)
        {
            qr5.Visible = false;
            qr6.Visible = false;
            week3.Text = "WEEK";
            month3.Text = "MONTH";

            ppubglite.Visible = true;
            pwarface.Visible = false;
            papex.Visible = false;
            psquad.Visible = false;
            ppubgmobile.Visible = false;
        }

        private void buypubgmobile_Click_1(object sender, EventArgs e)
        {
            qr7.Visible = false;
            qr8.Visible = false;
            week4.Text = "WEEK";
            month4.Text = "MONTH";

            ppubgmobile.Visible = true;
            pwarface.Visible = false;
            psquad.Visible = false;
            papex.Visible = false;
            ppubglite.Visible = false;
        }

        private void buysquad_Click_1(object sender, EventArgs e)
        {
            qr9.Visible = false;
            qr10.Visible = false;
            week5.Text = "WEEK";
            month5.Text = "MONTH";

            psquad.Visible = true;
            pwarface.Visible = false;
            ppubglite.Visible = false;
            papex.Visible = false;
            ppubgmobile.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hide();
            Form b = new Authentication();
            b.Closed += (s, args) => Close();
            b.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
