
namespace _18_游曉雯_HomeWork
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_wine = new System.Windows.Forms.Button();
            this.btn_whisky = new System.Windows.Forms.Button();
            this.btn_tequila = new System.Windows.Forms.Button();
            this.btn_beer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Total = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_wine);
            this.groupBox1.Controls.Add(this.btn_whisky);
            this.groupBox1.Controls.Add(this.btn_tequila);
            this.groupBox1.Controls.Add(this.btn_beer);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜單Menu";
            // 
            // btn_wine
            // 
            this.btn_wine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_wine.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_wine.ForeColor = System.Drawing.Color.White;
            this.btn_wine.Image = ((System.Drawing.Image)(resources.GetObject("btn_wine.Image")));
            this.btn_wine.Location = new System.Drawing.Point(184, 296);
            this.btn_wine.Margin = new System.Windows.Forms.Padding(50);
            this.btn_wine.Name = "btn_wine";
            this.btn_wine.Size = new System.Drawing.Size(157, 198);
            this.btn_wine.TabIndex = 3;
            this.btn_wine.Text = "紅酒 NT$ 320";
            this.btn_wine.UseVisualStyleBackColor = true;
            // 
            // btn_whisky
            // 
            this.btn_whisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_whisky.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_whisky.ForeColor = System.Drawing.Color.Red;
            this.btn_whisky.Image = ((System.Drawing.Image)(resources.GetObject("btn_whisky.Image")));
            this.btn_whisky.Location = new System.Drawing.Point(11, 296);
            this.btn_whisky.Margin = new System.Windows.Forms.Padding(50);
            this.btn_whisky.Name = "btn_whisky";
            this.btn_whisky.Size = new System.Drawing.Size(157, 198);
            this.btn_whisky.TabIndex = 2;
            this.btn_whisky.Text = "威士忌 NT$ 350";
            this.btn_whisky.UseVisualStyleBackColor = true;
            // 
            // btn_tequila
            // 
            this.btn_tequila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_tequila.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_tequila.ForeColor = System.Drawing.Color.Black;
            this.btn_tequila.Image = ((System.Drawing.Image)(resources.GetObject("btn_tequila.Image")));
            this.btn_tequila.Location = new System.Drawing.Point(184, 47);
            this.btn_tequila.Margin = new System.Windows.Forms.Padding(50);
            this.btn_tequila.Name = "btn_tequila";
            this.btn_tequila.Size = new System.Drawing.Size(161, 198);
            this.btn_tequila.TabIndex = 1;
            this.btn_tequila.Text = "龍舌蘭 NT$ 180";
            this.btn_tequila.UseVisualStyleBackColor = true;
            this.btn_tequila.Click += new System.EventHandler(this.btn_tequila_Click);
            // 
            // btn_beer
            // 
            this.btn_beer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_beer.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_beer.ForeColor = System.Drawing.Color.Yellow;
            this.btn_beer.Image = ((System.Drawing.Image)(resources.GetObject("btn_beer.Image")));
            this.btn_beer.Location = new System.Drawing.Point(11, 47);
            this.btn_beer.Margin = new System.Windows.Forms.Padding(50);
            this.btn_beer.Name = "btn_beer";
            this.btn_beer.Size = new System.Drawing.Size(157, 198);
            this.btn_beer.TabIndex = 0;
            this.btn_beer.Text = "啤酒 NT$ 120";
            this.btn_beer.UseVisualStyleBackColor = true;
            this.btn_beer.Click += new System.EventHandler(this.btn_beer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Total);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(400, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "總金額Total Price";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.BackColor = System.Drawing.Color.Black;
            this.Total.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Total.ForeColor = System.Drawing.Color.White;
            this.Total.Location = new System.Drawing.Point(126, 47);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(103, 36);
            this.Total.TabIndex = 4;
            this.Total.Text = "NT$ 0";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(339, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(304, 433);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "付款方式";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(400, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 214);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "付款方式";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(64, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "使用信用卡享9折!!";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(132, 49);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 96);
            this.button6.TabIndex = 1;
            this.button6.Text = "信用卡";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(6, 49);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 96);
            this.button5.TabIndex = 0;
            this.button5.Text = "現金";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.button7);
            this.groupBox5.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox5.Location = new System.Drawing.Point(706, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(417, 505);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "購物清單";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.Location = new System.Drawing.Point(22, 394);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 39);
            this.button7.TabIndex = 1;
            this.button7.Text = "清除清單";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(17, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(384, 341);
            this.label5.TabIndex = 2;
            this.label5.Text = "label5";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 563);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_tequila;
        private System.Windows.Forms.Button btn_beer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_whisky;
        private System.Windows.Forms.Button btn_wine;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}