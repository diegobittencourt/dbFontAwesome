using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbFontAwesome
{
    public class IconTypeEditor : UITypeEditor
    {

        #region Public  Methods

        /// <summary>
        /// Indicates Paint Image True
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        /// <summary>
        /// Paint Image
        /// </summary>
        /// <param name="e"></param>
        public override void PaintValue(PaintValueEventArgs e)
        {
            FontAwesome fa = new FontAwesome();
            IconType it = (IconType)Enum.Parse(typeof(IconType), e.Value.ToString());
            Bitmap bmp = fa.getIcon(it, e.Bounds.Width, e.Bounds.Height, Color.Black);
            Rectangle destRect = e.Bounds;
            e.Graphics.DrawImage(bmp, destRect);
        }

        #endregion

    }
}
