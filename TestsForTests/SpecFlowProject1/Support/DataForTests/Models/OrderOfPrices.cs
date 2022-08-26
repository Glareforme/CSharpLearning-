﻿namespace SpecFlowProject1.Support.DataForTests.Models
{
    internal static class OrderOfPrices
    {
        internal static bool IsCorrectSort(List<int> currPrices) 
        {
            if (currPrices[0] > currPrices[1] | currPrices[1] > currPrices[2])
                return true;
            return false;
        }
    }
}
