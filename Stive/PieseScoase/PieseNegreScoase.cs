using System.Collections.Generic;

namespace BackGammonProject
{
    public class PieseNegreScoase
    {
        private Stack<PieseNegre> pieseNegreScoase;

        public PieseNegreScoase()
        {        
            pieseNegreScoase = new Stack<PieseNegre>();
        }
        public Stack<PieseNegre> getPieseNegreScoase()
        {
            return pieseNegreScoase;
        }
        public int NrPieseNegreScoase()
        {
            return pieseNegreScoase.Count;
        }
        
    }
}
