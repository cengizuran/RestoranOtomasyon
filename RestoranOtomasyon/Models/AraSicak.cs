using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranOtomasyon.Models
{
    public class AraSicak:BaseEntity
    {
        public override string ToString()
        {
            return $"{Isim}, {Fiyat:C2}";
        }
    }
}
