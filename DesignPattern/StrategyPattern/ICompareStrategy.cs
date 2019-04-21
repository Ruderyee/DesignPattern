﻿namespace StrategyPattern
{
    public interface ICompareStrategy<in T>
    {
        int Compare(T obj1, T obj2);
    }
}