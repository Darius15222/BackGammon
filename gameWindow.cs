using BackGammonProject.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BackGammonProject
{
    public partial class gameWindow : Form
    {
        Label[] indicatori = new Label[24];
        Label[] nrPiese = new Label[24];
        PictureBox[][] stiveDesenate = new PictureBox[24][];

        JOC joc = new JOC();

        public gameWindow(string s1, string s2)
        {
            InitializeComponent();
            if(s1 != "")
                player1Label.Text = s1;
            else 
                player1Label.Text = "PLAYER2(Negru)";

            if (s2 != "")
                player2Label.Text = s2;
            else
                player2Label.Text = "PLAYER1(Alb)";
        }

        //EVENTURI
        private void gameWindow_Load(object sender, EventArgs e)
        {
            joc.getZar1().aMutat = true;
            joc.getZar2().aMutat = true;

            for (int i = 0; i < 24; i++)
                stiveDesenate[i] = new PictureBox[5];

            Point coordPictureBox = new Point(0, 0);
            Point coordIndicatori = new Point(0, 0);
            Point coordNrPiese = new Point(0, 0);

            for (int i = 0; i < 24; i++)
            {
                #region InitializareLabel
                if (i < 6)
                {
                    coordIndicatori.X = 805 - (i + 1) * 61;
                    coordIndicatori.Y = 15;

                    coordNrPiese.X = coordIndicatori.X;
                    coordNrPiese.Y = coordIndicatori.Y + 280;
                }

                if (i >= 6 && i < 12)
                {
                    coordIndicatori.X = 320 - (i - 6) * 61;
                    coordIndicatori.Y = 15;

                    coordNrPiese.X = coordIndicatori.X;
                    coordNrPiese.Y = coordIndicatori.Y + 280;
                }

                if (i >= 12 && i < 18)
                {
                    coordIndicatori.X = -48 + (i + 1 - 12) * 61;
                    coordIndicatori.Y = 625;

                    coordNrPiese.X = coordIndicatori.X;
                    coordNrPiese.Y = coordIndicatori.Y - 280;
                }

                if (i >= 18 && i < 24)
                {
                    coordIndicatori.X = 375 + (i + 1 - 18) * 61;
                    coordIndicatori.Y = 625;

                    coordNrPiese.X = coordIndicatori.X;
                    coordNrPiese.Y = coordIndicatori.Y - 280;
                }

                indicatori[i] = new Label
                {
                    Location = coordIndicatori,
                    Text = "       " + (i + 1),
                    ForeColor = Color.White,
                    Name = "label" + (i + 1),
                    Size = new System.Drawing.Size(62, 15),
                    TabIndex = 5,
                    TabStop = false,
                    Parent = this,
                    BackColor = Color.Transparent,
                    AutoSize = false
                };
                nrPiese[i] = new Label
                {
                    Location = coordNrPiese,
                    Size = new System.Drawing.Size(62, 15),
                    TabIndex = 5,
                    TabStop = false,
                    Parent = this,
                    BackColor = Color.Transparent,
                    AutoSize = false
                };
                nrPiese[i].BringToFront();
                #endregion

                for (int j = 0; j < 5; j++)
                {
                    #region InitializareImaginiPiese
                    PictureBox p;
                    if (i >= 0 && i < 6)
                    {
                        coordPictureBox.X = 739 - i * 61;
                        coordPictureBox.Y = 36 + j * 51;
                    }
                    if (i >= 6 && i < 12)
                    {
                        coordPictureBox.X = 316 - (i - 6) * 61;
                        coordPictureBox.Y = 36 + j * 51;
                    }
                    if (i >= 12 && i < 18)
                    {
                        coordPictureBox.X = 12 + (i - 12) * 61;
                        coordPictureBox.Y = 560 - j * 51;

                    }
                    if (i >= 18 && i < 24)
                    {
                        coordPictureBox.X = 434 + (i - 18) * 61;
                        coordPictureBox.Y = 560 - j * 51;
                    }
                    p = new PictureBox
                    {
                        Location = coordPictureBox,
                        Name = "coloana" + (i + 1) + (j + 1),
                        Size = new Size(62, 51),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        TabIndex = 6,
                        TabStop = false,
                        Parent = this,
                        BackColor = Color.Transparent
                    };
                    #endregion
                    p.Click += ClickPeColoana;//eventHandler

                    stiveDesenate[i][j] = p;
                    Controls.Add(p);
                    p.BringToFront();
                }
            }
            #region InitializareTabla
            for (int i = 0; i < 25; i++)
            {
                joc.getColoane().Add(new Stack<Piese>());
            }

            //2 piese negre pe coloana 1
            for (int i = 0; i < 2; i++)
            {
                joc.getColoane()[0].Push(new PieseAlbe());
                stiveDesenate[0][i].Image = joc.getColoane()[0].Peek().ImaginePiesa();
            }

            //5 piese albe pe coloana 6
            for (int i = 0; i < 5; i++)
            {
                joc.getColoane()[5].Push(new PieseNegre());
                stiveDesenate[5][i].Image = joc.getColoane()[5].Peek().ImaginePiesa();
            }

            //3 piese albe pe coloana 8
            for (int i = 0; i < 3; i++)
            {
                joc.getColoane()[7].Push(new PieseNegre());
                stiveDesenate[7][i].Image = joc.getColoane()[7].Peek().ImaginePiesa();
            }

            //5 piese negre pe coloana 12
            for (int i = 0; i < 5; i++)
            {
                joc.getColoane()[11].Push(new PieseAlbe());
                stiveDesenate[11][i].Image = joc.getColoane()[11].Peek().ImaginePiesa();
            }
            //5 piese albe pe coloana 13
            for (int i = 0; i < 5; i++)
            {
                joc.getColoane()[12].Push(new PieseNegre());
                stiveDesenate[12][i].Image = joc.getColoane()[12].Peek().ImaginePiesa();
            }
            //3 piese negre pe coloana 17
            for (int i = 0; i < 3; i++)
            {
                joc.getColoane()[16].Push(new PieseAlbe());
                stiveDesenate[16][i].Image = joc.getColoane()[16].Peek().ImaginePiesa();
            }
            //5 piese negre pe coloana 19
            for (int i = 0; i < 5; i++)
            {
                joc.getColoane()[18].Push(new PieseAlbe());
                stiveDesenate[18][i].Image = joc.getColoane()[18].Peek().ImaginePiesa();
            }
            //2 piese albe pe coloana 24
            for (int i = 0; i < 2; i++)
            {
                joc.getColoane()[23].Push(new PieseNegre());
                stiveDesenate[23][i].Image = joc.getColoane()[23].Peek().ImaginePiesa();
            }
            #endregion
        }
        private void ClickPeColoana(object sender, EventArgs e)
        {
            for (int iActual = 0; iActual < 24; iActual++)
            {
                for (int jActual = 0; jActual < 5; jActual++)
                {
                    if (sender == stiveDesenate[iActual][jActual])
                    {
                        if (joc.getStare().Equals(Stari.coloanaNeselectata))
                        {
                            if (joc.getZar1().getValue() == 0 && joc.getZar2().getValue() == 0)
                            {
                                MessageBox.Show("Intai se da cu zarul!");
                                return;
                            }

                            if (joc.getZar1().aMutat == true && joc.getZar2().aMutat == true)
                            {
                                MessageBox.Show("S-au folosit toate mutarile! Celalalt jucator da cu zarul!");
                                return;
                            }

                            if (joc.getColoane()[iActual].Count == 0)// daca coloana e goala
                            {
                                MessageBox.Show("Pe coloana " + (iActual + 1) + " nu mai sunt piese! Alegeti alta coloana!");
                                return;
                            }

                            if (!joc.ColoanaPlayerCurent(iActual))
                            {
                                MessageBox.Show("Randul celuilalt player!");
                                return;
                            }

                            indicatori[iActual].BackColor = Color.Fuchsia;

                            if (joc.IndiciValiziZaruri(iActual, joc.getZar1()) == true)
                            {
                                indicatori[iActual + (joc.getZar1().getValue() * joc.getColoane()[iActual].Peek().Sens())].BackColor = Color.DarkOliveGreen;
                            }
                            if (joc.IndiciValiziZaruri(iActual, joc.getZar2()) == true)
                            {
                                indicatori[iActual + (joc.getZar2().getValue() * joc.getColoane()[iActual].Peek().Sens())].BackColor = Color.DarkOliveGreen;
                            }
                            //evenutal sa se faca ceva la imaginile unde se elimina piese
                            joc.setIAnterior(iActual);
                            joc.setStare(Stari.coloanaSelectata);

                            return;
                        }//s-a selectat coloana de pe care se ia piesa
                        else if (joc.getStare().Equals(Stari.coloanaSelectata) && joc.getIAnterior() != iActual)
                        {
                            int i1, i2;

                            if (joc.getIAnterior() == -1)
                            {
                                i1 = joc.getIAnterior() + joc.getZar1().getValue();
                                i2 = joc.getIAnterior() + joc.getZar2().getValue();
                            }
                            else if (joc.getIAnterior() == 24)
                            {
                                i1 = joc.getIAnterior() - joc.getZar1().getValue();
                                i2 = joc.getIAnterior() - joc.getZar2().getValue();
                            }
                            else
                            {
                                i1 = joc.getIAnterior() + joc.getZar1().getValue() * joc.getColoane()[joc.getIAnterior()].Peek().Sens();
                                i2 = joc.getIAnterior() + joc.getZar2().getValue() * joc.getColoane()[joc.getIAnterior()].Peek().Sens();
                            }

                            if (((i1 < 0) || (i1 > 23)) && ((i2 < 0) || (i2 > 23)))
                            {
                                MessageBox.Show("Nu se poate muta de pe aceasta pozitie folosind valorile actuale ale zarurilor!");
                                indicatori[iActual].BackColor = Color.Transparent;
                                return;
                            }

                            if (i1 != iActual && i2 != iActual)
                            {
                                MessageBox.Show("Nu se poate muta pe aceasta pozitie! Mutati cu o valoare de pe zar!");
                                return;
                            }

                            if (i1 == iActual && joc.getZar1().aMutat == false)
                            {
                                if (joc.getIAnterior() == -1)
                                {
                                    if (typeof(PieseNegre) != joc.getColoana().TipPiesaDePeColoana(i1) && joc.getColoane()[i1].Count >= 2)
                                    {
                                        MessageBox.Show("Nu se poate muta pe aceasta coloana! \nSunt mai mult de 2 piese de tip diferit!");
                                        return;
                                    }
                                }
                                else if (joc.getIAnterior() == 24)
                                {
                                    if (typeof(PieseAlbe) != joc.getColoana().TipPiesaDePeColoana(i1) && joc.getColoane()[i1].Count >= 2)
                                    {
                                        MessageBox.Show("Nu se poate muta pe aceasta coloana! \nSunt mai mult de 2 piese de tip diferit!");
                                        return;
                                    }
                                }
                                else if (joc.getColoana().TipPiesaDePeColoana(joc.getIAnterior()) != joc.getColoana().TipPiesaDePeColoana(i1) && joc.getColoane()[i1].Count >= 2)
                                {
                                    MessageBox.Show("Nu se poate muta pe aceasta coloana! \nSunt mai mult de 2 piese de tip diferit!");
                                    return;
                                }
                                Muta(iActual, i1, i2, joc.getZar1());
                            }
                            else if (i2 == iActual && joc.getZar2().aMutat == false)
                            {
                                if (joc.getIAnterior() == -1)
                                {
                                    if (typeof(PieseNegre) != joc.getColoana().TipPiesaDePeColoana(i2) && joc.getColoane()[i2].Count >= 2)
                                    {
                                        MessageBox.Show("Nu se poate muta pe aceasta coloana! \nSunt mai mult de 2 piese de tip diferit!");
                                        return;
                                    }
                                }
                                else if (joc.getIAnterior() == 24)
                                {
                                    if (typeof(PieseAlbe) != joc.getColoana().TipPiesaDePeColoana(i2) && joc.getColoane()[i2].Count >= 2)
                                    {
                                        MessageBox.Show("Nu se poate muta pe aceasta coloana! \nSunt mai mult de 2 piese de tip diferit!");
                                        return;
                                    }
                                }
                                else if (joc.getColoana().TipPiesaDePeColoana(joc.getIAnterior()) != joc.getColoana().TipPiesaDePeColoana(i2) && joc.getColoane()[i2].Count >= 2)
                                {
                                    MessageBox.Show("Nu se poate muta pe aceasta coloana! \nSunt mai mult de 2 piese de tip diferit!");
                                    return;
                                }
                                Muta(iActual, i1, i2, joc.getZar2());
                            }
                            else if (joc.getZar1().aMutat == true && !joc.ZaruriEgale(joc.getZar1(), joc.getZar2()))
                            {
                                MessageBox.Show("S-a mutat cu zarul cu valoarea " + joc.getZar1().getValue() + "!");
                                return;
                            }
                            else if (joc.getZar2().aMutat == true)
                            {
                                MessageBox.Show("S-a mutat cu zarul cu valoarea " + joc.getZar2().getValue() + "!");
                                return;
                            }

                            if (joc.ToatePieseleAlbeInCasa() == true)
                            {
                                joc.setAlbPoateElimina(true);
                                pieseAlbeEliminateImg.Image = Resources.whitePiece;
                                pieseAlbeEliminateLabel.Text = "" + joc.getNrPieseAlbeEliminate(); ;
                            }

                            if (joc.ToatePieseleNegreInCasa() == true)
                            {
                                joc.setNegruPoateElimina(true);
                                pieseNegreEliminateImg.Image = Resources.blackPiece;
                                pieseNegreEliminateLabel.Text = "" + joc.getNrPieseNegreEliminate();
                            }

                            joc.setStare(Stari.coloanaNeselectata);
                            return;
                        }
                        else if (joc.getStare().Equals(Stari.coloanaSelectata) && joc.getIAnterior() == iActual)
                        {
                            joc.setStare(Stari.coloanaNeselectata);
                            indicatori[iActual].BackColor = Color.Transparent;

                            if (joc.IndiciValiziZaruri(iActual, joc.getZar1()) == true)
                                indicatori[iActual + (joc.getZar1().getValue() * joc.getColoane()[iActual].Peek().Sens())].BackColor = Color.Transparent;

                            if (joc.IndiciValiziZaruri(iActual, joc.getZar2()) == true)
                                indicatori[iActual + (joc.getZar2().getValue() * joc.getColoane()[iActual].Peek().Sens())].BackColor = Color.Transparent;
                        }
                        else
                            return;
                    }
                }
            }
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void RollBtn_Click(object sender, EventArgs e)
        {
            if (joc.getZar1().aMutat == false || joc.getZar2().aMutat == false)
            {
                MessageBox.Show("Trebuie sa va folositi ambele mutari!");
                return;
            }
            joc.getZar1().aMutat = false;
            joc.getZar2().aMutat = false;

            joc.NextRand();
            if (joc.getRand() == 0) // alb
            {
                pictureBox1.Image = Resources.sageata;
                pictureBox2.Image = null;
            }
            else if (joc.getRand() == 1) // negru
            {
                pictureBox1.Image = null;
                pictureBox2.Image = Resources.sageata;
            }

            joc.getZar1().Roll();
            joc.getZar1().ShowImage(die1Picture, joc.getZar1().getValue());

            Thread.Sleep(new Random().Next(1000, 2000));

            joc.getZar2().Roll();
            joc.getZar2().ShowImage(die2Picture, joc.getZar2().getValue());

            joc.setStare(Stari.coloanaNeselectata);
            if (joc.getIAnterior() >= 0 && joc.getIAnterior() <= 23)
                indicatori[joc.getIAnterior()].BackColor = Color.Transparent;

            if (joc.ZaruriEgale(joc.getZar1(), joc.getZar2()))
            {
                joc.getZar1().setEDubla(true);
                joc.getZar2().setEDubla(true);
            }
        }
        private void PieseNegreEliminateImg_Click(object sender, EventArgs e)
        {
            if (joc.getColoana().TipPiesaDePeColoana(joc.getIAnterior()) == typeof(PieseNegre) && joc.getStare().Equals(Stari.coloanaSelectata))
            {
                if (joc.getZar1().aMutat == true && joc.getZar2().aMutat == true)
                {
                    MessageBox.Show("S-a mutat cu ambele zaruri!");
                    indicatori[joc.getIAnterior()].BackColor = Color.Transparent;

                    joc.setStare(Stari.coloanaNeselectata);
                    return;
                }
                if (joc.getIAnterior() - joc.getZar1().getValue() < 0 && joc.getNegruPoateElimina() == true && joc.getZar1().aMutat == false && joc.getColoane()[joc.getIAnterior()].Count > 0)
                {
                    joc.getZar1().aMutat = true;

                    if ((joc.getColoane()[joc.getIAnterior()].Count - 1) < 5)
                        stiveDesenate[joc.getIAnterior()][joc.getColoane()[joc.getIAnterior()].Count - 1].Image = null;
                    else
                    {
                        if (joc.getColoane()[joc.getIAnterior()].Count == 6)
                            nrPiese[joc.getIAnterior()].Text = "";
                        else
                            nrPiese[joc.getIAnterior()].Text = "      " + (joc.getColoane()[joc.getIAnterior()].Count - 1);
                    }

                    joc.getPieseNegreEliminate().Push((PieseNegre)joc.getColoane()[joc.getIAnterior()].Pop());
                    pieseNegreEliminateLabel.Text = "" + joc.getNrPieseNegreEliminate();
                    indicatori[joc.getIAnterior()].BackColor = Color.Transparent;

                    if (joc.getIAnterior() - joc.getZar1().getValue() > -1)
                        indicatori[joc.getIAnterior() - joc.getZar1().getValue()].BackColor = Color.Transparent;
                    if (joc.getIAnterior() - joc.getZar2().getValue() > -1)
                        indicatori[joc.getIAnterior() - joc.getZar2().getValue()].BackColor = Color.Transparent;

                    if (joc.getNegruCastiga() == true)
                        Application.Exit();

                    joc.setStare(Stari.coloanaNeselectata);
                    return;
                }

                if (joc.getIAnterior() - joc.getZar2().getValue() < 0 && joc.getNegruPoateElimina() == true && joc.getZar2().aMutat == false && joc.getColoane()[joc.getIAnterior()].Count > 0)
                {
                    joc.getZar2().aMutat = true;

                    if ((joc.getColoane()[joc.getIAnterior()].Count - 1) < 5)
                        stiveDesenate[joc.getIAnterior()][joc.getColoane()[joc.getIAnterior()].Count - 1].Image = null;
                    else
                    {
                        if (joc.getColoane()[joc.getIAnterior()].Count == 6)
                            nrPiese[joc.getIAnterior()].Text = "";
                        else
                            nrPiese[joc.getIAnterior()].Text = "      " + (joc.getColoane()[joc.getIAnterior()].Count - 1);
                    }
                    joc.getPieseNegreEliminate().Push((PieseNegre)joc.getColoane()[joc.getIAnterior()].Pop());
                    pieseNegreEliminateLabel.Text = "" + joc.getNrPieseNegreEliminate();
                    indicatori[joc.getIAnterior()].BackColor = Color.Transparent;

                    if (joc.getIAnterior() - joc.getZar1().getValue() > -1)
                        indicatori[joc.getIAnterior() - joc.getZar1().getValue()].BackColor = Color.Transparent;
                    if (joc.getIAnterior() - joc.getZar2().getValue() > -1)
                        indicatori[joc.getIAnterior() - joc.getZar2().getValue()].BackColor = Color.Transparent;

                    if (joc.getNegruCastiga() == true)
                        Application.Exit();

                    joc.setStare(Stari.coloanaNeselectata);
                    return;
                }
            }
        }
        private void PieseAlbeEliminateImg_Click(object sender, EventArgs e)
        {
            if (joc.getColoana().TipPiesaDePeColoana(joc.getIAnterior()) == typeof(PieseAlbe) && joc.getStare().Equals(Stari.coloanaSelectata))
            {
                if (joc.getZar1().aMutat == true && joc.getZar2().aMutat == true)
                {
                    MessageBox.Show("S-a mutat cu ambele zaruri!");
                    indicatori[joc.getIAnterior()].BackColor = Color.Transparent;
                    joc.setStare(Stari.coloanaNeselectata);
                    return;
                }
                if (joc.getIAnterior() + joc.getZar1().getValue() > 23 && joc.getAlbPoateElimina() == true && joc.getZar1().aMutat == false && joc.getColoane()[joc.getIAnterior()].Count > 0)
                {
                    joc.getZar1().aMutat = true;

                    if ((joc.getColoane()[joc.getIAnterior()].Count - 1) < 5)
                        stiveDesenate[joc.getIAnterior()][joc.getColoane()[joc.getIAnterior()].Count - 1].Image = null;
                    else
                    {
                        if (joc.getColoane()[joc.getIAnterior()].Count == 6)
                            nrPiese[joc.getIAnterior()].Text = "";
                        else
                            nrPiese[joc.getIAnterior()].Text = "      " + (joc.getColoane()[joc.getIAnterior()].Count - 1);
                    }

                    joc.getPieseAlbeEliminate().Push((PieseAlbe)joc.getColoane()[joc.getIAnterior()].Pop());
                    pieseAlbeEliminateLabel.Text = "" + joc.getNrPieseAlbeEliminate();
                    indicatori[joc.getIAnterior()].BackColor = Color.Transparent;

                    if (joc.getIAnterior() + joc.getZar1().getValue() < 24)
                        indicatori[joc.getIAnterior() + joc.getZar1().getValue()].BackColor = Color.Transparent;
                    if (joc.getIAnterior() + joc.getZar2().getValue() < 24)
                        indicatori[joc.getIAnterior() + joc.getZar2().getValue()].BackColor = Color.Transparent;

                    if (joc.getAlbCastiga() == true)
                        Application.Exit();

                    joc.setStare(Stari.coloanaNeselectata);
                    return;
                }

                if (joc.getIAnterior() + joc.getZar2().getValue() > 23 && joc.getAlbPoateElimina() == true && joc.getZar2().aMutat == false && joc.getColoane()[joc.getIAnterior()].Count > 0)
                {
                    joc.getZar2().aMutat = true;

                    if ((joc.getColoane()[joc.getIAnterior()].Count - 1) < 5)
                        stiveDesenate[joc.getIAnterior()][joc.getColoane()[joc.getIAnterior()].Count - 1].Image = null;
                    else
                    {
                        if (joc.getColoane()[joc.getIAnterior()].Count == 6)
                            nrPiese[joc.getIAnterior()].Text = "";
                        else
                            nrPiese[joc.getIAnterior()].Text = "      " + (joc.getColoane()[joc.getIAnterior()].Count - 1);
                    }

                    joc.getPieseAlbeEliminate().Push((PieseAlbe)joc.getColoane()[joc.getIAnterior()].Pop());
                    pieseAlbeEliminateLabel.Text = "" + joc.getNrPieseAlbeEliminate();
                    indicatori[joc.getIAnterior()].BackColor = Color.Transparent;

                    if (joc.getIAnterior() + joc.getZar1().getValue() < 24)
                        indicatori[joc.getIAnterior() + joc.getZar1().getValue()].BackColor = Color.Transparent;
                    if (joc.getIAnterior() + joc.getZar2().getValue() < 24)
                        indicatori[joc.getIAnterior() + joc.getZar2().getValue()].BackColor = Color.Transparent;

                    if (joc.getAlbCastiga() == true)
                        Application.Exit();

                    joc.setStare(Stari.coloanaNeselectata);
                    return;
                }
            }
        }
        private void PieseNegreScoaseImg_Click(object sender, EventArgs e)
        {
            if (joc.getRand() == 1)
            {
                if (joc.getStare().Equals(Stari.coloanaSelectata) && joc.getIAnterior() == 24)
                {
                    joc.setStare(Stari.coloanaNeselectata);
                    indicatori[24 - joc.getZar1().getValue()].BackColor = Color.Transparent;
                    indicatori[24 - joc.getZar2().getValue()].BackColor = Color.Transparent;
                    return;
                }

                if (joc.getStare().Equals(Stari.coloanaNeselectata))
                {
                    if (joc.getZar1().aMutat == true && joc.getZar2().aMutat == true)
                    {
                        MessageBox.Show("S-a mutat cu ambele zaruri!");
                        return;
                    }

                    if (joc.getNrPieseNegreScoase() > 0)
                    {
                        if (joc.RepunePiesaNeagra(joc.getZar1()) || joc.RepunePiesaNeagra(joc.getZar2()))
                        {
                            if (joc.RepunePiesaNeagra(joc.getZar1()) && joc.getZar1().aMutat == false)
                            {
                                indicatori[24 - joc.getZar1().getValue()].BackColor = Color.DarkOliveGreen;
                            }
                            if (joc.RepunePiesaNeagra(joc.getZar2()) && joc.getZar2().aMutat == false)
                            {
                                indicatori[24 - joc.getZar2().getValue()].BackColor = Color.DarkOliveGreen;
                            }
                            joc.setIAnterior(24);
                            joc.setStare(Stari.coloanaSelectata);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nu sunt piese negre de scos!");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Este randul celuilalt jucator!");
            }
        }
        private void PieseAlbeScoaseImg_Click(object sender, EventArgs e)
        {
            if (joc.getRand() == 0)
            {
                if (joc.getStare().Equals(Stari.coloanaSelectata) && joc.getIAnterior() == -1)
                {
                    joc.setStare(Stari.coloanaNeselectata);
                    indicatori[-1 + joc.getZar1().getValue()].BackColor = Color.Transparent;
                    indicatori[-1 + joc.getZar2().getValue()].BackColor = Color.Transparent;
                    return;
                }
                if (joc.getStare().Equals(Stari.coloanaNeselectata))
                {
                    if (joc.getZar1().aMutat == true && joc.getZar2().aMutat == true)
                    {
                        MessageBox.Show("S-a mutat cu ambele zaruri!");
                        return;
                    }

                    if (joc.getNrPieseAlbeScoase() > 0)
                    {
                        if (joc.RepunePiesaAlba(joc.getZar1()) || joc.RepunePiesaAlba(joc.getZar2()))
                        {
                            if (joc.RepunePiesaAlba(joc.getZar1()) && joc.getZar1().aMutat == false)
                            {
                                indicatori[-1 + joc.getZar1().getValue()].BackColor = Color.DarkOliveGreen;
                            }
                            if (joc.RepunePiesaAlba(joc.getZar2()) && joc.getZar2().aMutat == false)
                            {
                                indicatori[-1 + joc.getZar2().getValue()].BackColor = Color.DarkOliveGreen;
                            }
                            joc.setStare(Stari.coloanaSelectata);
                            joc.setIAnterior(-1);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nu sunt piese albe de scos!");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Este randul celuilalt jucator!");
            }
        }


        //METODE     
        private void StergeBackGroundIndicatori(int iAnterior, int iZar1, int iZar2)
        {
            if (iAnterior >= 0 && iAnterior <= 23)
                indicatori[iAnterior].BackColor = Color.Transparent;

            if (iZar1 >= 0 && iZar1 < 24)
                indicatori[iZar1].BackColor = Color.Transparent;

            if (iZar2 >= 0 && iZar2 < 24)
                indicatori[iZar2].BackColor = Color.Transparent;
        }
        private void MutaCuZar(int iAnterior, Zar zar)
        {
            int noulI;

            if (iAnterior == -1)
            {
                noulI = iAnterior + zar.getValue();
            }
            else if (iAnterior == 24)
            {
                noulI = iAnterior - zar.getValue();
            }
            else
            {
                noulI = iAnterior + zar.getValue() * joc.getColoane()[joc.getIAnterior()].Peek().Sens();
            }

            Piese p;
            if (joc.getIAnterior() == -1)
                p = joc.getPieseAlbeScoase().Pop();
            else if (joc.getIAnterior() == 24)
                p = joc.getPieseNegreScoase().Pop();
            else
                p = joc.getColoane()[joc.getIAnterior()].Pop(); //scot din prima stiva
            if (joc.getIAnterior() == -1)
            {
                if (joc.getNrPieseAlbeScoase() == 0)
                {
                    pieseAlbeScoaseImg.Image = null;
                    pieseAlbeScoaseLabel.Text = "";
                }
                else
                {
                    pieseAlbeScoaseLabel.Text = "" + joc.getNrPieseAlbeScoase();
                }
            }
            else if (joc.getIAnterior() == 24)
            {
                if (joc.getNrPieseNegreScoase() == 0)
                {
                    pieseNegreScoaseImg.Image = null;
                    pieseNegreScoaseLabel.Text = "";
                }
                else
                {
                    pieseNegreScoaseLabel.Text = "" + joc.getNrPieseNegreScoase();
                }
            }
            else if (joc.getColoane()[joc.getIAnterior()].Count < 5)//pun nr de piese de pe coloana daca sunt mai mult de 5 piese
                stiveDesenate[joc.getIAnterior()][joc.getColoane()[joc.getIAnterior()].Count].Image = null;
            else if (joc.getColoane()[joc.getIAnterior()].Count == 5)
                nrPiese[joc.getIAnterior()].Text = "";
            else
                nrPiese[joc.getIAnterior()].Text = "      " + joc.getColoane()[joc.getIAnterior()].Count;

            joc.getColoane()[noulI].Push(p); //adaug in a 2 a stiva

            if (joc.getColoane()[noulI].Count <= 5)//pun imaginea unde trebuie
                stiveDesenate[noulI][joc.getColoane()[noulI].Count - 1].Image = p.ImaginePiesa();
            else
            {
                nrPiese[noulI].Text = "      " + joc.getColoane()[noulI].Count;
                nrPiese[noulI].ForeColor = Color.Red;
                nrPiese[noulI].Font = new Font(nrPiese[noulI].Font, FontStyle.Bold);
            }
            zar.aMutat = true;
        }
        private void Muta(int iActual, int i1, int i2, Zar zar)
        {
            if (joc.getIAnterior() == -1)//scot alba
            {
                if (joc.getColoana().TipPiesaDePeColoana(iActual) == typeof(PieseNegre) && joc.getColoane()[iActual].Count == 1)
                {
                    if (joc.getNrPieseNegreScoase() == 0)
                        pieseNegreScoaseImg.Image = Resources.blackPiece;
                    stiveDesenate[iActual][0].Image = null;
                    joc.getPieseNegreScoase().Push((PieseNegre)joc.getColoane()[iActual].Pop());
                    pieseNegreScoaseLabel.Text = "" + joc.getNrPieseNegreScoase();

                }

                MutaCuZar(joc.getIAnterior(), zar);
                StergeBackGroundIndicatori(joc.getIAnterior(), i1, i2);
            }
            else if (joc.getIAnterior() == 24)//scot neagra
            {
                if (joc.getColoana().TipPiesaDePeColoana(iActual) == typeof(PieseAlbe) && joc.getColoane()[iActual].Count == 1)
                {
                    if (joc.getNrPieseAlbeScoase() == 0)
                        pieseAlbeScoaseImg.Image = Resources.whitePiece;
                    stiveDesenate[iActual][0].Image = null;
                    joc.getPieseAlbeScoase().Push((PieseAlbe)joc.getColoane()[iActual].Pop());
                    pieseAlbeScoaseLabel.Text = "" + joc.getNrPieseAlbeScoase();
                }

                MutaCuZar(joc.getIAnterior(), zar);
                StergeBackGroundIndicatori(joc.getIAnterior(), i1, i2);
            }
            else if (joc.getColoana().TipPiesaDePeColoana(iActual) != joc.getColoana().TipPiesaDePeColoana(joc.getIAnterior()) && joc.getColoane()[iActual].Count == 1) // tipuri diferite, dar pe a 2 a coloana e doar o piesa
            {
                stiveDesenate[iActual][0].Image = null;
                Piese p = joc.getColoane()[iActual].Pop();

                if (p.GetType() == typeof(PieseAlbe))
                {
                    joc.getPieseAlbeScoase().Push((PieseAlbe)p);
                    if (joc.getNrPieseAlbeScoase() == 1)
                    {
                        pieseAlbeScoaseImg.Image = Resources.whitePiece;
                    }
                    pieseAlbeScoaseLabel.Text = "" + joc.getNrPieseAlbeScoase();

                }
                else
                {
                    joc.getPieseNegreScoase().Push((PieseNegre)p);
                    if (joc.getNrPieseNegreScoase() == 1)
                    {
                        pieseNegreScoaseImg.Image = Resources.blackPiece;
                    }
                    pieseNegreScoaseLabel.Text = "" + joc.getNrPieseNegreScoase();
                }

                MutaCuZar(joc.getIAnterior(), zar);
                StergeBackGroundIndicatori(joc.getIAnterior(), i1, i2);
            }
            else if (joc.getColoana().TipPiesaDePeColoana(iActual) == joc.getColoana().TipPiesaDePeColoana(joc.getIAnterior()) || joc.getColoana().TipPiesaDePeColoana(iActual) == null)
            {
                MutaCuZar(joc.getIAnterior(), zar);
                StergeBackGroundIndicatori(joc.getIAnterior(), i1, i2);
            }
        }
    }
}
