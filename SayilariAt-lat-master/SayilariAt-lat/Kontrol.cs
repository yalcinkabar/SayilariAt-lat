using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_2
{
    public class Kontrol
    {
        private Panel panel;
        private Kutucuk[,] kutucuklar;
        private bool oyunSifirlandi;
        private int acilanBolgeSayisi = 0;
        private int boyut;
        private int sayac;
        private Label kalanKutucuk;
        private Label hamle;


        public Kontrol(Panel p, Label l1, Label l2)
        {
            panel = p;
            kalanKutucuk = l1;
            hamle = l2;
        }

        public void KutucuklariOlustur(int _boyut)
        {
            boyut = _boyut;

            Rectangle r = panel.ClientRectangle;
            Point p = new Point(r.X, r.Y);

            panel.Location = new Point(34 + (8 - boyut) * 26, 30 + (9 - boyut) * 25);

            kutucuklar = new Kutucuk[boyut, boyut];

            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    kutucuklar[i, j] = new Kutucuk(p, i, j);
                    kutucuklar[i, j].BackColor = Color.LightGray;
                    panel.Controls.Add(kutucuklar[i, j]);
                    kutucuklar[i, j].MouseDown += Kutucuk_click;
                    p.X += 50;
                }
                p.Y += 50;
                p.X = r.X;
            }
        }

        private void Kutucuk_click(object sender, MouseEventArgs e)
        {
            Kutucuk kutucuk = (Kutucuk)sender;
            if (e.Button == MouseButtons.Left)
            {
                KutucuklarinRenginiDuzenle();
                kutucuk.acildiMi = true;
                kutucuk.BackColor = Color.Purple;
                kutucuk.Text = (acilanBolgeSayisi + 1).ToString();
                acilanBolgeSayisi++;
                oyunSifirlandi = false;

                sayac = 0;
                
                // koordinatları dizi haline getir koordinatlar[1][2] 

                int x1 = kutucuk.koordinatX + 2;  // L hareketlerinin koordinatları
                int x2 = kutucuk.koordinatX - 2;
                int x3 = kutucuk.koordinatX + 1;
                int x4 = kutucuk.koordinatX - 1;

                int y1 = kutucuk.koordinatY + 2;
                int y2 = kutucuk.koordinatY - 2;
                int y3 = kutucuk.koordinatY + 1;
                int y4 = kutucuk.koordinatY - 1;

                if (x1 > -1 && y3 > -1 && x1 < boyut && y3 < boyut && !kutucuklar[x1, y3].acildiMi) // koşullar
                {
                    TiklananKutucukIslemleri(x1, y3);
                }

                if (x1 > -1 && y4 > -1 && x1 < boyut && y4 < boyut && !kutucuklar[x1, y4].acildiMi)
                {
                    TiklananKutucukIslemleri(x1, y4);
                }

                if (x3 > -1 && y1 > -1 && x3 < boyut && y1 < boyut && !kutucuklar[x3, y1].acildiMi)
                {
                    TiklananKutucukIslemleri(x3, y1);
                }

                if (x3 > -1 && y2 > -1 && x3 < boyut && y2 < boyut && !kutucuklar[x3, y2].acildiMi)
                {
                    TiklananKutucukIslemleri(x3, y2);
                }

                if (x2 > -1 && y3 > -1 && x2 < boyut && y3 < boyut && !kutucuklar[x2, y3].acildiMi)
                {
                    TiklananKutucukIslemleri(x2, y3);
                }

                if (x2 > -1 && y4 > -1 && x2 < boyut && y4 < boyut && !kutucuklar[x2, y4].acildiMi)
                {
                    TiklananKutucukIslemleri(x2, y4);
                }

                if (x4 > -1 && y1 > -1 && x4 < boyut && y1 < boyut && !kutucuklar[x4, y1].acildiMi)
                {
                    TiklananKutucukIslemleri(x4, y1);
                }

                if (x4 > -1 && y2 > -1 && x4 < boyut && y2 < boyut && !kutucuklar[x4, y2].acildiMi)
                {
                    TiklananKutucukIslemleri(x4, y2);
                }

                kalanKutucuk.Text = ((boyut * boyut) - acilanBolgeSayisi).ToString(); // kalan kutucuk sayısı   
                hamle.Text = sayac.ToString(); // oynanabilecek hamle sayısı

                if (acilanBolgeSayisi == boyut * boyut) // kazanma durumu
                {
                    kutucuk.BackColor = Color.Orange;
                    kutucuk.Text = "GAME" + Environment.NewLine +
                                   acilanBolgeSayisi.ToString() +
                                   Environment.NewLine + "FINISH";
                    OyunuBitir(true);
                }

                if (sayac == 0 && !oyunSifirlandi) // kaybetme durumu
                {
                    kutucuk.BackColor = Color.Red;
                    kutucuk.Text = "GAME" + Environment.NewLine +
                                   acilanBolgeSayisi.ToString() +
                                   Environment.NewLine + "OVER";
                    OyunuBitir(false);
                }
            }
        }

        private void TiklananKutucukIslemleri(int x, int y)
        {
            kutucuklar[x, y].Enabled = true;
            kutucuklar[x, y].BackColor = Color.SpringGreen;
            sayac++;
        }


        private void KutucuklarinRenginiDuzenle()
        {
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    kutucuklar[i, j].BackColor = Color.LightGray;

                    if (kutucuklar[i, j].acildiMi)
                        kutucuklar[i, j].BackColor = Color.MediumPurple;

                    kutucuklar[i, j].Enabled = false;
                }
            }
        }

        public void OyunuBitir(bool kazandiMi)
        {
            oyunSifirlandi = true;
            OyunBoyutu ob = new OyunBoyutu();

            if (!kazandiMi)
            {
                DialogResult secenek = MsgBox.Show("Maalesef Kaybettiniz. Yeni Oyuna Başlamak İster Misiniz?",
                                                   "Sonuç",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                YeniOyun(secenek);
            }

            else
            {
                DialogResult secenek = MsgBox.Show("Tebrikler Kazandınız. Yeni Oyuna Başlamak İster Misiniz?", "Sonuç",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                YeniOyun(secenek);
            }
        }

        private void YeniOyun(DialogResult secenek)
        {
            OyunBoyutu ob = new OyunBoyutu();

            if (secenek == DialogResult.Yes) // Yeni oyun oluşturulacak
            {
                OyunuSifirla();
                ob.ShowDialog();
                KutucuklariOlustur(ob.boyut);
            }

            else // Çıkış için onay istenecek
            {
                DialogResult secenek2 = MsgBox.Show("Oyundan Çıkış Yapılacak. Onaylıyor Musunuz?", "Çıkış",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (secenek2 == DialogResult.Yes) // Çıkış yapılıyor
                    Environment.Exit(0);

                else // Çıkış yapılmıyor -> Yeni oyun oluşturuluyor
                {
                    MsgBox.Show("Yeni Oyun Oluşturulacak", "Yeni Oyun",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OyunuSifirla();
                    ob.ShowDialog();
                    KutucuklariOlustur(ob.boyut);
                }                
            }
        }

        public void OyunuSifirla()
        {
            acilanBolgeSayisi = 0;
            panel.Controls.Clear();
            kutucuklar = null;
            kalanKutucuk.Text = "-";
            hamle.Text = "-";
        }
    }
}