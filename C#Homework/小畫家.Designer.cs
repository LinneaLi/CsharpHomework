namespace C_Homework
{
    partial class 小畫家
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
            this.btnColor = new System.Windows.Forms.Button();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.SizetrackBar = new System.Windows.Forms.TrackBar();
            this.CanvasPanel1 = new System.Windows.Forms.Panel();
            this.labelColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SizetrackBar)).BeginInit();
            this.CanvasPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnColor.Location = new System.Drawing.Point(699, 16);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(88, 49);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "顏色";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sizeLabel.Location = new System.Drawing.Point(721, 285);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(20, 21);
            this.sizeLabel.TabIndex = 1;
            this.sizeLabel.Text = "1";
            // 
            // SizetrackBar
            // 
            this.SizetrackBar.Location = new System.Drawing.Point(725, 130);
            this.SizetrackBar.Maximum = 100;
            this.SizetrackBar.Name = "SizetrackBar";
            this.SizetrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SizetrackBar.Size = new System.Drawing.Size(45, 152);
            this.SizetrackBar.TabIndex = 3;
            this.SizetrackBar.Scroll += new System.EventHandler(this.SizetrackBar_Scroll);
            // 
            // CanvasPanel1
            // 
            this.CanvasPanel1.BackColor = System.Drawing.Color.White;
            this.CanvasPanel1.Controls.Add(this.labelColor);
            this.CanvasPanel1.Controls.Add(this.sizeLabel);
            this.CanvasPanel1.Controls.Add(this.SizetrackBar);
            this.CanvasPanel1.Controls.Add(this.btnColor);
            this.CanvasPanel1.Location = new System.Drawing.Point(1, 0);
            this.CanvasPanel1.Name = "CanvasPanel1";
            this.CanvasPanel1.Size = new System.Drawing.Size(801, 450);
            this.CanvasPanel1.TabIndex = 4;
            this.CanvasPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel1_MouseDown);
            this.CanvasPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel1_MouseMove);
            this.CanvasPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CanvasPanel1_MouseUp);
            // 
            // labelColor
            // 
            this.labelColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelColor.Location = new System.Drawing.Point(700, 78);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(87, 37);
            this.labelColor.TabIndex = 5;
            // 
            // 小畫家
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CanvasPanel1);
            this.Name = "小畫家";
            this.Text = "小畫家";
            ((System.ComponentModel.ISupportInitialize)(this.SizetrackBar)).EndInit();
            this.CanvasPanel1.ResumeLayout(false);
            this.CanvasPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TrackBar SizetrackBar;
        private System.Windows.Forms.Panel CanvasPanel1;
        private System.Windows.Forms.Label labelColor;
    }
}