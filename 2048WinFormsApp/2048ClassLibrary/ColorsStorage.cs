using System.Drawing;

namespace _2048ClassLibrary
{
    public static class ColorsStorage
    {
        private static readonly List<Color> _colors;
        static ColorsStorage()
        {
            _colors = new List<Color>()
            {
                Color.FromArgb(238, 228, 218),
                Color.FromArgb(237, 224, 200),
                Color.FromArgb(242, 177, 121),
                Color.FromArgb(245, 149, 99),
                Color.FromArgb(246, 124, 95),
                Color.FromArgb(246, 94, 59),
                Color.FromArgb(237, 70, 55),
                Color.FromArgb(234, 67, 53),
                Color.FromArgb(224, 52, 42),
                Color.FromArgb(214, 42, 32),
                Color.FromArgb(204, 32, 22),
                Color.FromArgb(180, 20, 15)
            };
        }
        public static List<Color> GetAll()
        {
            return _colors;
        }
        public static Color GetCellColor(int number)
        {
            switch (number)
            {
                case 2: return _colors[0];
                case 4: return _colors[1];
                case 8: return _colors[2];
                case 16: return _colors[3];
                case 32: return _colors[4];
                case 64: return _colors[5];
                case 128: return _colors[6];
                case 256: return _colors[7];
                case 512: return _colors[8];
                case 1024: return _colors[9];
                case 2048: return _colors[10];
                default: return _colors[11];
            }
        }
    }
}
