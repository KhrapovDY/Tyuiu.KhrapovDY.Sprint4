using Tyuiu.KhrapovDY.Sprint4.Task6.V15.Lib;

namespace Tyuiu.KhrapovDY.Sprint4.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var city = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };
            int res = ds.Calculate(city);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}