using System.Drawing;

namespace BackGammonProject
{
    public class PieseNegre : Piese
    {
        private int sensPieseNegre = -1;
        private Bitmap imaginePiesaNeagra = Properties.Resources.blackPiece;

        public override Bitmap ImaginePiesa()
        {
            return imaginePiesaNeagra;
        }
        public override int Sens()
        {
            return sensPieseNegre;
        }
    }
}
