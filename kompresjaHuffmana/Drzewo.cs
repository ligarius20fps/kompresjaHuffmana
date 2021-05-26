using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompresjaHuffmana
{
    class Drzewo
    {
        string znak;
        int waga;

        Drzewo rodzic;
        Drzewo lewe;
        Drzewo prawe;

        public Drzewo()
        {
            this.znak = "NYT";
            this.waga = 0;
        }

        public Drzewo(string znak, int waga, Drzewo rodzic)
        {
            this.znak = znak;
            this.waga = waga;
            this.rodzic = rodzic;
        }

        public Drzewo(Drzewo rodzic)
        {
            this.znak = "NYT";
            this.waga = 0;
            this.rodzic = rodzic;
        }

        public void DodajSymbol(string znak)
        {
            if(this.znak=="NYT")
            {
                Drzewo lewy = new Drzewo(this);
                Drzewo prawy = new Drzewo(znak, 1, this);
                this.znak = "";
                this.lewe = lewy;
                this.prawe = prawy;
                this.Dodawanie();
            }
            else
            {
                if (this.prawe != null) this.prawe.DodajSymbol(znak);
                if (this.lewe != null) this.lewe.DodajSymbol(znak);
            }
        }
        private void Zamiana()
        {
            Drzewo temp = this.lewe;
            this.lewe = this.prawe;
            this.prawe = temp;
        }
        private void Balansuj()
        {
            if (this.lewe.waga > this.prawe.waga) this.Zamiana();
        }

        public void DrukujDrzewo(int spacje=0)
        {
            string wciecie = "";
            for (int i = 0; i < spacje; i++) wciecie += " ";
            System.Console.WriteLine(wciecie+"Waga: " + this.waga+" , znak: "+this.znak);
            if(this.lewe!=null)
            {
                System.Console.WriteLine(wciecie + "Lewy potomek:");
                this.lewe.DrukujDrzewo(spacje + 1);
            }
            if (this.prawe != null)
            {
                System.Console.WriteLine(wciecie + "Prawy potomek:");
                this.prawe.DrukujDrzewo(spacje + 1);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="znak"></param>
        /// <returns>True, gdy znalazł znak w drzewie, False gdy go nie znalazł</returns>
        public bool Find(string znak)
        {
            if (this.znak == znak)
            {
                this.Dodawanie();
                return true;
            }
            else
            {
                bool czyJestPoPrawej=false;
                if (this.prawe != null) czyJestPoPrawej=this.prawe.Find(znak);
                if (czyJestPoPrawej) return true;
                if (this.lewe != null && !czyJestPoPrawej) return this.lewe.Find(znak);
            }
            return false;
        }

        private void Dodawanie()
        {
            this.waga++;
            //wszyscy rodzice waga++
            for (Drzewo i = this.rodzic; i != null; i = i.rodzic)
            {
                i.waga++;
                i.Balansuj();
            }
        }

        public List<Znak> ZbierajZnaki(string bity="")
        {
            List<Znak> lista = new List<Znak>();
            if (this.znak=="")
            {
                lista = this.lewe.ZbierajZnaki(bity + "0");
                lista.AddRange(this.prawe.ZbierajZnaki(bity + "1"));
            }
            else if (this.znak != "NYT")
            {
                //w tym węźle jest znak!
                Znak znak = new Znak(this.znak[0], bity, this.waga);
                lista.Add(znak);
            }
            return lista;
        }
    }
}
