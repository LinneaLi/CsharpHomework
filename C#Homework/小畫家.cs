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
    public partial class 小畫家 : Form
    {
        private Color currentColor = Color.Black;
        private int currentSize = 1;
        private bool isDrawing = false;
        private Point lastPoint;


        public 小畫家()
        {
            InitializeComponent();
            CanvasPanel1.BackColor = Color.White;

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog.Color;
                labelColor.BackColor = currentColor;
            }
        }

        private void SizetrackBar_Scroll(object sender, EventArgs e)
        {
            currentSize = SizetrackBar.Value;
            sizeLabel.Text = $"Size: {currentSize}"; // 更新Label的內容
        }

        private void CanvasPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            lastPoint = e.Location;
        }

        private void CanvasPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics graphics = CanvasPanel1.CreateGraphics())
                {
                    Pen pen = new Pen(currentColor, currentSize);
                    graphics.DrawLine(pen, lastPoint, e.Location);
                    lastPoint = e.Location;
                }
            }
        }

        private void CanvasPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
    }
}
