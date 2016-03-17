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

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            Bitmap imagen_bmp = new Bitmap("C:/Users/Familia/Documents/Visual Studio 2012/Projects/C#/IMG_IIC_2016/IMG_IIC_2016/gata1.bmp");
            e.Graphics.DrawImage(imagen_bmp, 60, 10);
        }

    }
}
