using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izsu
{
    class musteri
    {
        public string adi;
        public int AboneNo;
        public double BSayaci;
        public double ASayaci;
        public string EvKurum;

        public override string ToString()
        {
            return this.adi + "\t" + this.EvKurum + "\t" + this.BSayaci + "\t" + this.ASayaci + "\t" + this.AboneNo;
        }

    }
}
