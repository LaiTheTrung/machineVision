using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MV04
{
    public partial class Form1 : Form
    {
        byte Threshold = 0;
        Bitmap Originalmap = new Bitmap(@"D:\MucHocTap\Cs_image_processing\lena.png"); // Load Image to Bitmap ( map of pixel)
        public Form1()
        {
            InitializeComponent();
            Binary_Image_convert(Originalmap);
            
            // split to R,G,B

        }
        private void Binary_Image_convert(Bitmap Originmap)
        {
            Bitmap Binary = new Bitmap(Originmap.Width, Originmap.Height);


            for (int x = 0; x < Originmap.Width; x++)
            {
                for (int y = 0; y < Originmap.Height; y++)
                {
                    Color pixel = Originmap.GetPixel(x, y); // (A,R,G,B) 

                    byte R = pixel.R; //red                                    
                    byte G = pixel.G; // green
                    byte B = pixel.B; // blue
                    byte A = pixel.A; 
                    byte Gray = (byte)(0.2126 * R + 0.7152 * G + 0.0722 * B);
                    if (Gray > Threshold)
                    {
                        Binary.SetPixel(x, y, Color.FromArgb(A, 255, 255, 255));
                    }
                    else
                    {
                        Binary.SetPixel(x, y, Color.FromArgb(A, 0, 0, 0));
                    }

                }
            }
            OriginBox.Image = Originmap;
            BinaryBox.Image = Binary;
        }
        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Threshold = (byte)ScrollBar.Value;// value of scrollbar is int
            lb.Text = Threshold.ToString();
            Binary_Image_convert(Originalmap);
        }
    }
}
