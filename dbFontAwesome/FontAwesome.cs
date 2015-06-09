using System;
using System.Drawing.Text;
using dbFontAwesome.Properties;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace dbFontAwesome
{
    public class FontAwesome
    {

        #region Private Attributes

        /// <summary>
        /// Store the icon font in a static variable to reuse between icons
        /// </summary>
        private static readonly PrivateFontCollection Fonts = new PrivateFontCollection();

        #endregion

        #region Constructor

        /// <summary>
        /// Construtor
        /// </summary>
        public FontAwesome()
        {
            if(Fonts.Families.Length == 0)
            {
                ImportFont();
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Create Icon
        /// </summary>
        /// <param name="Icon"></param>
        /// <param name="sSize"></param>
        /// <param name="IconColor"></param>
        /// <returns></returns>
        public Bitmap getIcon(IconType Icon, Size sSize, Color IconColor)
        {
            Bitmap auxReturn = new Bitmap(sSize.Width, sSize.Height);
            // Create Graphics Object
            Graphics g = Graphics.FromImage(auxReturn);
            // Set best quality
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            // Set IconChar
            string auxIconChar = char.ConvertFromUtf32((int)Icon);
            // Get Icon Font
            Font auxIconFont = GetIconFont(g, auxIconChar, sSize, true);
            // Measure string so that we can center the icon.
            SizeF stringSize = g.MeasureString(auxIconChar, auxIconFont, sSize.Width);
            float w = stringSize.Width;
            float h = stringSize.Height;
            // center icon
            float left = (sSize.Width - w) / 2;
            float top = (sSize.Height - h) / 2;
            Brush auxIconBrush = new SolidBrush(IconColor);
            g.DrawString(auxIconChar, auxIconFont, auxIconBrush, new PointF(left, top));
            return auxReturn;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Returns a new font that fits the specified character into the allocated space.
        /// </summary>
        /// <param name="g">The graphics object.</param>
        /// <param name="graphicString">The string (icon character) to render as a graphic.</param>
        /// <param name="sSize">Width and Height of the container.</param>
        /// <param name="smallestOnFail">if set to <c>true</c> [smallest on fail].</param>
        /// <returns></returns>
        private Font GetIconFont(Graphics g, string graphicString, Size sSize, bool smallestOnFail)
        {
            float auxMinFontSize = 4.0f;
            float auxMaxFontSize = sSize.Width;
            if (sSize.Height > auxMaxFontSize)
            {
                auxMaxFontSize = sSize.Height;
            }
            for (double adjustedSize = auxMaxFontSize; adjustedSize >= 4; adjustedSize = adjustedSize - 0.5)
            {
                Font auxReturn = GetIconFont((float)adjustedSize);
                // Test the string with the new size
                SizeF adjustedSizeNew = g.MeasureString(graphicString, auxReturn);
                if (sSize.Width > Convert.ToInt32(adjustedSizeNew.Width) && sSize.Height > Convert.ToInt32(adjustedSizeNew.Height))
                {
                    return auxReturn;
                }
            }
            // Could not find a font size
            // return min or max or maxFontSize?
            return GetIconFont(smallestOnFail ? auxMinFontSize : auxMaxFontSize);
        }

        ///// <summary>
        ///// Returns a font instance using the resource icon font.
        ///// </summary>
        ///// <param name="Size">The size of the font in points.</param>
        ///// <returns>A new System.Drawing.Font instance</returns>
        private Font GetIconFont(float Size)
        {
            return new Font(Fonts.Families[0], Size, GraphicsUnit.Pixel);
        }

        /// <summary>
        /// Import FontAwesome to the system
        /// </summary>
        private void ImportFont()
        {
            unsafe
            {
                fixed (byte* pFontData = Resources.fontawesome_webfont)
                {
                    Fonts.AddMemoryFont((IntPtr)pFontData, Resources.fontawesome_webfont.Length);
                }
            }
        }

        #endregion

    }
}
