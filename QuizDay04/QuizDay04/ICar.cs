using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.QuizDay04
{
    internal interface ICar
    {
        public List<Car> InitDataCar();

        public Dictionary<string, int> TotalCarByType(List<Car> list);

        public Dictionary<string, decimal> GetTotalRevenueByType(List<Car> list);

        public List<Car> FindRevenueByRange(List<Car> list, decimal startFrom, decimal endtO);

        public void ShowList<T>(ref List<T> list);

        public void ShowListType(Dictionary<string, int> list);

        public void ShowListRevenue(Dictionary<string, decimal> list);
    }
}
