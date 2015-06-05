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
        /// <param name="S"></param>
        /// <returns></returns>
        public Bitmap getIcon(IconType Icon, int Width, int Height, Color IconColor)
        {
            Bitmap auxReturn = new Bitmap(Width, Height);
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
            Font auxIconFont = GetIconFont(g, auxIconChar, Width, Height, 4, true);
            // Measure string so that we can center the icon.
            SizeF stringSize = g.MeasureString(auxIconChar, auxIconFont, Width);
            float w = stringSize.Width;
            float h = stringSize.Height;
            // center icon
            float left = (Width - w) / 2;
            float top = (Height - h) / 2;
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
        /// <param name="containerWidth">Width of the container.</param>
        /// <param name="maxFontSize">Size of the max font.</param>
        /// <param name="minFontSize">Size of the min font.</param>
        /// <param name="smallestOnFail">if set to <c>true</c> [smallest on fail].</param>
        /// <returns></returns>
        private Font GetIconFont(Graphics g, string graphicString, int containerWidth, int maxFontSize, int minFontSize, bool smallestOnFail)
        {
            for (double adjustedSize = maxFontSize; adjustedSize >= minFontSize; adjustedSize = adjustedSize - 0.5)
            {
                Font testFont = GetIconFont((float)adjustedSize);
                // Test the string with the new size
                SizeF adjustedSizeNew = g.MeasureString(graphicString, testFont);
                if (containerWidth > Convert.ToInt32(adjustedSizeNew.Width))
                {
                    // Fits! return it
                    return testFont;
                }
            }
            // Could not find a font size
            // return min or max or maxFontSize?
            return GetIconFont(smallestOnFail ? minFontSize : maxFontSize);
        }

        ///// <summary>
        ///// Returns a font instance using the resource icon font.
        ///// </summary>
        ///// <param name="size">The size of the font in points.</param>
        ///// <returns>A new System.Drawing.Font instance</returns>
        private Font GetIconFont(float Size)
        {
            return new Font(Fonts.Families[0], Size, GraphicsUnit.Point);
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
