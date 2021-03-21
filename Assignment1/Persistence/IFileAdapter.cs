using System.Collections.Generic;
using Models;

namespace Assignment1.Persistence
{
    public interface IFileAdapter
    {
        List<Adult> GetAdults();
        void AddAdult(Adult adult);
        Adult GetAdult(int id);
        void RemoveAdult(Adult adult);

        void Update(Adult adult);
    }
}