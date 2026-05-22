using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace RONA_SALSABILA_2056_F_UTSPBO_E
{
    public abstract class SewaKendaraan
    {
        private string namaPenyewa { get; set; }
        private string idSewa { get; set; }
        private string tipeMobil { get; set; }

        //TambahSewa List<TambahSewa> sewakendaraan;

        public SewaKendaraan(string namaPenyewa, string idSewa, string tipeMobil)
        {
            this.namaPenyewa = namaPenyewa;
            this.idSewa = idSewa;
            this.tipeMobil = tipeMobil;
            //this.sewakendaraan = new TambahSewa List<TambahSewa>;

        }

        public abstract double hitungTotalSewa();

        //public void tambahSewa(string namaPenyewa, int idSewa, string tipeMobil)
        //{
        //    TambahSewa ts 
        //}

        //public void cetakRiwayat()
        //{
        //    index = 1;
        //    var riwayatsewa rs
        //}



        public void tampilInfo()
        {
            Console.WriteLine($"Penyewa : {namaPenyewa} | ID : {idSewa} | Mobil : {tipeMobil} ");
            Console.WriteLine($"Total Sewa : {hitungTotalSewa}");
        }

    }

}
