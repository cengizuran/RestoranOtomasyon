using RestoranOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCiro.Enabled = false;

            List<AraSicak> araSicaklar = new List<AraSicak> //Bu listeleri oluştururken kod tekrarına düşüyoruz, ancak her eleman için el ile değer girilmesi gerektiği için metot kullanılması da kullanışlı olmayacaktır. Dolayısıyla bir metot oluşturulmadı.
            {
                new AraSicak{Isim="Çorba", Fiyat=5},
                new AraSicak{Isim="Kiş", Fiyat=8},
                new AraSicak{Isim="Paçanga Böreği", Fiyat=10},
                new AraSicak{Isim="Sigara Böreği", Fiyat=7 }
            };

            cmbAraSicak.DataSource = araSicaklar;

            List<AnaYemek> anaYemekler = new List<AnaYemek>
            {
                new AnaYemek{Isim="Arjantin Steak", Fiyat=40},
                new AnaYemek{Isim="Karışık Izgara", Fiyat=35},
                new AnaYemek{Isim="Falafel", Fiyat=30},
                new AnaYemek{Isim="Cağ Kebabı", Fiyat=40},
            };

            cmbAnaYemek.DataSource = anaYemekler;

            List<Icecek> icecekler = new List<Icecek>
            {
                new Icecek{Isim="Coca Cola", Fiyat=6},
                new Icecek{Isim="Fanta", Fiyat=6},
                new Icecek{Isim="Beyoğlu Gazozu", Fiyat=8},
                new Icecek{Isim="Çay", Fiyat=3},
                new Icecek{Isim="Kahve", Fiyat=12}
            };

            cmbIcecek.DataSource = icecekler;

            List<Tatli> tatlilar = new List<Tatli>
            {
                new Tatli{Isim="Supangle", Fiyat=10},
                new Tatli{Isim="Tavuk Göğsü", Fiyat=16},
                new Tatli{Isim="Muhallebi", Fiyat=14},
                new Tatli{Isim="Baklava", Fiyat=18},
                new Tatli{Isim="Magnolia", Fiyat=20}
            };

            cmbTatli.DataSource = tatlilar;

            SecimleriSil();

        }

        private void SecimleriSil()
        {
            cmbAnaYemek.SelectedIndex = -1;
            cmbAnaYemek.Text = "Buradan Ana Yemek Seçebilirsiniz";
            cmbAraSicak.SelectedIndex = -1;
            cmbAraSicak.Text = "Buradan Ara Sıcak Seçebilirsiniz";
            cmbIcecek.SelectedIndex = -1;
            cmbIcecek.Text = "Buradan İçecek Seçebilirsiniz";
            cmbTatli.SelectedIndex = -1;
            cmbTatli.Text = "Buradan Tatlı Seçebilirsiniz";
            txtMasa.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            
            
            Siparis s = new Siparis();

            if (txtMasa.Text == "")
            {
                MessageBox.Show("Lütfen masa giriniz");
                return;
            }

            s.Isim = txtMasa.Text;

            s.secilenAnaYemek = cmbAnaYemek.SelectedItem as AnaYemek;
            s.secilenAraSicak = cmbAraSicak.SelectedItem as AraSicak;
            s.secilenIcecek = cmbIcecek.SelectedItem as Icecek;
            s.secilenTatli = cmbTatli.SelectedItem as Tatli;

            if (s.secilenAnaYemek==null && s.secilenAraSicak==null && s.secilenIcecek==null && s.secilenTatli== null)
            {
                MessageBox.Show("Lütfen sipariş için ürün seçiniz");
                return;
            }

            btnCiro.Enabled = true;

            s.TutarHesapla();
            lstSiparis.Items.Add(s);

            SecimleriSil();
            
        }
        
        private void btnCiro_Click(object sender, EventArgs e)
        {
            decimal ciro = 0;

            foreach (Siparis item in lstSiparis.Items)
            {
                ciro += item.Fiyat;
            }
            MessageBox.Show(ciro.ToString());
        }
    }
}
