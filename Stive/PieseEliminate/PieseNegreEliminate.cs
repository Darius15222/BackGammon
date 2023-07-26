using System.Collections.Generic;
using System.Windows.Forms;

namespace BackGammonProject
{
    public class PieseNegreEliminate
    {
        private Stack<PieseNegre> pieseNegreEliminate;
        private bool negruPoateElimina;
        
        public PieseNegreEliminate()
        {
            pieseNegreEliminate = new Stack<PieseNegre>();
            negruPoateElimina = false;
        }
        
        public Stack<PieseNegre> getPieseNegreEliminate()
        {
            return pieseNegreEliminate;
        }
        public int NrPieseNegreEliminate()
        {
            return pieseNegreEliminate.Count;
        }
        public bool getNegruPoateElimina()
        {
            return negruPoateElimina;
        }
        public void setNegruPoateElimina(bool b)
        {
            negruPoateElimina = b;
        }
        public bool NegruCastiga()
        {
            if (pieseNegreEliminate.Count == 15 && negruPoateElimina == true)
            {
                MessageBox.Show("NEGRU A CASTIGAT!!!");
                return true;
            }
            return false;
        }
    }
}
