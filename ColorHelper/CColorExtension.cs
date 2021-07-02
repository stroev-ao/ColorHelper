using System.Drawing;

namespace ColorHelper
{
    public static class CColorExtension
    {
        public static string GetText(this Color color)
        {
            return string.Format("{0}, {1}, {2}", color.R, color.G, color.B);
        }
    }
}
