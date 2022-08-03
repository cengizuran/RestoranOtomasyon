using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranOtomasyon.Models
{
    public class Siparis:BaseEntity
    {
        public AnaYemek secilenAnaYemek { get; set; }
        public AraSicak secilenAraSicak { get; set; }
        public Icecek secilenIcecek { get; set; }
        public Tatli secilenTatli { get; set; }
        public override decimal Fiyat 
        {
            get
            {
                return _fiyat;
            }
            set
            {
                _fiyat = value;
            }

        }



        public void TutarHesapla()
        {
            if (secilenAnaYemek != null) _fiyat += secilenAnaYemek.Fiyat;
            if (secilenAraSicak != null) _fiyat += secilenAraSicak.Fiyat;
            if (secilenIcecek != null) _fiyat += secilenIcecek.Fiyat;
            if (secilenTatli != null) _fiyat += secilenTatli.Fiyat;
        }



        public override string ToString()
        {
            string siparisSonuc = "";

            if (secilenAnaYemek!=null) siparisSonuc+= $"{secilenAnaYemek},";
            if (secilenAraSicak != null) siparisSonuc += $"{secilenAraSicak},";
            if (secilenIcecek != null) siparisSonuc += $"{secilenIcecek},";
            if (secilenTatli != null) siparisSonuc += $"{secilenTatli},";

            siparisSonuc = siparisSonuc.Trim(',');

            siparisSonuc = $"Masa: {Isim}=> {siparisSonuc}, Toplam Tutar= {Fiyat}";

            return siparisSonuc;
        }
    }
}
