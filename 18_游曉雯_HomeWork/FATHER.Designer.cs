
namespace _18_游曉雯_HomeWork
{
    partial class FATHER
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
            this.labMOMO = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labMOMO
            // 
            this.labMOMO.AutoSize = true;
            this.labMOMO.Location = new System.Drawing.Point(206, 99);
            this.labMOMO.Name = "labMOMO";
            this.labMOMO.Size = new System.Drawing.Size(50, 18);
            this.labMOMO.TabIndex = 0;
            this.labMOMO.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FATHER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labMOMO);
            this.Name = "FATHER";
            this.Text = "FATHER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labMOMO;
        public System.Windows.Forms.Button button1;
    }
}