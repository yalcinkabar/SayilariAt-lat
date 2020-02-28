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
    public partial class OyunBoyutu : Form
    {
        public int boyut;

        public OyunBoyutu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Oyun boyutunun seçildiği metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            boyut = Convert.ToInt32(btn.Name.Substring(3, 1)); // Seçilen oyun boyutu bilgisi alınıyor...
            Hide();
        }
    }
}
