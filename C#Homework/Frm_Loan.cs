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
    public partial class Frm_Loan : Form
    {
        private double Year;

        public Frm_Loan()
        {
            InitializeComponent();
            Year = 0;
        }

        double LoanMethod() 
        {
            double Money = double.Parse(txtAmount.Text);
             Year = double.Parse(txtInstallment.Text);
            double Rate = double.Parse(txtRate.Text);
            double Dpay = double.Parse(txtDownPayment.Text);

            double monthInterest =
               (Math.Pow((1 + Rate / 1200), Year * 12) * Rate / 1200) /
               (Math.Pow((1 + Rate / 1200), Year * 12) - 1);
          double monthback = Math.Round((Money - Dpay) * monthInterest);
          return monthback;
        }

        //月付額
        private void btnPMT_Click(object sender, EventArgs e)
        {
            double monthlyPayment = LoanMethod();
            MessageBox.Show("月付額：" + monthlyPayment + "元");
        }

        //總付
        private void btnTotal_Click(object sender, EventArgs e)
        {
            double monthlyPayment = LoanMethod();
            double totalPay = monthlyPayment * 12 * Year;
            MessageBox.Show("總付款： " + totalPay + "元");
        }
        public static double RepLoan;
        public static double RepPeriod;
        public static double RepRate;
        public static double RepPMT = 0;
        public static double RepTotalPay = 0;

        private void btnReport_Click(object sender, EventArgs e)
        {
            //RepLoan = double.Parse(txtAmount.Text);
            //RepPeriod = double.Parse(txtInstallment.Text);
            //RepRate = double.Parse(txtRate.Text);
            //RepPMT = loan.monthMethod();
            //RepTotalPay = loan.totalloanMethod();

            LoanReport report = new LoanReport();
            report.Show();
        }
    }
}
