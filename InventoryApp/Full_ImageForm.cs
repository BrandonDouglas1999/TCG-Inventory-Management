using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class Full_ImageForm : Form
    {
        public string image_path { get; set; } = @"D:\Users\hang_\Documents\School\Capstone\CardAPITest\CardAPITest\Card_Images\3410461.jpg";
        public Full_ImageForm()
        {
            InitializeComponent();
            MessageBox.Show(image_path);
            //show_image(image_path);
        }

        public void show_image (string image_path)
        {
            Bitmap image = new Bitmap(image_path);
            card_image.Image = (Image)image;
        }
    }
}
