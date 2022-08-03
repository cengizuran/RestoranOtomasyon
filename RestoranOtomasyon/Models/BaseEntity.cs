using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranOtomasyon.Models
{
    public abstract class BaseEntity
    {
        protected decimal _fiyat;
        public string Isim { get; set; }
        public virtual decimal Fiyat { get; set; }

    }
}
