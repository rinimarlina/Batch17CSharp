using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.QuizDay04
{
    internal class Taxi : Car
    {
        private int order;
        private int orderPerKM;
        private int totalKM;
        private decimal bonus;
        
        public Taxi(string noPolisi, int tahun, string type, int order, 
                    int orderPerKM, int totalKM, decimal bonus) : base(noPolisi, tahun, type)
        {
            this.Order = order;
            this.OrderPerKM = orderPerKM;
            this.TotalKM = totalKM;
            this.Bonus = bonus;
            this.Type = "Taxi";
            TotalRevenue = (order * bonus) + (orderPerKM * totalKM);
        }

        public override string? ToString()
        {
            return $"{base.ToString()} | Order = {this.order.ToString("C", new CultureInfo("id-ID"))} | " +
                    $"OrderPerKM = {this.orderPerKM.ToString("C", new CultureInfo("id-ID"))} | " +
                    $"Total KM {this.totalKM.ToString("C", new CultureInfo("id-ID"))} | " +
                    $"Bonus {this.bonus.ToString("C", new CultureInfo("id-ID"))} | {TotalRevenue.ToString()}";
        }

        public int Order { get => order; set => order = value; }
        public int OrderPerKM { get => orderPerKM; set => orderPerKM = value; }
        public int TotalKM { get => totalKM; set => totalKM = value; }
        public decimal Bonus { get => bonus; set => bonus = value; }
    }
}
