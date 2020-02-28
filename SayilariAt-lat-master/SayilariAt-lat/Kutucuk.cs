using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_2
{
    /// <summary>
    /// Panel üzerindeki tıklanan kutucakların ilgili sınıfı ("Button" sınıfından kalıtılmıştır)
    /// </summary>
    public class Kutucuk:Button
    {
        private int xKoordinati;
        private int yKoordinati;
        public int koordinatX { get { return xKoordinati; } }
        public int koordinatY { get { return yKoordinati; } }
        public bool acildiMi;

        public Kutucuk(Point p, int koorX, int koorY)
        {
            Width = 50;
            Height = 50;
            Location = p;
            xKoordinati = koorX;
            yKoordinati = koorY;
        }
    }
}
