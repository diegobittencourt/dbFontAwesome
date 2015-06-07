using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;

namespace dbFontAwesome.Test
{
    public partial class PictureBoxFontAwesome : PictureBox
    {

        IconType _IconImage;

        [Browsable(true)]
        [DisplayName("Icon Type")]
        [Description("Select your IconType from Font Awesome")]
        [Category("Font Awesome")]
        [Editor(typeof(IconTypeEditor), typeof(UITypeEditor))]
        public IconType IconImage
        {
            get
            {
                return _IconImage;
            }
            set
            {
                _IconImage = value;
                UpdateIcon();
            }
        }

        public PictureBoxFontAwesome()
        {
            InitializeComponent();
            this._IconImage = IconType.Search;
            Update();
        }


        private void UpdateIcon()
        {
            FontAwesome _FontAwesome = new FontAwesome();
            Bitmap _Image = _FontAwesome.getIcon(this._IconImage, 128, 128, Color.Black);
            this.Image = _Image;
        }

    }
}
