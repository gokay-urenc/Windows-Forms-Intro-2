using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Giris_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            label1.Text = Convert.ToString(rnd.Next()); // 0'dan başlayarak int aralığında bir sayı oluşturur.
            label2.Text = rnd.Next(5).ToString(); // 0'dan başlayarak 5 dahil olmadan en fazla 4'e kadar rastgele sayı üretir.
            label3.Text = rnd.Next(5, 15).ToString(); // 5'ten başlayarak en fazla 14'e kadar sayı üretir.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int minDeger = Convert.ToInt32(txtMin.Text);
            int maxDeger = Convert.ToInt32(txtMax.Text);
            Random rastgele = new Random();
            int uretilen_sayi = rastgele.Next(minDeger, maxDeger);
            MessageBox.Show("Üretilen sayı: " + uretilen_sayi);
        }
    }
}
// Random() => Rastgele sayı üretmek için kullanılan kod yapısıdır.