using System;
using System.Collections.Generic;
using System.Text;

namespace RONA_SALSABILA_2056_F_UTSPBO_E
{
    public class RiwayatSewa
    {
        public string jenisPaket { get; set; }
        public int lamaHari { get; set;  }
        public int tanggalSewa { get; set;  }

        public RiwayatSewa(string jenisPaket, int lamaHari, int tanggalSewa) 
        {
            this.jenisPaket = jenisPaket;
            this.lamaHari = lamaHari;
            this.tanggalSewa = tanggalSewa;
        }
    }
}
