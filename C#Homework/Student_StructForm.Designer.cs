namespace C_Homework
{
    partial class Student_StructForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labName = new System.Windows.Forms.Label();
            this.labeCh = new System.Windows.Forms.Label();
            this.labEn = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChScore = new System.Windows.Forms.TextBox();
            this.txtEnScore = new System.Windows.Forms.TextBox();
            this.txtMaScore = new System.Windows.Forms.TextBox();
            this.Scores = new System.Windows.Forms.GroupBox();
            this.labMaxMin = new System.Windows.Forms.Label();
            this.labShow = new System.Windows.Forms.Label();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.Scores.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(71, 96);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(45, 20);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名:";
            // 
            // labeCh
            // 
            this.labeCh.AutoSize = true;
            this.labeCh.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labeCh.Location = new System.Drawing.Point(71, 153);
            this.labeCh.Name = "labeCh";
            this.labeCh.Size = new System.Drawing.Size(45, 20);
            this.labeCh.TabIndex = 1;
            this.labeCh.Text = "國文:";
            // 
            // labEn
            // 
            this.labEn.AutoSize = true;
            this.labEn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEn.Location = new System.Drawing.Point(71, 204);
            this.labEn.Name = "labEn";
            this.labEn.Size = new System.Drawing.Size(45, 20);
            this.labEn.TabIndex = 2;
            this.labEn.Text = "英文:";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(71, 256);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(45, 20);
            this.labMath.TabIndex = 3;
            this.labMath.Text = "數學:";
            // 
            // btnStore
            // 
            this.btnStore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStore.Location = new System.Drawing.Point(75, 312);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(69, 38);
            this.btnStore.TabIndex = 4;
            this.btnStore.Text = "儲存";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.Location = new System.Drawing.Point(158, 312);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(119, 38);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "顯示儲存內容";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(138, 87);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 29);
            this.txtName.TabIndex = 6;
            this.txtName.Text = "0";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChScore
            // 
            this.txtChScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChScore.Location = new System.Drawing.Point(138, 144);
            this.txtChScore.Multiline = true;
            this.txtChScore.Name = "txtChScore";
            this.txtChScore.Size = new System.Drawing.Size(139, 29);
            this.txtChScore.TabIndex = 7;
            this.txtChScore.Text = "0";
            this.txtChScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEnScore
            // 
            this.txtEnScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnScore.Location = new System.Drawing.Point(138, 195);
            this.txtEnScore.Multiline = true;
            this.txtEnScore.Name = "txtEnScore";
            this.txtEnScore.Size = new System.Drawing.Size(139, 29);
            this.txtEnScore.TabIndex = 8;
            this.txtEnScore.Text = "0";
            this.txtEnScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaScore
            // 
            this.txtMaScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMaScore.Location = new System.Drawing.Point(138, 247);
            this.txtMaScore.Multiline = true;
            this.txtMaScore.Name = "txtMaScore";
            this.txtMaScore.Size = new System.Drawing.Size(139, 29);
            this.txtMaScore.TabIndex = 9;
            this.txtMaScore.Text = "0";
            this.txtMaScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Scores
            // 
            this.Scores.Controls.Add(this.labMaxMin);
            this.Scores.Controls.Add(this.labShow);
            this.Scores.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Scores.Location = new System.Drawing.Point(408, 73);
            this.Scores.Name = "Scores";
            this.Scores.Size = new System.Drawing.Size(277, 277);
            this.Scores.TabIndex = 10;
            this.Scores.TabStop = false;
            this.Scores.Text = "成績";
            // 
            // labMaxMin
            // 
            this.labMaxMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labMaxMin.Location = new System.Drawing.Point(28, 182);
            this.labMaxMin.Name = "labMaxMin";
            this.labMaxMin.Size = new System.Drawing.Size(228, 80);
            this.labMaxMin.TabIndex = 1;
            // 
            // labShow
            // 
            this.labShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShow.Location = new System.Drawing.Point(28, 38);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(228, 127);
            this.labShow.TabIndex = 0;
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMaxMin.Location = new System.Drawing.Point(509, 366);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(155, 38);
            this.btnMaxMin.TabIndex = 6;
            this.btnMaxMin.Text = "最高分/最低分科目";
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // Student_StructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.Scores);
            this.Controls.Add(this.txtMaScore);
            this.Controls.Add(this.txtEnScore);
            this.Controls.Add(this.txtChScore);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEn);
            this.Controls.Add(this.labeCh);
            this.Controls.Add(this.labName);
            this.Name = "Student_StructForm";
            this.Text = "Student_StructForm";
            this.Scores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labeCh;
        private System.Windows.Forms.Label labEn;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChScore;
        private System.Windows.Forms.TextBox txtEnScore;
        private System.Windows.Forms.TextBox txtMaScore;
        private System.Windows.Forms.GroupBox Scores;
        private System.Windows.Forms.Label labMaxMin;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.Button btnMaxMin;
    }
}