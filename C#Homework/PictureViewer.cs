using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Homework
{
    public partial class PictureViewer : Form
    {
        public PictureViewer()
        {
            InitializeComponent();
        }

        private void pBox1_Click(object sender, EventArgs e)
        {
            ImageViewerForm imageViewer = new ImageViewerForm();
            imageViewer.SetImage(pBox1.Image); // 將圖片 A 傳遞給 ImageViewerForm
            imageViewer.ShowDialog(); // 顯示 ImageViewerForm 的視窗
        }

        private void pBox2_Click(object sender, EventArgs e)
        {
            ImageViewerForm imageViewer = new ImageViewerForm();
            imageViewer.SetImage(pBox2.Image); 
            imageViewer.ShowDialog();
        }

        private void pBox3_Click(object sender, EventArgs e)
        {
            ImageViewerForm imageViewer = new ImageViewerForm();
            imageViewer.SetImage(pBox3.Image);
            imageViewer.ShowDialog();
        }

        private void pBox4_Click(object sender, EventArgs e)
        {
            ImageViewerForm imageViewer = new ImageViewerForm();
            imageViewer.SetImage(pBox4.Image);
            imageViewer.ShowDialog();
        }

        private void pBox5_Click(object sender, EventArgs e)
        {
            ImageViewerForm imageViewer = new ImageViewerForm();
            imageViewer.SetImage(pBox5.Image);
            imageViewer.ShowDialog();
        }

        private void pBox6_Click(object sender, EventArgs e)
        {
            ImageViewerForm imageViewer = new ImageViewerForm();
            imageViewer.SetImage(pBox6.Image);
            imageViewer.ShowDialog();
        }

        private void pBox7_Click(object sender, EventArgs e)
        {
            ImageViewerForm imageViewer = new ImageViewerForm();
            imageViewer.SetImage(pBox7.Image);
            imageViewer.ShowDialog();
        }

        private void pBox8_Click(object sender, EventArgs e)
        {
            ImageViewerForm imageViewer = new ImageViewerForm();
            imageViewer.SetImage(pBox8.Image);
            imageViewer.ShowDialog();
        }
    }
}
