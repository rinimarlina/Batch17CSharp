using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.QuizDay04
{
    internal class Car
    {
        //instance variable
        private string noPolisi;
        private string type;
        private int tahun;
        private Decimal totalRevenue = 0M;

        public Car(string noPolisi, int tahun, string type)
        {
            this.noPolisi = noPolisi;
            this.type = type;
            this.tahun = tahun;
            
        }

        public override string? ToString()
        {
            return $"No Polisi : {this.noPolisi} | Tahun :{this.tahun} | Type : {this.type}";
        }

        public string NoPolisi { get => noPolisi; set => noPolisi = value; }
        public string Type { get => type; set => type = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public decimal TotalRevenue { get => totalRevenue; set => totalRevenue = value; }
    }
}

