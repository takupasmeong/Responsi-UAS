using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    public class Penjualan
    {
        // PERINTAH: lengkapi property class penjualan, sesuai petunjuk soal
        public string NoNota { get; set; }
        public DateTime Tanggal { get; set; }
        public string Customer { get; set; }
        public string JenisPembayaran { get; set; }
        public double TotalNota { get; set; }
    }
}
