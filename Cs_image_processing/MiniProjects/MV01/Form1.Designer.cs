namespace MV01
{
    partial class Pictures
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
            this.components = new System.ComponentModel.Container();
            this.OrginIB = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GreenIB = new Emgu.CV.UI.ImageBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RedIB = new Emgu.CV.UI.ImageBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BlueIB = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrginIB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenIB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedIB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueIB)).BeginInit();
            this.SuspendLayout();
            // 
            // OrginIB
            // 
            this.OrginIB.Location = new System.Drawing.Point(92, 46);
            this.OrginIB.Name = "OrginIB";
            this.OrginIB.Size = new System.Drawing.Size(360, 360);
            this.OrginIB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OrginIB.TabIndex = 2;
            this.OrginIB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original Lena";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Green Lena";
            // 
            // GreenIB
            // 
            this.GreenIB.Location = new System.Drawing.Point(515, 46);
            this.GreenIB.Name = "GreenIB";
            this.GreenIB.Size = new System.Drawing.Size(360, 360);
            this.GreenIB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GreenIB.TabIndex = 4;
            this.GreenIB.TabStop = false;
            this.GreenIB.Click += new System.EventHandler(this.GreenIB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Red lena";
            // 
            // RedIB
            // 
            this.RedIB.Location = new System.Drawing.Point(92, 455);
            this.RedIB.Name = "RedIB";
            this.RedIB.Size = new System.Drawing.Size(360, 360);
            this.RedIB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedIB.TabIndex = 6;
            this.RedIB.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Blue Lena";
            // 
            // BlueIB
            // 
            this.BlueIB.Location = new System.Drawing.Point(515, 455);
            this.BlueIB.Name = "BlueIB";
            this.BlueIB.Size = new System.Drawing.Size(360, 360);
            this.BlueIB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BlueIB.TabIndex = 8;
            this.BlueIB.TabStop = false;
            // 
            // Pictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 856);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BlueIB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RedIB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GreenIB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrginIB);
            this.Name = "Pictures";
            this.Text = "Pictures";
            ((System.ComponentModel.ISupportInitialize)(this.OrginIB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenIB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedIB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueIB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox OrginIB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Emgu.CV.UI.ImageBox GreenIB;
        private System.Windows.Forms.Label label3;
        private Emgu.CV.UI.ImageBox RedIB;
        private System.Windows.Forms.Label label4;
        private Emgu.CV.UI.ImageBox BlueIB;
    }
}

