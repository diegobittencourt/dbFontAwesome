using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbFontAwesome.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FontAwesome fa = new FontAwesome();
            this.pictureBox1.Image = fa.getIcon(IconType.Bomb, 100, 100, Color.Black);
        }
    }
}
