using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.QuizDay04
{
    internal class SUV : Car
    {
        private Decimal sewa;
        private Decimal supir;

        public SUV(string noPolisi, int tahun, string type, decimal sewa, decimal supir) : base(noPolisi, tahun, type)
        {
            this.Sewa = sewa;
            this.Type = "SUV";
            this.supir = supir;
            TotalRevenue = sewa + supir;
        }

        public override string? ToString()
        {
            return $"{base.ToString()} | Sewa = {this.sewa.ToString("C", new CultureInfo("id-ID"))} | " +
                $"Supir = {this.Supir.ToString("C", new CultureInfo("id-ID"))} | {TotalRevenue.ToString()}";
        }

        public decimal Sewa { get => sewa; set => sewa = value; }
        public decimal Supir { get => supir; set => supir = value; }
    }
}
