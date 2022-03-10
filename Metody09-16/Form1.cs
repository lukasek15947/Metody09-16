using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody09_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double x1, x2, d;
            Vypocty.Diskriminant(a, b, c, out x1, out x2, out d);
            if (d < 0) MessageBox.Show("Rovnice nema reseni v R");
            else if (d > 0) MessageBox.Show("Koren x1 je: " + x1 + " a koren x2 je: " + x2);
            else MessageBox.Show("Rovnice ma jedno dvojnasobne reseni " + x1);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox4.Text;
            int cifSoucet = 0, lichCifSoucet = 0, sudCifSoucet = 0;
            if (Vypocty.ObsahujeCislici(text, out cifSoucet, out lichCifSoucet, out sudCifSoucet))
            {
                MessageBox.Show("Obsahuje číslici v textu");
                MessageBox.Show("Ciferný součet je " + cifSoucet);
                MessageBox.Show("Ciferný součet lichých čísel je " + lichCifSoucet);
                MessageBox.Show("Ciferný součet sudých čísel je " + sudCifSoucet);
            }
            else MessageBox.Show("Neobsahuje cifry");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox5.Text;
            string smazaneCislice;
            int pocetSlov = Vypocty.PocetSlov1(s, out smazaneCislice);
            MessageBox.Show("Počet slov je: " + pocetSlov);
            textBox5.Text = smazaneCislice;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = textBox6.Text;
            int pocetSlov = Vypocty.PocetSlov2(ref s);
            MessageBox.Show("Počet slov je: " + pocetSlov);
            textBox6.Text = s;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = textBox7.Text;
            string nejdelsislovo, nejkratsislovo;
            if(Vypocty.ObsahujeSlovo(s, out nejdelsislovo, out nejkratsislovo))
            {
                MessageBox.Show("Obsahuje více než jedno slovo");
                MessageBox.Show("Nejdelší slovo " + nejdelsislovo);
                MessageBox.Show("Nejkratší slovo " + nejkratsislovo);
            }
            else
            {
                MessageBox.Show("Řetězec neobsahuje ani jedno slovo");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string s = textBox8.Text;
            int pocetVelkych, pocetMalych, pocetJinychZnaku;
            if(Vypocty.JeAlfanum(s, out pocetMalych, out pocetVelkych, out pocetJinychZnaku))
            {
                MessageBox.Show("Je alfanumerický");
                MessageBox.Show("Počet malých: " + pocetMalych);
                MessageBox.Show("Počet velkých: " + pocetVelkych);
                MessageBox.Show("Počet jiných " + pocetJinychZnaku);
            }
            else
            {
                MessageBox.Show("Není alfanumerický");
                MessageBox.Show("Počet malých: " + pocetMalych);
                MessageBox.Show("Počet velkých: " + pocetVelkych);
                MessageBox.Show("Počet jiných " + pocetJinychZnaku);
            }
        }
    }
}
