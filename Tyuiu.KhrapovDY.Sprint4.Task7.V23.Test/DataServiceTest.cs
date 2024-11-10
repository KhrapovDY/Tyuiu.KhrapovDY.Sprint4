using Tyuiu.KhrapovDY.Sprint4.Task7.V23.Lib;

namespace Tyuiu.KhrapovDY.Sprint4.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int n = 4;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string value = "678135972584";
            DataService ds = new DataService();
            int res = ds.Calculate(n , m, value);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}