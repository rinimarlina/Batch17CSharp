using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.QuizDay04
{
    internal class Angkot : Car
    {
        private Decimal hargaTiket;
        private int totalPenumpang;

        public Angkot(string noPolisi, int tahun, string type, decimal hargaTiket, int totalPenumpang) : base(noPolisi, tahun, type)
        {
            this.HargaTiket = hargaTiket;
            this.TotalPenumpang = totalPenumpang;
            this.Type = "Angkot";
            TotalRevenue = hargaTiket * totalPenumpang;
        }

        public override string? ToString()
        {
            return $"{base.ToString()} | Harga Tiket = {this.hargaTiket.ToString("C", new CultureInfo("id-ID"))} | " +
                $"Total Penumpang = {this.totalPenumpang.ToString("C", new CultureInfo("id-ID"))} | {TotalRevenue.ToString()}";
        }

        public decimal HargaTiket { get => hargaTiket; set => hargaTiket = value; }
        public int TotalPenumpang { get => totalPenumpang; set => totalPenumpang = value; }
    }
}
