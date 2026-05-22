using System;
using System.Collections.Generic;
using System.Text;

namespace RONA_SALSABILA_2056_F_UTSPBO_E
{
    public class SewaPremium : SewaKendaraan
    {
        private double hargaPerHari { get; set; }
        private double biayaSopir { get; set; }
        private int lamaHari { get; set; }

        public SewaPremium(string namaPenyewa, string idSewa, string tipeMobil, double hargaPerHari, double biayaSopir, int lamaHari   ) : base(namaPenyewa, idSewa, tipeMobil)
        {
            this.hargaPerHari = hargaPerHari;
            this.biayaSopir = biayaSopir;
            this.lamaHari = lamaHari;
        }

        public override double hitungTotalSewa()
        {
            return (lamaHari * hargaPerHari) + biayaSopir;
        }
       
        
    }
}
