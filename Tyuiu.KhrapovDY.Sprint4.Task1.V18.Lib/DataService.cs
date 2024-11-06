﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhrapovDY.Sprint4.Task1.V18.Lib
{
    public class DataService : ISprint4Task1V18
    {
        public int Calculate(int[] array)
        {
            int SumArray = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    SumArray += array[i];
                }
            }
            return SumArray;

        }
    }
}
