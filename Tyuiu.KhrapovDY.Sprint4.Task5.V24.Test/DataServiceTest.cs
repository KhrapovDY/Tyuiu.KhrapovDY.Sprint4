using Tyuiu.KhrapovDY.Sprint4.Task5.V24.Lib;

namespace Tyuiu.KhrapovDY.Sprint4.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -1, 6, -6, 5, 5 }, { -3, 4, -4, -5, 6 }, { 2, -4, 1, 4, -5 }, { 5, -7, 1, -4, 5 }, { 3, -5, 2, 4, -2 } }; //от -7 до 6

            int res = ds.Calculate(mas2);
            int wait = 14;
            Assert.AreEqual(wait, res);
        }
    }
}