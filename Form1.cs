using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            using (OpenFileDialog dlg = new OpenFileDialog()) {

                dlg.Title = "Open Image";
                dlg.Filter = "bmp files (*.bmp)|*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK) {

                    pictureBox2.Image = new Bitmap(dlg.FileName);
                }
            }

        }
    }
}
