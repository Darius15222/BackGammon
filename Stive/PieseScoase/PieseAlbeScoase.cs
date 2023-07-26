using System.Collections.Generic;

namespace BackGammonProject
{
    public class PieseAlbeScoase
    {
        private Stack<PieseAlbe> pieseAlbeScoase;

        public PieseAlbeScoase()
        {
            pieseAlbeScoase = new Stack<PieseAlbe>();
        }

        public Stack<PieseAlbe> getPieseAlbeScoase()
        {
            return pieseAlbeScoase;
        }
        public int NrPieseAlbeScoase()
        {
            return pieseAlbeScoase.Count;
        }
        
    }
}
