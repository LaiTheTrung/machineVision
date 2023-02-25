using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace MV01
{
    public partial class Pictures : Form
    {
        public Pictures()
        {
            InitializeComponent();
            string filename = @"D:\MucHocTap\Cs_image_processing\lena.png"; // @ to ensure UNICODE string
            Bitmap Originmap = new Bitmap(filename); // Load Image to Bitmap ( map of pixel)
            // split to R,G,B
            Bitmap Redmap = new Bitmap(Originmap.Width, Originmap.Height);
            Bitmap Greenmap = new Bitmap(Originmap.Width, Originmap.Height);
            Bitmap Bluemap = new Bitmap(Originmap.Width, Originmap.Height);

            for(int x =0; x < Originmap.Width; x++)
            {
                for(int y = 0 ; y<Originmap.Height; y++)
                {
                    Color pixel = Originmap.GetPixel(x, y); // (A,R,G,B) 

                    byte R = pixel.R;
                    byte G = pixel.G;
                    byte B = pixel.B;
                    byte A = pixel.A;

                    Redmap.SetPixel(x,y,Color.FromArgb(A,R,0,0));
                    Greenmap.SetPixel(x,y,Color.FromArgb(A,0,G,0));
                    Bluemap.SetPixel(x,y,Color.FromArgb(A,0,0,B));

                }
            }
            // Display Origin Image
            Image <Rgb, Byte> originImage = new Image<Rgb, byte>(Originmap);
            Image <Rgb, Byte> redImage = new Image<Rgb, byte>(Redmap);
            Image<Rgb, Byte> greenImage = new Image<Rgb, byte>(Greenmap);
            Image<Rgb, Byte> blueImage = new Image<Rgb, byte>(Bluemap);

     

            OrginIB.Image = originImage;
            RedIB.Image = redImage; GreenIB.Image = greenImage; BlueIB.Image = blueImage;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void GreenIB_Click(object sender, EventArgs e)
        {

        }
    }
}
