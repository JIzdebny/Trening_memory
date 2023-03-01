using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trening_memory
{
    public partial class Form1 : Form
    {
        bool[] czy_przyciski_maja_kolor = new bool[17];
        Color[] kolory = new Color[17];
        bool[] zakryte = new bool[17];
        bool czy_pierwszy_klik = true;
        int ruchy = 0;
        int numer_1 = 0;
        int numer_2 = 0;

        public Form1()
        {
            InitializeComponent();
            lusuj_przycisk(Color.Red);
            lusuj_przycisk(Color.Red);
            lusuj_przycisk(Color.Blue);
            lusuj_przycisk(Color.Blue);
            lusuj_przycisk(Color.Pink);
            lusuj_przycisk(Color.Pink);
            lusuj_przycisk(Color.Green);
            lusuj_przycisk(Color.Green);
            lusuj_przycisk(Color.Aqua);
            lusuj_przycisk(Color.Aqua);
            lusuj_przycisk(Color.Gold);
            lusuj_przycisk(Color.Gold);
            lusuj_przycisk(Color.Black);
            lusuj_przycisk(Color.Black);
            lusuj_przycisk(Color.White);
            lusuj_przycisk(Color.White);

            for (int i = 1; i < 17; i++)
            {
                zakryte[i] = true;
            }

            koloruj_przyciski();

        }

        private void koloruj_przyciski()
        {
            if (zakryte[1] == false) { button1.BackColor = kolory[1]; } else { button1.BackColor = Color.Gray; }
            if (zakryte[2] == false) { button2.BackColor = kolory[2]; } else { button2.BackColor = Color.Gray; }
            if (zakryte[3] == false) { button3.BackColor = kolory[3]; } else { button3.BackColor = Color.Gray; }
            if (zakryte[4] == false) { button4.BackColor = kolory[4]; } else { button4.BackColor = Color.Gray; }
            if (zakryte[5] == false) { button5.BackColor = kolory[5]; } else { button5.BackColor = Color.Gray; }
            if (zakryte[6] == false) { button6.BackColor = kolory[6]; } else { button6.BackColor = Color.Gray; }
            if (zakryte[7] == false) { button7.BackColor = kolory[7]; } else { button7.BackColor = Color.Gray; }
            if (zakryte[8] == false) { button8.BackColor = kolory[8]; } else { button8.BackColor = Color.Gray; }
            if (zakryte[9] == false) { button9.BackColor = kolory[9]; } else { button9.BackColor = Color.Gray; }
            if (zakryte[10] == false) { button10.BackColor = kolory[10]; } else { button10.BackColor = Color.Gray; }
            if (zakryte[11] == false) { button11.BackColor = kolory[11]; } else { button11.BackColor = Color.Gray; }
            if (zakryte[12] == false) { button12.BackColor = kolory[12]; } else { button12.BackColor = Color.Gray; }
            if (zakryte[13] == false) { button13.BackColor = kolory[13]; } else { button13.BackColor = Color.Gray; }
            if (zakryte[14] == false) { button14.BackColor = kolory[14]; } else { button14.BackColor = Color.Gray; }
            if (zakryte[15] == false) { button15.BackColor = kolory[15]; } else { button15.BackColor = Color.Gray; }
            if (zakryte[16] == false) { button16.BackColor = kolory[16]; } else { button16.BackColor = Color.Gray; }

        }

        private void lusuj_przycisk(Color kolor)
        {
            Random gen = new Random();
            int numer_pola = gen.Next(1, 17);
            while(czy_przyciski_maja_kolor[numer_pola] == true)
            {
                numer_pola = gen.Next(1, 17);
            }
            czy_przyciski_maja_kolor[numer_pola] = true;
            kolory[numer_pola] = kolor;
        }

        private void sprawdz()
        {
            ruchy++;
            if(kolory[numer_1] == kolory[numer_2])
            {
                MessageBox.Show("Brawo! Trafiony");
                zakryte[numer_1] = false;
                zakryte[numer_2] = false;
            }
            else
            {
                MessageBox.Show("Pudło!");
            }
            int odkryte = 0;
            for (int j = 1; j < 17; j++)
            {
                if(zakryte[j] == false)
                {
                    odkryte++;
                }
            }
            if(odkryte == 16) { MessageBox.Show("Gratulacje! Ilość ruchów: " + ruchy); }
        }

        private void new_game_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wersja treningowa. Aktualna ilość ruchów: " + ruchy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = kolory[1];
            if(czy_pierwszy_klik == true)
            {
                numer_1 = 1;
                czy_pierwszy_klik = false;
            }
            else
            {
                numer_2 = 1;
                czy_pierwszy_klik = true;
                sprawdz();
                koloruj_przyciski();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = kolory[2];
            if (czy_pierwszy_klik == true)
            {
                numer_1 = 2;
                czy_pierwszy_klik = false;
            }
            else
            {
                numer_2 = 2;
                czy_pierwszy_klik = true;
                sprawdz();
                koloruj_przyciski();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = kolory[3];
            if (czy_pierwszy_klik == true)
            {
                numer_1 = 3;
                czy_pierwszy_klik = false;
            }
            else
            {
                numer_2 = 3;
                czy_pierwszy_klik = true;
                sprawdz();
                koloruj_przyciski();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = kolory[4];
            if (czy_pierwszy_klik == true)
            {
                numer_1 = 4;
                czy_pierwszy_klik = false;
            }
            else
            {
                numer_2 = 4;
                czy_pierwszy_klik = true;
                sprawdz();
                koloruj_przyciski();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = kolory[5];
            if (czy_pierwszy_klik == true)
            {
                numer_1 = 5;
                czy_pierwszy_klik = false;
            }
            else
            {
                numer_2 = 5;
                czy_pierwszy_klik = true;
                sprawdz();
                koloruj_przyciski();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = kolory[6];
            if (czy_pierwszy_klik == true)
            {
                numer_1 = 6;
                czy_pierwszy_klik = false;
            }
            else
            {
                numer_2 = 6;
                czy_pierwszy_klik = true;
                sprawdz();
                koloruj_przyciski();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = kolory[7];
            if (czy_pierwszy_klik == true)
            {
                numer_1 = 7;
                czy_pierwszy_klik = false;
            }
            else
            {
                numer_2 = 7;
                czy_pierwszy_klik = true;
                sprawdz();
                koloruj_przyciski();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = kolory[8];
            if (czy_pierwszy_klik == true)
            {
                numer_1 = 8;
                czy_pierwszy_klik = false;
            }
            else
            {
                numer_2 = 8;
                czy_pierwszy_klik = true;
                sprawdz();
                koloruj_przyciski();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = kolory[9];
            if (czy_pierwszy_klik == true)
            {
                numer_1 = 9;
                czy_pierwszy_klik = false;
            }
            else
            {
                numer_2 = 9;
                czy_pierwszy_klik = true;
                sprawdz();
                koloruj_przyciski();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = kolory[10];
            if (czy_pierwszy_klik == true)
            {
                numer_1 = 10;
                czy_pierwszy_klik = false;
            }
            else
            {
                numer_2 = 10;
                czy_pierwszy_klik = true;
                sprawdz();
                koloruj_przyciski();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = kolory[11];
            if (czy_pierwszy_klik == true)
            {
                numer_1 = 11;
                czy_pierwszy_klik = false;
            }
            else
            {
                numer_2 = 11;
                czy_pierwszy_klik = true;
                sprawdz();
                koloruj_przyciski();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = kolory[12];
            if (czy_pierwszy_klik == true)
            {
                numer_1 = 12;
                czy_pierwszy_klik = false;
            }
            else
            {
                numer_2 = 12;
                czy_pierwszy_klik = true;
                sprawdz();
                koloruj_przyciski();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = kolory[13];
            if (czy_pierwszy_klik == true)
            {
                numer_1 = 13;
                czy_pierwszy_klik = false;
            }
            else
            {
                numer_2 = 13;
                czy_pierwszy_klik = true;
                sprawdz();
                koloruj_przyciski();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = kolory[14];
            if (czy_pierwszy_klik == true)
            {
                numer_1 = 14;
                czy_pierwszy_klik = false;
            }
            else
            {
                numer_2 = 14;
                czy_pierwszy_klik = true;
                sprawdz();
                koloruj_przyciski();
            }
        }
        
        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = kolory[15];
            if (czy_pierwszy_klik == true)
            {
                numer_1 = 15;
                czy_pierwszy_klik = false;
            }
            else
            {
                numer_2 = 15;
                czy_pierwszy_klik = true;
                sprawdz();
                koloruj_przyciski();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = kolory[16];
            if (czy_pierwszy_klik == true)
            {
                numer_1 = 16;
                czy_pierwszy_klik = false;
            }
            else
            {
                numer_2 = 16;
                czy_pierwszy_klik = true;
                sprawdz();
                koloruj_przyciski();
            }
        }
    }
}
