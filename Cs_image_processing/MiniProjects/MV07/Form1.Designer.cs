namespace MV07
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
            this.picBoxOrigin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBoxHue = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picBoxSat = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picBoxIntens = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picBoxHsl = new System.Windows.Forms.PictureBox();
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIntens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHsl)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxOrigin
            // 
            this.picBoxOrigin.Location = new System.Drawing.Point(54, 46);
            this.picBoxOrigin.Name = "picBoxOrigin";
            this.picBoxOrigin.Size = new System.Drawing.Size(256, 256);
            this.picBoxOrigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxOrigin.TabIndex = 0;
            this.picBoxOrigin.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original Lena";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "HUE channel";
            // 
            // picBoxHue
            // 
            this.picBoxHue.Location = new System.Drawing.Point(54, 332);
            this.picBoxHue.Name = "picBoxHue";
            this.picBoxHue.Size = new System.Drawing.Size(256, 256);
            this.picBoxHue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHue.TabIndex = 2;
            this.picBoxHue.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "SATURATION channel";
            // 
            // picBoxSat
            // 
            this.picBoxSat.Location = new System.Drawing.Point(334, 332);
            this.picBoxSat.Name = "picBoxSat";
            this.picBoxSat.Size = new System.Drawing.Size(256, 256);
            this.picBoxSat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSat.TabIndex = 4;
            this.picBoxSat.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "INTENSITIVE channel";
            // 
            // picBoxIntens
            // 
            this.picBoxIntens.Location = new System.Drawing.Point(608, 332);
            this.picBoxIntens.Name = "picBoxIntens";
            this.picBoxIntens.Size = new System.Drawing.Size(256, 256);
            this.picBoxIntens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxIntens.TabIndex = 6;
            this.picBoxIntens.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(881, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "HSL channel";
            // 
            // picBoxHsl
            // 
            this.picBoxHsl.Location = new System.Drawing.Point(884, 332);
            this.picBoxHsl.Name = "picBoxHsl";
            this.picBoxHsl.Size = new System.Drawing.Size(256, 256);
            this.picBoxHsl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHsl.TabIndex = 8;
            this.picBoxHsl.TabStop = false;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(681, 105);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(125, 63);
            this.button.TabIndex = 10;
            this.button.Text = "RGB to HSI";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picBoxHsl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picBoxIntens);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBoxSat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBoxHue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxOrigin);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIntens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHsl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxOrigin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBoxHue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBoxSat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picBoxIntens;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picBoxHsl;
        private System.Windows.Forms.Button button;
    }
}

