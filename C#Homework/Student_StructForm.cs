using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace C_Homework
{
    public partial class Student_StructForm : Form
    {
        public struct Student
        {
            public string Name;
            public int ChScore;
            public int EnScore;
            public int MaScore;

        }

            public Student_StructForm()
        {
            InitializeComponent();
        }
        Student stu;
        string StudentResult = "";

        public void btnStore_Click(object sender, EventArgs e)
        {
            Student stu;
            stu.Name = txtName.Text;
            stu.ChScore = int.Parse(txtChScore.Text);
            stu.EnScore = int.Parse(txtEnScore.Text);
            stu.MaScore = int.Parse(txtMaScore.Text);
            
            StudentResult = "姓名:" + stu.Name + "\n" + "國文:" + stu.ChScore + "\n" + "英文:" + stu.EnScore+ "\n" + "數學:" + stu.MaScore;
        }
        

        public void btnShow_Click(object sender, EventArgs e)
            {
                labShow.Text = StudentResult;
            }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            Student stu;
            stu.ChScore = int.Parse(txtChScore.Text);
            stu.EnScore = int.Parse(txtEnScore.Text);
            stu.MaScore = int.Parse(txtMaScore.Text);
            int[] scores = { stu.ChScore, stu.EnScore, stu.MaScore };
            string[] subjects = { "國文", "英文", "數學" };

            int MaxScore = scores.Max(); //最高分
            int MinScore = scores.Min(); //最低分
            string HighestSubject = subjects[Array.IndexOf(scores, MaxScore)];
            string LowestSubject = subjects[Array.IndexOf(scores, MinScore)];

            labMaxMin.Text = $"最高科目成績為：{HighestSubject}{MaxScore}分"
           +$"\r\n最低分科目成績為：{LowestSubject}{MinScore}分";
        }
    }
    }

