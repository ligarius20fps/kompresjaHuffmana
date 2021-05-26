using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompresjaHuffmana
{
    class Znak
    {
        public char znak;
        public string ciagBitow;
        public int liczbaWystapien;

        public Znak(char znak, string ciagBitow, int liczbaWystapien)
        {
            this.znak = znak;
            this.ciagBitow = ciagBitow;
            this.liczbaWystapien = liczbaWystapien;
        }
    }
}
