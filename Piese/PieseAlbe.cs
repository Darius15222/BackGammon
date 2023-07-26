using System.Drawing;

namespace BackGammonProject
{
    public class PieseAlbe : Piese
    {
        private int sensPieseAlbe = 1;
        private Bitmap imaginePiesaAlba = Properties.Resources.whitePiece;

        public override Bitmap ImaginePiesa()
        {
            return imaginePiesaAlba;
        }
        public override int Sens()
        {
            return sensPieseAlbe;
        }
    }
}
