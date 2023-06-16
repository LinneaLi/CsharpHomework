namespace C_Homework
{
    partial class POS
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
            this.groupMenu = new System.Windows.Forms.GroupBox();
            this.labMenu = new System.Windows.Forms.Label();
            this.groupTotal = new System.Windows.Forms.GroupBox();
            this.labShowTotal = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.groupPay = new System.Windows.Forms.GroupBox();
            this.labCard = new System.Windows.Forms.Label();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.labPay = new System.Windows.Forms.Label();
            this.groupList = new System.Windows.Forms.GroupBox();
            this.list = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnWisky = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.btnBeer = new System.Windows.Forms.Button();
            this.groupMenu.SuspendLayout();
            this.groupTotal.SuspendLayout();
            this.groupPay.SuspendLayout();
            this.groupList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMenu
            // 
            this.groupMenu.AutoSize = true;
            this.groupMenu.Controls.Add(this.btnWine);
            this.groupMenu.Controls.Add(this.btnWisky);
            this.groupMenu.Controls.Add(this.btnTequila);
            this.groupMenu.Controls.Add(this.btnBeer);
            this.groupMenu.Controls.Add(this.labMenu);
            this.groupMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupMenu.Location = new System.Drawing.Point(21, 54);
            this.groupMenu.Name = "groupMenu";
            this.groupMenu.Size = new System.Drawing.Size(224, 315);
            this.groupMenu.TabIndex = 0;
            this.groupMenu.TabStop = false;
            // 
            // labMenu
            // 
            this.labMenu.AutoSize = true;
            this.labMenu.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMenu.Location = new System.Drawing.Point(7, 13);
            this.labMenu.Name = "labMenu";
            this.labMenu.Size = new System.Drawing.Size(91, 21);
            this.labMenu.TabIndex = 0;
            this.labMenu.Text = "菜單 Menu";
            // 
            // groupTotal
            // 
            this.groupTotal.Controls.Add(this.labShowTotal);
            this.groupTotal.Controls.Add(this.labTotal);
            this.groupTotal.Location = new System.Drawing.Point(281, 54);
            this.groupTotal.Name = "groupTotal";
            this.groupTotal.Size = new System.Drawing.Size(245, 159);
            this.groupTotal.TabIndex = 1;
            this.groupTotal.TabStop = false;
            // 
            // labShowTotal
            // 
            this.labShowTotal.BackColor = System.Drawing.Color.Black;
            this.labShowTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShowTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowTotal.ForeColor = System.Drawing.Color.White;
            this.labShowTotal.Location = new System.Drawing.Point(34, 83);
            this.labShowTotal.Name = "labShowTotal";
            this.labShowTotal.Size = new System.Drawing.Size(172, 37);
            this.labShowTotal.TabIndex = 7;
            this.labShowTotal.Text = "NT$ 0";
            this.labShowTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotal.Location = new System.Drawing.Point(6, 32);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(137, 21);
            this.labTotal.TabIndex = 5;
            this.labTotal.Text = "總金額Total Price";
            // 
            // groupPay
            // 
            this.groupPay.Controls.Add(this.labCard);
            this.groupPay.Controls.Add(this.btnCard);
            this.groupPay.Controls.Add(this.btnCash);
            this.groupPay.Controls.Add(this.labPay);
            this.groupPay.Location = new System.Drawing.Point(281, 219);
            this.groupPay.Name = "groupPay";
            this.groupPay.Size = new System.Drawing.Size(245, 150);
            this.groupPay.TabIndex = 2;
            this.groupPay.TabStop = false;
            // 
            // labCard
            // 
            this.labCard.AutoSize = true;
            this.labCard.BackColor = System.Drawing.Color.Transparent;
            this.labCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labCard.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCard.Location = new System.Drawing.Point(105, 107);
            this.labCard.Name = "labCard";
            this.labCard.Size = new System.Drawing.Size(110, 23);
            this.labCard.TabIndex = 7;
            this.labCard.Text = "信用卡享9折!";
            // 
            // btnCard
            // 
            this.btnCard.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCard.Location = new System.Drawing.Point(131, 54);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(75, 39);
            this.btnCard.TabIndex = 5;
            this.btnCard.Text = "信用卡";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCash.Location = new System.Drawing.Point(34, 54);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(75, 39);
            this.btnCash.TabIndex = 4;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // labPay
            // 
            this.labPay.AutoSize = true;
            this.labPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPay.Location = new System.Drawing.Point(6, 18);
            this.labPay.Name = "labPay";
            this.labPay.Size = new System.Drawing.Size(74, 21);
            this.labPay.TabIndex = 6;
            this.labPay.Text = "付款方式";
            // 
            // groupList
            // 
            this.groupList.Controls.Add(this.list);
            this.groupList.Controls.Add(this.btnClear);
            this.groupList.Controls.Add(this.label1);
            this.groupList.Location = new System.Drawing.Point(543, 54);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(245, 315);
            this.groupList.TabIndex = 3;
            this.groupList.TabStop = false;
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.White;
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.list.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.list.Location = new System.Drawing.Point(20, 50);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(200, 188);
            this.list.TabIndex = 4;
            this.list.Text = "尚未點餐";
            this.list.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(122, 256);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 39);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "購物清單 List";
            // 
            // btnWine
            // 
            this.btnWine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWine.Image = global::C_Homework.Properties.Resources.wine_glasses;
            this.btnWine.Location = new System.Drawing.Point(126, 176);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(76, 103);
            this.btnWine.TabIndex = 4;
            this.btnWine.Text = "紅酒 Wine NT320";
            this.btnWine.UseVisualStyleBackColor = false;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // btnWisky
            // 
            this.btnWisky.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWisky.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWisky.Image = global::C_Homework.Properties.Resources.alcohol;
            this.btnWisky.Location = new System.Drawing.Point(33, 176);
            this.btnWisky.Name = "btnWisky";
            this.btnWisky.Size = new System.Drawing.Size(76, 103);
            this.btnWisky.TabIndex = 3;
            this.btnWisky.Text = "威士忌 Whisky NT350";
            this.btnWisky.UseVisualStyleBackColor = false;
            this.btnWisky.Click += new System.EventHandler(this.btnWisky_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTequila.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTequila.Image = global::C_Homework.Properties.Resources.tequila_shot;
            this.btnTequila.Location = new System.Drawing.Point(126, 50);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(76, 103);
            this.btnTequila.TabIndex = 2;
            this.btnTequila.Text = "龍舌蘭 Tequila NT180";
            this.btnTequila.UseVisualStyleBackColor = false;
            this.btnTequila.Click += new System.EventHandler(this.btnTequila_Click);
            // 
            // btnBeer
            // 
            this.btnBeer.BackColor = System.Drawing.Color.White;
            this.btnBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBeer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBeer.Image = global::C_Homework.Properties.Resources.beer_mug;
            this.btnBeer.Location = new System.Drawing.Point(33, 50);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(76, 103);
            this.btnBeer.TabIndex = 1;
            this.btnBeer.Text = "啤酒 BEER NT120";
            this.btnBeer.UseVisualStyleBackColor = false;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.groupPay);
            this.Controls.Add(this.groupTotal);
            this.Controls.Add(this.groupMenu);
            this.Name = "POS";
            this.Text = "POS";
            this.groupMenu.ResumeLayout(false);
            this.groupMenu.PerformLayout();
            this.groupTotal.ResumeLayout(false);
            this.groupTotal.PerformLayout();
            this.groupPay.ResumeLayout(false);
            this.groupPay.PerformLayout();
            this.groupList.ResumeLayout(false);
            this.groupList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMenu;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Label labMenu;
        private System.Windows.Forms.Button btnWisky;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.GroupBox groupTotal;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.GroupBox groupPay;
        private System.Windows.Forms.Label labCard;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label labPay;
        private System.Windows.Forms.GroupBox groupList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labShowTotal;
        private System.Windows.Forms.Label list;
    }
}