﻿using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhrapovDY.Sprint4.Task3.V2.Lib
{
    public class DataService : ISprint4Task3V2
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int max = 0;

            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < columns; j++) 
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }
       
    }
   
}
