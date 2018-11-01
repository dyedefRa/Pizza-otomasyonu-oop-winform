using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzadeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pizza p;
        Siparis s;

        private void Form1_Load(object sender, EventArgs e)
        {
            Ebat kucuk = new Ebat() { Ebattürü = "Kucuk", EbatÇarpanı = 1 };
            Ebat orta = new Ebat() { Ebattürü = "Orta", EbatÇarpanı = 1.25 };
            Ebat buyuk = new Ebat() { Ebattürü = "Büyük", EbatÇarpanı = 1.75 };
            Ebat maxi = new Ebat() { Ebattürü = "Maxi", EbatÇarpanı = 2 };
            List<Ebat> totalEbat = new List<Ebat> { kucuk, orta, buyuk, maxi };
            foreach (Ebat item in totalEbat)
            {
                cmbEbat.Items.Add(item);
            }

            Pizza klasik = new Pizza { Ad = "Klasik", Fiyat = 14 };
            Pizza karisik = new Pizza { Ad = "Karışık", Fiyat = 17 };
            Pizza turkish = new Pizza { Ad = "Turkish", Fiyat = 23 };
            Pizza tuna = new Pizza { Ad = "Tuna", Fiyat = 21 };
            Pizza akdeniz = new Pizza { Ad = "Akdeniz", Fiyat = 19 };
            Pizza karadeniz = new Pizza { Ad = "Karadeniz", Fiyat = 22 };
            List<Pizza> totalPizza = new List<Pizza> { klasik, karisik, turkish, tuna, akdeniz, karadeniz };

            foreach (Pizza pizzam in totalPizza)
            {
                listPizzalar.Items.Add(pizzam);
            }

            Kenar incekenar = new Kenar() { Ad = "İnce Kenar", Ekleme = 0 };
            rdbInceKenar.Tag = incekenar;
            Kenar kalınkenar = new Kenar() { Ad = "Kalın Kenar", Ekleme = 2 };
            rdbKalinKenar.Tag = kalınkenar;








        }
        
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                p = (Pizza)listPizzalar.SelectedItem;

                p.EbatOzellikleri = (Ebat)cmbEbat.SelectedItem;


                p.KenarOzellikleri = rdbInceKenar.Checked ? (Kenar)rdbInceKenar.Tag : (Kenar)rdbKalinKenar.Tag;
                p.Malzemeler = new List<string>();
                //Malzemeler
                foreach (CheckBox item in groupBox1.Controls)
                {
                    if (item.Checked)
                    {
                        p.Malzemeler.Add(item.Text);
                    }
                }

                decimal tutar = p.Tutar * nudAdet.Value;
                txtTutar.Text = tutar.ToString();

                s = new Siparis();
                s.pizza = p;
                s.Adet = (int)nudAdet.Value;

            }
            catch 
            {
                MessageBox.Show("Lütfen Ebatlar bölümünü doldurunuz/Pizza türünü seçiniz.");

            }

        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
           if(s!=null)
            {
                listSepet.Items.Add(s);
            }
        }

        private void btnSepetiOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                decimal toplamtutar = 0;
                int pizzaadeti = 0; ;
                string pizzaadları="";
                foreach (Siparis item in listSepet.Items)
                {
                    pizzaadları += $" {item.pizza.Ad} Pizza  ,";
                    toplamtutar += item.Adet * item.pizza.Tutar;
                    pizzaadeti++;

                }
                string cıkacakdeger = $"Alınan pizza adeti = {pizzaadeti} {Environment.NewLine}Alınan pizza adlarıı = {pizzaadları}{Environment.NewLine}Toplam Tutar= {toplamtutar}";
                lblToplamTutar.Text = toplamtutar.ToString();
                MessageBox.Show(cıkacakdeger);

            }
            catch 
            {

                MessageBox.Show("Siparis kutunuz boş.Lütfen siparisinizi sepete ekleyin.");
            }
        }
    }
}
