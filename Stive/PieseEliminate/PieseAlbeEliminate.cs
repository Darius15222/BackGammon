using System.Collections.Generic;
using System.Windows.Forms;

namespace BackGammonProject
{
    public class PieseAlbeEliminate
    {
        private Stack<PieseAlbe> pieseAlbeEliminate;
        private bool albPoateElimina;
        
        public PieseAlbeEliminate()
        {
            pieseAlbeEliminate = new Stack<PieseAlbe>();
            albPoateElimina = false;
        }

        public Stack<PieseAlbe> getPieseAlbeEliminate()
        {
            return pieseAlbeEliminate;
        }
        public int NrPieseAlbeEliminate()
        {
            return pieseAlbeEliminate.Count;
        }
        public bool getAlbPoateElimina()
        {
            return albPoateElimina;
        }
        public void setAlbPoateElimina(bool b)
        {
            albPoateElimina = b;
        }
        public bool AlbCastiga()
        {
            if (NrPieseAlbeEliminate() == 15 && albPoateElimina == true)
            {
                MessageBox.Show("ALB A CASTIGAT!!!");
                return true;
            }
            return false;
        }
    }
}
