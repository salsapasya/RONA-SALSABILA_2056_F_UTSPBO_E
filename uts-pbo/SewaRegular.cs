using System;
using System.Collections.Generic;
using System.Text;

namespace RONA_SALSABILA_2056_F_UTSPBO_E
{
    public class SewaRegular : SewaKendaraan
    {
        private double hargaPerHari {  get; set; }
        private int lamaHari { get; set; }
        public SewaRegular(string namaPenyewa, string idSewa, string tipeMobil, double hargaPerHari, int lamHari ) : base(namaPenyewa, idSewa, tipeMobil)
        {
            this.hargaPerHari = hargaPerHari;
            this.lamaHari = lamHari;
        }
        public override double hitungTotalSewa()
        {
            return lamaHari * hargaPerHari;
        }
    }
}


