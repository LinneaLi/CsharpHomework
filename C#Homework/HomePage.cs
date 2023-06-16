using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Homework
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            SC2.Panel2.Controls.Clear();
             Frm_Hello frm01 = new Frm_Hello();
            frm01.TopLevel = false;                    //
            SC2.Panel2.Controls.Add(frm01); //開啟form的位置固定在SC2.Panel2裡
            frm01.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            SC2.Panel2.Controls.Clear();
            Frm_Loan frm02= new Frm_Loan();
            frm02.TopLevel = false;                    
            SC2.Panel2.Controls.Add(frm02); 
            frm02.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            SC2.Panel2.Controls.Clear();
            POS frm03 = new POS();
            frm03.TopLevel = false;
            SC2.Panel2.Controls.Add(frm03);
            frm03.Show();
        }

        private void btnStuStruct_Click(object sender, EventArgs e)
        {
            SC2.Panel2.Controls.Clear();
            Student_StructForm frm04 = new Student_StructForm();
            frm04.TopLevel = false;
            SC2.Panel2.Controls.Add(frm04);
            frm04.Show();
        }

        private void btn小畫家_Click(object sender, EventArgs e)
        {
            SC2.Panel2.Controls.Clear();
            小畫家 frm05 = new 小畫家();
            frm05.TopLevel = false;
            SC2.Panel2.Controls.Add(frm05);
            frm05.Show();
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            SC2.Panel2.Controls.Clear();
            ScreenSaver frm06 = new ScreenSaver();
           
            frm06.Show();
        }

        private void btnMyClac_Click(object sender, EventArgs e)
        {
            SC2.Panel2.Controls.Clear();
            MyClac frm07 = new MyClac();
            frm07.TopLevel = false;
            SC2.Panel2.Controls.Add(frm07);
            frm07.Show();
        }

        private void btnPictureViewer_Click(object sender, EventArgs e)
        {
            SC2.Panel2.Controls.Clear();
            PictureViewer frm08 = new PictureViewer();
            frm08.TopLevel = false;
            SC2.Panel2.Controls.Add(frm08);
            frm08.Show();
        }
    }
}
