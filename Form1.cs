using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMG_IIC_2016
{
    public partial class V_Principal : Form
    {
        public V_Principal()
        {
            InitializeComponent();
        }

        private void V_Principal_Load(object sender, EventArgs e)
        {
            Bitmap imagen_bmp = new Bitmap("C:/Users/Familia/Documents/Visual Studio 2012/Projects/C#/IMG_IIC_2016/IMG_IIC_2016/gata.bmp");

            Color cuenta = imagen_bmp.GetPixel(0,0);
            int total = 0;
            int [] h_counter = new int[255];
            var list = new List<int>();
           

            
                for (int j = 0; j < imagen_bmp.Height; j++)
                {

                    for (int i = 0; i < imagen_bmp.Width; i++)
                    {
                        
                       cuenta = imagen_bmp.GetPixel( i , j);
                       total = cuenta.R + cuenta.G + cuenta.B;
                       list.Add(total);

                    }

            }
            textBox1.Text =  imagen_bmp.Width.ToString();
            textBox2.Text = imagen_bmp.Height.ToString();
            textBox3.Text = list.Count.ToString();
        }

        private void button_load_image_Click(object sender, EventArgs e)
        {
            // Abre el dialogo para abrir imagenes
            using (OpenFileDialog dlg = new OpenFileDialog()) {
                
                dlg.Title = "Open Image";
                dlg.Filter = "bmp files (*.bmp)|*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK) {

                    pictureBox2.Image = new Bitmap(dlg.FileName);

                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Bitmap imagen_bmp = new Bitmap("C:/Users/Familia/Documents/Visual Studio 2012/Projects/C#/IMG_IIC_2016/IMG_IIC_2016/gata1.bmp");
            e.Graphics.DrawImage(imagen_bmp, 60, 10);

            /*textBox1.Text = imagen_bmp.Size.ToString();
            textBox1.Text = imagen_bmp.GetPixel(0, 0).R.ToString();
            textBox2.Text = imagen_bmp.GetPixel(0, 0).G.ToString();
            textBox3.Text = imagen_bmp.GetPixel(0, 0).B.ToString();*/
            
            
        }

    }
}
