using Tyuiu.KhrapovDY.Sprint4.Task0.V30.Lib;

namespace Tyuiu.KhrapovDY.Sprint4.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int res = ds.GetSumEvenArrEl(numsArray);
            int numsWaitArray = 30;
            Assert.AreEqual(numsWaitArray, res);
        }
    }
}