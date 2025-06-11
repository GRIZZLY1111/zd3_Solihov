using Microsoft.VisualStudio.TestTools.UnitTesting;
using zd3_Solihov;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        //���� �� ����������� ��������
        [TestMethod]
        public void TestMethod1()
        {
            var car = new Car(10000, 2);
            double expected = 10000 / 2;
            Assert.AreEqual(expected, car.CalculateQuality());
        }
        //���� �� ����������� ����������� ��������
        [TestMethod]
        public void TestMethod2()
        {
            var car = new Automobile(1, 10000, 0.6, 2020, 2025);
            double expected = 10000 / 0.6 * 1.15* 2020;
            Assert.AreEqual(expected, car.CalculateQuality());
        }
        //���� �� ������� ������
        [TestMethod]
        public void TestMethod3()
        {
            var car = new Automobile(1, 10000, 0.6, 2020, 2025);
            double expected = 5;
            Assert.AreEqual(expected, car.GetAge());
        }
        //���� �� ���������� ������
        [TestMethod]
        public void TestMethod4()
        {
            CarManager.AddCar(10000, 2);
            double expected = 1;
            Assert.AreEqual(expected, CarManager.Cars.Count);
        }
        //���� �� ���������� ���������� ������
        [TestMethod]
        public void TestMethod5()
        {
            var car = new Car(10000, 2);
            CarManager.AddCar(car);
            double expected = 2;
            Assert.AreEqual(expected, CarManager.Cars.Count);
        }
        //���� �� ���������� ���������� ����������
        [TestMethod]
        public void TestMethod6()
        {
            var car = new Automobile(1, 10000, 0.6, 2020, 2025);
            CarManager.AddAuto(car);
            double expected = 1;
            Assert.AreEqual(expected, CarManager.Automobiles.Count);
        }
    }
}
