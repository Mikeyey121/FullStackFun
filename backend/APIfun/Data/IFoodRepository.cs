﻿namespace APIfun.Data
{
    public interface IFoodRepository
    {
        IEnumerable<MarriottFood> Foods { get; }
    }
}
