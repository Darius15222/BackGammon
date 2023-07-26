using BackGammonProject.Properties;
using System;
using System.Windows.Forms;

namespace BackGammonProject
{
    public class Zar
    {
        private int value;
        private bool eDubla;
        private bool aMutat_Privat = true;

        public bool aMutat {
            get 
            {
                return aMutat_Privat;
            }

            set
            {
                if(value == true)
                {
                    if (eDubla == true)
                    {
                        eDubla = false;
                    }
                    else
                    { 
                        aMutat_Privat = true; 
                    }
                }
                else 
                {
                    aMutat_Privat = false;
                }
            }
        }
        public int getValue()
        {
            return value;
        }
        public bool getEDubla()
        {
            return eDubla;
        }
        public void setEDubla(bool d)
        {
            eDubla = d;
        }

        public Zar()
        {
            value = 0;
            eDubla= false;
        }

        public void Roll()
        {
            value = new Random().Next(1, 7);
        }
        public void ShowImage(PictureBox diePicture, int valoare)
        {
            switch (valoare)
            {
                case 1:
                    {
                        diePicture.Image = Resources.Die1;
                        break;
                    }
                case 2:
                    {
                        diePicture.Image = Resources.Die2;
                        break;
                    }
                case 3:
                    {
                        diePicture.Image = Resources.Die3;
                        break;
                    }
                case 4:
                    {
                        diePicture.Image = Resources.Die4;
                        break;
                    }
                case 5:
                    {
                        diePicture.Image = Resources.Die5;
                        break;
                    }

                case 6:
                    {
                        diePicture.Image = Resources.Die6;
                        break;
                    }
            }
        }
    }
}