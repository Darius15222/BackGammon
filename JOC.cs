using System.Collections.Generic;

namespace BackGammonProject
{
    public class JOC
    {
        private Zar zar1 = new Zar();
        private Zar zar2 = new Zar();
        
        private Coloane coloane;
        private PieseAlbeScoase pieseAlbeScoase;
        private PieseNegreScoase pieseNegreScoase;
        private PieseAlbeEliminate pieseAlbeEliminate;
        private PieseNegreEliminate pieseNegreEliminate;
        private Stari stare;

        public Stack<PieseAlbe> getPieseAlbeScoase()
        {
            return pieseAlbeScoase.getPieseAlbeScoase();
        }
        public Stack<PieseNegre> getPieseNegreScoase()
        {
            return pieseNegreScoase.getPieseNegreScoase();
        }
        public Stack<PieseAlbe> getPieseAlbeEliminate()
        {
            return pieseAlbeEliminate.getPieseAlbeEliminate();
        }
        public Stack<PieseNegre> getPieseNegreEliminate()
        {
            return pieseNegreEliminate.getPieseNegreEliminate();
        }

        public int getNrPieseAlbeScoase()
        {
            return pieseAlbeScoase.NrPieseAlbeScoase();
        }
        public int getNrPieseNegreScoase()
        {
            return pieseNegreScoase.NrPieseNegreScoase();
        }
        public int getNrPieseAlbeEliminate()
        {
            return pieseAlbeEliminate.NrPieseAlbeEliminate();
        }
        public int getNrPieseNegreEliminate()
        {
            return pieseNegreEliminate.NrPieseNegreEliminate();
        }

        private int rand;
        private int iAnterior;

        public JOC()
        {
            zar1 = new Zar();
            zar2 = new Zar();

            stare = Stari.coloanaNeselectata;
            rand = 1;

            coloane = new Coloane();

            pieseAlbeScoase = new PieseAlbeScoase();
            pieseNegreScoase = new PieseNegreScoase();

            pieseAlbeEliminate = new PieseAlbeEliminate();
            pieseNegreEliminate = new PieseNegreEliminate();
        }

        public Zar getZar1()
        {
            return zar1;
        }
        public Zar getZar2()
        {
            return zar2;
        }
        public Coloane getColoana()
        {
            return coloane;
        }
        public List<Stack<Piese>> getColoane()
        {
            return coloane.getColoane();
        }
        public Stari getStare() 
        { 
            return stare; 
        }
        public void setStare(Stari s)
        {
            stare = s;
        }
        public int getRand()
        {
            return rand;
        }
        public int getIAnterior()
        {
            return iAnterior;
        }
        public void setIAnterior(int i)
        {
            iAnterior = i;
        }
        public bool getAlbPoateElimina()
        {
            return pieseAlbeEliminate.getAlbPoateElimina();
        }
        public void setAlbPoateElimina(bool b)
        {
            pieseAlbeEliminate.setAlbPoateElimina(b);
        }
        public bool getNegruPoateElimina()
        {
            return pieseNegreEliminate.getNegruPoateElimina();
        }
        public void setNegruPoateElimina(bool b)
        {
            pieseNegreEliminate.setNegruPoateElimina(b);
        }
        
        public bool getAlbCastiga()
        {
            return pieseAlbeEliminate.AlbCastiga();
        }
        public bool getNegruCastiga()
        {
            return pieseNegreEliminate.NegruCastiga();
        }
        

        
        public void NextRand()
        {
            rand = (rand + 1) % 2;
        }
        public bool ToatePieseleAlbeInCasa()
        {
            int ct = 0;

            for (int i = 18; i < 24; i++)
            {
                if (coloane.TipPiesaDePeColoana(i) == typeof(PieseAlbe))
                    ct += coloane.getColoane()[i].Count;
            }

            if (ct == 15)
            {
                return true;
            }
            return false;
        }
        public bool ToatePieseleNegreInCasa()
        {
            int ct = 0;

            for (int i = 0; i < 6; i++)
            {
                if (coloane.TipPiesaDePeColoana(i) == typeof(PieseNegre))
                    ct += coloane.getColoane()[i].Count;
            }

            if (ct == 15)
            {
                return true;
            }
            return false;
        }
        public bool RepunePiesaNeagra(Zar zar)
        {
            if (zar.aMutat == true)
                return false;
            if (coloane.TipPiesaDePeColoana(24 - zar.getValue()) == typeof(PieseNegre))
                return true;
            if (coloane.TipPiesaDePeColoana(24 - zar.getValue()) == typeof(PieseAlbe) && coloane.getColoane()[24 - zar.getValue()].Count == 1)
                return true;
            if (coloane.TipPiesaDePeColoana(24 - zar.getValue()) == null)
                return true;
            return false;
        }
        public bool RepunePiesaAlba(Zar zar)
        {
            if (zar.aMutat == true)
                return false;
            if (coloane.TipPiesaDePeColoana(-1 + zar.getValue()) == typeof(PieseAlbe))
                return true;
            if (coloane.TipPiesaDePeColoana(-1 + zar.getValue()) == typeof(PieseNegre) && coloane.getColoane()[-1 + zar.getValue()].Count == 1)
                return true;
            if (coloane.TipPiesaDePeColoana(-1 + zar.getValue()) == null)
                return true;
            return false;
        }
        public bool IndiciValiziZaruri(int iActual, Zar zar)
        {
            return (zar.aMutat == false && (iActual + (zar.getValue() * coloane.getColoane()[iActual].Peek().Sens())) < 24 && (iActual + (zar.getValue() * coloane.getColoane()[iActual].Peek().Sens())) >= 0);
        }
        public bool ZaruriEgale(Zar zar1, Zar zar2)
        {
            return zar1.getValue() == zar2.getValue();
        }
        public bool ColoanaPlayerCurent(int i)
        {
            if (rand == 0 && coloane.getColoane()[i].Peek().GetType() == typeof(PieseAlbe))
            {
                return true;
            }
            if (rand == 1 && coloane.getColoane()[i].Peek().GetType() == typeof(PieseNegre))
            {
                return true;
            }
            return false;
        }
    }
}
