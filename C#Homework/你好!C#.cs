using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Homework
{
    public partial class Frm_Hello : Form
    {
        public Frm_Hello()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string EnName = txtEnName.Text;
            string sex=txtSex.Text;
            string star = txtStar.Text;

            MessageBox.Show("Hello,我是 " + name + "," + "\n"
                                               + "英文名字是" + EnName + "," + "\n"
                                               + "性別是" + sex + "," + "\n"
                                               + "星座是" + star + "," + "\n"
                                               + "很高興認識你!");
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string EnName = txtEnName.Text;
            string sex = txtSex.Text;
            string star = txtStar.Text;

            MessageBox.Show("Hello,我是 " + name + "," + "\n" 
                                               + "英文名字是" + EnName + "," + "\n" 
                                               + "性別是" + sex + "," + "\n" 
                                               + "星座是" + star + "," + "\n"
                                               + "很高興認識你!");
        }
    }
}
