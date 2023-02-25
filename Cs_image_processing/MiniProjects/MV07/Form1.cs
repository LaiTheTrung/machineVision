using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MV07
{
    public partial class Form1 : Form
    {
        Bitmap Originmap = new Bitmap(@"D:\MucHocTap\Cs_image_processing\lena.png"); // Load Image to Bitmap ( map of pixel)
        public Form1()
        {
            InitializeComponent();
            
            picBoxOrigin.Image= Originmap;

  
        }
        public List<Bitmap> HSIConvertor(Bitmap Origin)
        {
            // create a list to contain the converted image 
            List<Bitmap> HSI = new List<Bitmap>();

            // create blank Bitmap for Hue - Saturation - Intensity channel and HSI image
            Bitmap Hue = new Bitmap(Origin.Width, Origin.Height);
            Bitmap Saturation = new Bitmap(Origin.Width, Origin.Height);
            Bitmap Intensity = new Bitmap(Origin.Width, Origin.Height);
            Bitmap HSIImg = new Bitmap(Origin.Width, Origin.Height);

            for (int x = 0; x < Origin.Width; x++)
            {
                for (int y = 0; y < Origin.Height; y++)
                {
                    Color pixel = Origin.GetPixel(x, y); // (A,R,G,B) 

                    double R = pixel.R; //red                                    
                    double G = pixel.G; // green
                    double B = pixel.B; // blue
  

                    double t1 = 0.5 * ((R - G) + (R - B));
                    double t2 = Math.Sqrt((R - G) * (R - G) + (R - B) * (G - B));
                    double theta = Math.Acos(t1 / t2); 
                    theta= theta * 180 / Math.PI; // convert from radian to degree
                    byte H;
                    if (B > G) H = (byte)(360 - theta);
                    else H = (byte)(theta);
                    
                    double S = 1 - 3/(R+G+B) * Math.Min(R,Math.Min(G,B)); 
                    double I = (R + G + B) / 3;

                    // Display the calculated pixel to H-S-I channel and HSI image
                    Hue.SetPixel(x,y,Color.FromArgb(H,H,H));
                    Saturation.SetPixel(x, y, Color.FromArgb((byte)(S*255), (byte)(S*255), (byte)(S*255))); // normalize by multibly by 255
                    Intensity.SetPixel(x, y, Color.FromArgb((byte)I, (byte)I, (byte)I));

                    HSIImg.SetPixel(x,y,Color.FromArgb((byte)H,(byte)(S*255), (byte)I));
                }            
            }
            HSI.Add(Hue);
            HSI.Add(Saturation);
            HSI.Add(Intensity);
            HSI.Add(HSIImg);

            return HSI;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            List<Bitmap> HSI = HSIConvertor(Originmap);

            picBoxHue.Image = HSI[0];
            picBoxSat.Image = HSI[1];
            picBoxIntens.Image = HSI[2];
            picBoxHsl.Image = HSI[3];
        }
    }
}
