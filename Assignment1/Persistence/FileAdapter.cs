using System;
using System.Collections.Generic;
using System.Linq;
using FileData;
using Models;

namespace Assignment1.Persistence
{
    public class FileAdapter : IFileAdapter, IStatisticsModel
    {
        private FileContext Context;

        public FileAdapter()
        {
            Context = new FileContext();
        }
        public List<Adult> GetAdults()
        {
            List<Adult> adults = new List<Adult>(Context.Adults);
            return adults;
        }
        
        public void AddAdult(Adult adult)
        {
            int id = Context.Adults.Max(max => max.Id) + 1;
            adult.Id = id;
            Context.Adults.Add(adult);
            Context.SaveChanges();
        }

        public Adult GetAdult(int id)
        {
            return Context.Adults.First(a => a.Id == id);
        }

        public void RemoveAdult(Adult adult)
        {
            Context.Adults.Remove(adult);
            Context.SaveChanges();
        }

        public void Update(Adult adult)
        {
            Adult ad = Context.Adults.First(a => a.Id == adult.Id);
            ad.FirstName = adult.FirstName;
            ad.LastName = adult.LastName;
            ad.Age = adult.Age;
            ad.Height = adult.Height;
            ad.Weight = adult.Weight;
            ad.JobTitle = adult.JobTitle;
            ad.EyeColor = adult.EyeColor;
            ad.Sex = adult.Sex;
            ad.HairColor = adult.HairColor;
            ad.Id = adult.Id;
            Context.SaveChanges();
        }

        public int GetAdultAgeGroup(int minimum, int maximum)
        {
            int count = 0;
            foreach (var a in Context.Adults)
            {
                if (a.Age >= minimum && a.Age <= maximum)
                {
                    count++;
                }
            }
            return count;
        }

        public double GetEyeColorPercentage(string color)
        {
            int count = 0;
            foreach (var a in Context.Adults)
            {
                if (a.EyeColor.Equals(color))
                {
                    count++;
                }
            }
            return (double)count / Context.Adults.Count;
        }
    }
}