namespace MV04
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OriginBox = new System.Windows.Forms.PictureBox();
            this.BinaryBox = new System.Windows.Forms.PictureBox();
            this.ScrollBar = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OriginBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinaryBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Oirginal Lena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Binary Lena";
            // 
            // OriginBox
            // 
            this.OriginBox.BackColor = System.Drawing.SystemColors.Control;
            this.OriginBox.Location = new System.Drawing.Point(35, 55);
            this.OriginBox.Name = "OriginBox";
            this.OriginBox.Size = new System.Drawing.Size(245, 341);
            this.OriginBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OriginBox.TabIndex = 7;
            this.OriginBox.TabStop = false;
            // 
            // BinaryBox
            // 
            this.BinaryBox.Location = new System.Drawing.Point(378, 55);
            this.BinaryBox.Name = "BinaryBox";
            this.BinaryBox.Size = new System.Drawing.Size(245, 341);
            this.BinaryBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BinaryBox.TabIndex = 8;
            this.BinaryBox.TabStop = false;
            // 
            // ScrollBar
            // 
            this.ScrollBar.Location = new System.Drawing.Point(378, 420);
            this.ScrollBar.Maximum = 255;
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.Size = new System.Drawing.Size(245, 21);
            this.ScrollBar.TabIndex = 9;
            this.ScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Threshold value";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(485, 404);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(14, 16);
            this.lb.TabIndex = 11;
            this.lb.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ScrollBar);
            this.Controls.Add(this.BinaryBox);
            this.Controls.Add(this.OriginBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chuyen hinh anh tu RGB sang binary";
            ((System.ComponentModel.ISupportInitialize)(this.OriginBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BinaryBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox OriginBox;
        private System.Windows.Forms.PictureBox BinaryBox;
        private System.Windows.Forms.HScrollBar ScrollBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb;
    }
}

