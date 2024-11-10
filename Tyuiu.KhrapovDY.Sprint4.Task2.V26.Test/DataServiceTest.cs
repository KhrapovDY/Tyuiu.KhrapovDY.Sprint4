using Tyuiu.KhrapovDY.Sprint4.Task2.V26.Lib;

namespace Tyuiu.KhrapovDY.Sprint4.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 2, 7, 8, 5, 7, 4, 7, 8, 5, 6, 3, 8, 5 };

            int res = ds.Calculate(numsArray);
            int wait = 128625;

            Assert.AreEqual(wait, res);
        }
    }
}