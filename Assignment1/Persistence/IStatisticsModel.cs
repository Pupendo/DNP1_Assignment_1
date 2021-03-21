using System.Collections.Generic;
using Models;

namespace Assignment1.Persistence
{
    public interface IStatisticsModel
    {
        int GetAdultAgeGroup(int minimum, int maximum);

        double GetEyeColorPercentage(string color);
    }
}