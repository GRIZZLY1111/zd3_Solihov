using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_Solihov
{
    public class Automobile : Car
    {
        // Год выпуска
        public int ReleaseYear { get; set; } 
        // Текущий год
        public int CurrentYear { get; set; } 
        // ID ключ
        public int ID { get; set; }

        public Automobile(int id, int km, double consumptionkm, int releaseYear, int currentYear)
            : base(km, consumptionkm)
        {
            ReleaseYear = releaseYear;
            CurrentYear = currentYear;
            ID = id;
        }

        //Метод на улучшенное качество
        public override double CalculateQuality()
        {
            return base.CalculateQuality() * 1.15 * ReleaseYear;
        }
        //Возраст машины
        public int GetAge()
        {
            return CurrentYear-ReleaseYear;
        }

        public override string ToString()
        {
            return base.ToString() + $",Год выпуска:{ReleaseYear},Возраст машины:{GetAge()}лет,Улучшенное качество Qp:{Math.Round(CalculateQuality(),2)}";
        }
    }
}
