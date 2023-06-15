using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace C_Homework
{
    public partial class POS : Form

    {
        public POS()
        {
            InitializeComponent();
        }
        int TotalPrice = 0;
        int BeerCount = 0;
        int TequilaCount = 0;
        int WhiskyCount = 0;
        int WineCount = 0;
        int BeerTotal = 0;
        int TequilaTotal = 0;
        int WhiskyTotal = 0;
        int WineTotal = 0;

        StringBuilder itemlist = new StringBuilder();

        private void btnBeer_Click(object sender, EventArgs e)
        {
            TotalPrice += 120;
            BeerCount++;
            BeerTotal = BeerCount * 120;
            labShowTotal.Text = $"NT$ {TotalPrice}";
            UpdateItemList();
        }
        private void btnTequila_Click(object sender, EventArgs e)
        {
            TotalPrice += 180;
            TequilaCount++;
            TequilaTotal = TequilaCount * 180;
            labShowTotal.Text = $"NT$ {TotalPrice}";
            UpdateItemList();
        }
        private void btnWisky_Click(object sender, EventArgs e)
        {
            TotalPrice += 350;
            WhiskyCount++;
            WhiskyTotal = WhiskyCount * 350;
            labShowTotal.Text = $"NT$ {TotalPrice}";
            UpdateItemList();
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            TotalPrice += 320;
            WineCount++;
            WineTotal = WineCount * 320;
            labShowTotal.Text = $"NT$ {TotalPrice}";
            UpdateItemList();
        }

        private void UpdateItemList()
        {
            itemlist.Clear();
            if (BeerCount > 0)
                itemlist.AppendLine($"啤酒 x{BeerCount}, 共NT${BeerTotal}元");
            if (TequilaCount > 0)
                itemlist.AppendLine($"龍舌蘭 x{TequilaCount}, 共NT${TequilaTotal}元");
            if (WhiskyCount > 0)
                itemlist.AppendLine($"威士忌 x{WhiskyCount}, 共NT${WhiskyTotal}元");
            if (WineCount > 0)
                itemlist.AppendLine($"紅酒 x{WineCount}, 共NT${WineTotal}元");
            list.Text = itemlist.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearList();
        }
        private void ClearList()
        {
            TotalPrice = 0;
            BeerCount = 0;
            TequilaCount = 0;
            WhiskyCount = 0;
            WineCount = 0;
            itemlist.Clear();
            list.Text = "尚未點餐";
            labShowTotal.Text = "NT$ 0";
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show($"總金額:{TotalPrice}元","確認付款", MessageBoxButtons.OKCancel);
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            double DiscountPrice = ( TotalPrice) * 0.9;
            DialogResult Result = MessageBox.Show($"總金額:{TotalPrice}元" + "\n" +
                $"折扣後金額:{DiscountPrice}元 ","確認付款", MessageBoxButtons.OKCancel);
        }
    }
}
