using System.Collections.Generic;
using PetStore.Domain.Interfaces;
using PetStore.Domain.Model;

namespace PetStore.Domain.Repository
{
    public class PetRepository : IPetRepository
    {
        public IEnumerable<IPet> GetAll()
        {
            return new List<IPet>()
            {
                new Pet{ Name="Fluffy", Age=10 }
            };

            //throw new NotImplementedException();
        }
    }
}
