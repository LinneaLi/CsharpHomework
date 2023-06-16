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
    public partial class ImageViewerForm : Form
    {
        public ImageViewerForm()
        {
            InitializeComponent();
        }
        public void SetImage(Image image)
        {
            pictureBox2.Image = image; // 設定 pictureBox2 的圖片為傳遞進來的圖片
        }
    }
}
