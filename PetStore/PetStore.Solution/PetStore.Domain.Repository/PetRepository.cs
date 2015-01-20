using PetStore.Domain.Interfaces;
using PetStore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
