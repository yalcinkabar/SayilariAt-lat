using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_2
{
    public partial class Oyun : Form
    {
        Kontrol kontrol;
        OyunBoyutu oyunBoyutu = new OyunBoyutu();
        
        public Oyun()
        {
            InitializeComponent();
            kontrol = new Kontrol(pnlOyun, lblKutucuk, lblHamle);
            Show();
            oyunBoyutu.ShowDialog();
            kontrol.KutucuklariOlustur(oyunBoyutu.boyut);
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            DialogResult dr = MsgBox.Show("Oyun Sıfırlansın Mı?", "Yeni Oyun",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) // Yeni oyun oluşturuluyor...
            {
                kontrol.OyunuSifirla();
                oyunBoyutu.ShowDialog();
                kontrol.KutucuklariOlustur(oyunBoyutu.boyut);
            }
        }

        private void Oyun_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MsgBox.Show("Oyundan Çıkış Yapılacak. Onaylıyor Musunuz?", "Çıkış",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes) // Oyundan çıkış yapılıyor...
                Environment.Exit(0);

            else // Çıkış yapmaktan vazgeçildi...
                e.Cancel = true;
        }
    }
}
