using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Accounting_Client_
{
    public partial class ImageContentForm : Form
    {
        public ImageContentForm(PictureBox image)
        {
            InitializeComponent();
            pictureBox1.Image = image.Image;
        }
    }
}