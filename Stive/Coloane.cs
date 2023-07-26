using System;
using System.Collections.Generic;

namespace BackGammonProject
{
    public class Coloane
    {
        private List<Stack<Piese>> coloane;
        public Coloane()
        {
            coloane = new List<Stack<Piese>>();
        }
        public List<Stack<Piese>> getColoane()
        {
            return coloane;
        }
        public Type TipPiesaDePeColoana(int i)
        {
            if (coloane[i].Count > 0)
                return coloane[i].Peek().GetType();
            return null;
        }
    }
}
