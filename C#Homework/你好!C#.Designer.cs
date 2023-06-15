namespace C_Homework
{
    partial class Frm_Hello
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
            this.labEnName = new System.Windows.Forms.Label();
            this.labSex = new System.Windows.Forms.Label();
            this.labStar = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEnName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtStar = new System.Windows.Forms.TextBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labName.Location = new System.Drawing.Point(257, 187);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(46, 21);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名:";
            // 
            // labEnName
            // 
            this.labEnName.AutoSize = true;
            this.labEnName.BackColor = System.Drawing.Color.Transparent;
            this.labEnName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labEnName.Location = new System.Drawing.Point(257, 226);
            this.labEnName.Name = "labEnName";
            this.labEnName.Size = new System.Drawing.Size(119, 21);
            this.labEnName.TabIndex = 1;
            this.labEnName.Text = "English Name:";
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.BackColor = System.Drawing.Color.Transparent;
            this.labSex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSex.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labSex.Location = new System.Drawing.Point(257, 271);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(46, 21);
            this.labSex.TabIndex = 2;
            this.labSex.Text = "性別:";
            // 
            // labStar
            // 
            this.labStar.AutoSize = true;
            this.labStar.BackColor = System.Drawing.Color.Transparent;
            this.labStar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labStar.Location = new System.Drawing.Point(257, 312);
            this.labStar.Name = "labStar";
            this.labStar.Size = new System.Drawing.Size(46, 21);
            this.labStar.TabIndex = 3;
            this.labStar.Text = "星座:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(382, 179);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 29);
            this.txtName.TabIndex = 4;
            // 
            // txtEnName
            // 
            this.txtEnName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnName.Location = new System.Drawing.Point(382, 223);
            this.txtEnName.Name = "txtEnName";
            this.txtEnName.Size = new System.Drawing.Size(141, 29);
            this.txtEnName.TabIndex = 5;
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSex.Location = new System.Drawing.Point(382, 263);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(141, 29);
            this.txtSex.TabIndex = 6;
            // 
            // txtStar
            // 
            this.txtStar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStar.Location = new System.Drawing.Point(382, 304);
            this.txtStar.Name = "txtStar";
            this.txtStar.Size = new System.Drawing.Size(141, 29);
            this.txtStar.TabIndex = 7;
            // 
            // btnHello
            // 
            this.btnHello.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHello.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHello.ForeColor = System.Drawing.Color.IndianRed;
            this.btnHello.Location = new System.Drawing.Point(237, 348);
            this.btnHello.Name = "btnHello";
            this.btnHello.Padding = new System.Windows.Forms.Padding(3);
            this.btnHello.Size = new System.Drawing.Size(139, 44);
            this.btnHello.TabIndex = 8;
            this.btnHello.Text = "Say  HELLO !";
            this.btnHello.UseVisualStyleBackColor = false;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnHi
            // 
            this.btnHi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHi.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHi.ForeColor = System.Drawing.Color.IndianRed;
            this.btnHi.Location = new System.Drawing.Point(413, 348);
            this.btnHi.Name = "btnHi";
            this.btnHi.Padding = new System.Windows.Forms.Padding(3);
            this.btnHi.Size = new System.Drawing.Size(139, 44);
            this.btnHi.TabIndex = 9;
            this.btnHi.Text = "Say  HI !";
            this.btnHi.UseVisualStyleBackColor = false;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // Frm_Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::C_Homework.Properties.Resources.你好_背景圖;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 549);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.txtStar);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtEnName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labStar);
            this.Controls.Add(this.labSex);
            this.Controls.Add(this.labEnName);
            this.Controls.Add(this.labName);
            this.DoubleBuffered = true;
            this.Name = "Frm_Hello";
            this.Text = "你好!C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labEnName;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Label labStar;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEnName;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtStar;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnHi;
    }
}