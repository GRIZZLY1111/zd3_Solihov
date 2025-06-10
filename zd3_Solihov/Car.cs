using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_Solihov
{
    public class Car
    {
        // Пробег
        public int Km { get; set; }     
        // Расход на км
        public double ConsumptionKm { get; set; } 

        public Car(int km, double consumptionkm)
        {
            Km = km;
            ConsumptionKm = consumptionkm;
        }

        // Функция качества
        public virtual double CalculateQuality()
        {
            return Km / ConsumptionKm;
        }

        // Вывод информации
        public override string ToString()
        {
            return $"Пробег:{Km}км,Расход:{ConsumptionKm}л/км,Качество Q:{Math.Round(CalculateQuality(), 2)}";
        }
    }
}
