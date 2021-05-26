using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kompresjaHuffmana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //policz ile bitów zajmuje zdanie
            string zdanie = tekst.Text;
            //zakładamy, że znak ma 8 bitów
            //więc liczba bitów wynosi:
            int liczbaBitowPrzed = 8 * zdanie.Length;
            //utwórz drzewo na podstawie zdania
            Drzewo korzen = new Drzewo();
            foreach (char znak in zdanie)
            {
                string temp = znak.ToString();
                bool znalazlem = korzen.Find(temp);
                if(!znalazlem) korzen.DodajSymbol(temp);
                System.Console.WriteLine("\nNOWY ETAP");
                korzen.DrukujDrzewo();
            }
            //skompresuj huffmanem
            //w tym celu przygotujemy listę
            //żeby można było zebrać dane
            List<Znak> lista = korzen.ZbierajZnaki();
            //tutaj przedstawiamy kod binarny
            string kodBinarny = "";
            foreach(char znak in zdanie)
            {
                Znak temp=lista.Find(element => element.znak == znak);
                kodBinarny += temp.ciagBitow + " ";
            }
            tekstBinary.Text = kodBinarny;
            //tutaj przedstawiamy statystyki
            //oraz liczymy entropię i średnią długość słowa
            string coPokazac = "";
            float entropia=0, sr=0,pi;
            int liczbaBitowPo=0;
            foreach (Znak znak in lista)
            {
                coPokazac += znak.znak + "(" + znak.liczbaWystapien + ") - " + znak.ciagBitow + Environment.NewLine;

                pi = (float)znak.liczbaWystapien / (float)zdanie.Length;
                entropia += pi * (float)Math.Log(1 / pi, 2);
                sr += pi * (float)znak.ciagBitow.Length;

                liczbaBitowPo += znak.ciagBitow.Length;
            }
            informacje.Text = coPokazac;
            coPokazac = "Entropia: " + entropia + "    Średnia długość słowa: " + sr+"    Liczba bitów przed skompresowaniem: "+liczbaBitowPrzed+"    Liczba bitów po skompresowaniu: "+liczbaBitowPo;
            statystyka.Text = coPokazac;
        }
    }
}
