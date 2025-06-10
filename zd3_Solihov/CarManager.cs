using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_Solihov
{
    public static class CarManager
    {
        public static List<Car> Cars = new List<Car>();
        public static Dictionary<int, Automobile> Automobiles = new Dictionary<int, Automobile>();
        private static int NextId = 1;
        // Добавляем машину из базового класса
        public static void AddCar(Car car) => Cars.Add(car);
        // Перегрузка добавления базового класса. Добавляем через параметры
        public static void AddCar(int km, double consumption) => Cars.Add(new Car(km, consumption));
        // Добавляем автомобиль с ID
        public static void AddAuto(Automobile auto)
        {
            if (!Automobiles.ContainsKey(auto.ID))
                Automobiles[auto.ID] = auto;
        }
        // Перегрузка добавления класса наследника. Добавляем через параметры
        public static void AddAuto(int km, double consumptionkm, int releaseYear, int currentYear)
        {
            var auto = new Automobile(NextId++, km, consumptionkm, releaseYear, currentYear);
            Automobiles[auto.ID] = auto;
        }
        // Удаление автомобиля из класса наследника по ID
        public static void RemoveAuto(int id) => Automobiles.Remove(id);
        //Удаление автомобиля по объекту
        public static void RemoveAuto(Automobile auto) => Automobiles.Remove(auto.ID);
        // Удаление машины из базового класса по индексу
        public static void RemoveCar(int index)
        {
            if (index >= 0 && index < Cars.Count)
                Cars.RemoveAt(index);
        }
        // Перегрузка удаления машины из базового класса по объекту
        public static void RemoveCar(Car car)
        {
            Cars.Remove(car);
        }
        // Получаем список всех автомобилей
        public static List<Automobile> GetAllAutos() => Automobiles.Values.ToList();
        // Все объекты для отображения
        public static List<object> GetAllItems()
        {
            return Cars.Cast<object>().Concat(Automobiles.Values).ToList();
        }
    }
}
